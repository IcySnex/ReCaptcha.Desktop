using Microsoft.Extensions.Hosting;
using System;
using Serilog;
using System.Windows;
using Microsoft.Extensions.Configuration;
using ReCaptcha.Desktop.Client.WPF;
using Microsoft.Extensions.DependencyInjection;
using ReCaptcha.Desktop.Configuration;
using Microsoft.Extensions.Logging;
using ReCaptcha.Desktop.Sample.WPF.Services;
using ReCaptcha.Desktop.Sample.WPF.ViewModels;
using System.Windows.Media.Imaging;

namespace ReCaptcha.Desktop.Sample.WPF;

public partial class App : Application
{
    readonly IHost host;

    public static IServiceProvider Provider { get; private set; } = default!;
    public static InMemorySink Sink { get; private set; } = new();

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
                builder.AddJsonFile("Configuration.json", true);
            })
            .ConfigureServices((context, services) =>
            {
                services.Configure<Models.Configuration>(context.Configuration);
                Models.Configuration configuration = context.Configuration.Get<Models.Configuration>() ?? new();

                // Create all configurations
                HttpServerConfig httpConfig = new(
                    url: configuration.HttpUrl,
                    port: configuration.HttpPort);
                ReCaptchaConfig reCaptchaConfig = new(
                    siteKey: configuration.SiteKey,
                    language: configuration.Language,
                    tokenRecievedHtml: configuration.TokenRecievedHtml,
                    tokenRecievedHookedHtml: configuration.TokenRecievedHookedHtml,
                    httpConfiguration: httpConfig);

                WindowConfig windowConfig = new(
                    title: configuration.Title,
                    icon: new BitmapImage(new(configuration.Icon)),
                    startupLocation: configuration.StartupLocation,
                    left: configuration.Left,
                    top: configuration.Top,
                    showAsDialog: configuration.ShowAsDialog,
                    resizeToCenter: configuration.ResizeToCenter);


                // Add ViewModels and MainView
                services.AddSingleton<HomeViewModel>();
                services.AddSingleton<CaptchaViewModel>();
                services.AddSingleton<SettingsViewModel>();

                services.AddSingleton<MainViewModel>();


                // Add services
                services.AddSingleton<JsonConverter>();

                services.AddSingleton(reCaptchaConfig);
                services.AddSingleton(windowConfig);
                services.AddSingleton<ReCaptchaClient>();
            })
            .Build();
        Provider = host.Services;
    }


    protected override void OnStartup(StartupEventArgs e) =>
        Provider.GetRequiredService<MainViewModel>().Navigate<HomeViewModel>();
}