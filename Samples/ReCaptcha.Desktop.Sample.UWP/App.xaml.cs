#nullable enable

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using ReCaptcha.Desktop.Client.UWP;
using ReCaptcha.Desktop.Sample.UWP.Models;
using ReCaptcha.Desktop.Sample.UWP.Services;
using ReCaptcha.Desktop.Sample.UWP.ViewModels;
using ReCaptcha.Desktop.Sample.UWP.Views;
using Serilog;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.WindowManagement;
using Windows.UI.Xaml;

namespace ReCaptcha.Desktop.Sample.UWP;

sealed partial class App : Application
{
    readonly IHost host;

    public static IServiceProvider Provider { get; private set; } = default!;
    public static InMemorySink Sink { get; private set; } = new();
    public static AppWindow? LoggerWindow = null;

    public App()
    {
        host = Host.CreateDefaultBuilder()
        .UseSerilog((context, configuration) =>
        {
            configuration.WriteTo.Debug();
            configuration.WriteTo.Sink(Sink);
        })
        .ConfigureAppConfiguration((context, builder) =>
        {
            builder.AddJsonFile($@"{ApplicationData.Current.LocalFolder.Path}\Configuration.json", true);
        })
        .ConfigureServices((context, services) =>
        {
            services.Configure<Models.Configuration>(context.Configuration);
            Models.Configuration configuration = context.Configuration.Get<Models.Configuration>() ?? new();

            // Add ViewModels and MainView
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<SettingsViewModel>();
            services.AddSingleton<CaptchaViewModel>();

            // Add services
            services.AddSingleton<JsonConverter>();
            services.AddSingleton<Navigation>();
            services.AddSingleton(new ReCaptchaClient(new(configuration.SiteKey), new(configuration.Title)));
        })
        .Build();
        Provider = host.Services;
    }


    protected override void OnLaunched(LaunchActivatedEventArgs e)
    {
        Window.Current.Content = new MainView();
        ApplicationView.PreferredLaunchViewSize = new(900, 700);

        ApplicationView appView = ApplicationView.GetForCurrentView();
        appView.SetPreferredMinSize(new(500, 500));

        CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
        appView.TitleBar.ButtonBackgroundColor = Colors.Transparent;
        appView.TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;


        Navigation navigation = Provider.GetRequiredService<Navigation>();
        navigation.Navigate("Home");

        Window.Current.Activate();


        JsonConverter converter = Provider.GetRequiredService<JsonConverter>();
        IOptions<Models.Configuration> configuration = Provider.GetRequiredService<IOptions<Models.Configuration>>();

        Suspending += async (s, e) =>
        {
            SuspendingDeferral deferral = e.SuspendingOperation.GetDeferral();

            if (LoggerWindow is not null)
                await LoggerWindow.CloseAsync();

            string config = converter.ToString(configuration.Value);
            StorageFile configFile = await ApplicationData.Current.LocalFolder.CreateFileAsync("Configuration.json", CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(configFile, config);
            
            deferral.Complete();
        };
    }
}

public static class Extentions
{
    public static Type? AsType(this string input,
        string assembly = "ReCaptcha.Desktop.Sample.UWP") =>
        Type.GetType($"{assembly}.{input}, {assembly}");
}