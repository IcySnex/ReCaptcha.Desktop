using Microsoft.Extensions.Hosting;
using System;
using Serilog;
using System.Windows;
using Microsoft.Extensions.Configuration;
using ReCaptcha.Desktop.Client.WPF;
using Microsoft.Extensions.DependencyInjection;
using ReCaptcha.Desktop.Configuration;
using System.Windows.Media;
using Microsoft.Extensions.Logging;
using ReCaptcha.Desktop.Sample.WPF.Services;
using ReCaptcha.Desktop.Sample.WPF.ViewModels;
using ReCaptcha.Desktop.Sample.WPF.Views;

namespace ReCaptcha.Desktop.Sample.WPF;

public partial class App : Application
{
    readonly IHost host;
    public static IServiceProvider Provider { get; private set; } = default!;

    public App()
    {
        host = Host.CreateDefaultBuilder()
            .UseSerilog((context, configuration) =>
            {
                configuration.WriteTo.Debug();
            })
            .ConfigureAppConfiguration((context, builder) =>
            {
                builder.AddJsonFile("Configuration.json", true);
            })
            .ConfigureServices((context, services) =>
            {
                // Create all configurations
                HttpServerConfig httpConfig = new(
                    url: context.Configuration.GetValue<string>("HttpUrl")!,
                    port: context.Configuration.GetValue<int>("HttpPort")!);

                ReCaptchaConfig reCaptchaConfig = new(
                    siteKey: context.Configuration.GetValue<string>("SiteKey")!,
                    language: context.Configuration.GetValue<string>("Language")!,
                    tokenRecievedHtml: context.Configuration.GetValue<string>("TokenRecievedHtml")!,
                    tokenRecievedHookedHtml: context.Configuration.GetValue<string>("TokenRecievedHookedHtml")!,
                    httpConfiguration: httpConfig);

                WindowConfig windowConfig = new(
                    title: context.Configuration.GetValue<string>("Title")!,
                    icon: context.Configuration.GetValue<ImageSource>("Icon")!,
                    startupLocation: context.Configuration.GetValue<WindowStartupLocation>("StartupLocation"),
                    left: context.Configuration.GetValue<int>("Left"),
                    top: context.Configuration.GetValue<int>("Top"),
                    showAsDialog: context.Configuration.GetValue<bool>("ShowAsDialog"),
                    resizeToCenter: context.Configuration.GetValue<bool>("ResizeToCenter"));


                // Add ViewModels and MainView
                services.AddSingleton<HomeViewModel>();
                services.AddSingleton<SettingsViewModel>();

                services.AddSingleton<MainView>();


                // Add services
                services.AddSingleton<JsonConverter>();
                services.AddSingleton<Navigation>();

                services.AddSingleton((services) => new ReCaptchaClient(
                    reCaptchaConfig,
                    windowConfig,
                    services.GetRequiredService<ILogger<ReCaptchaClient>>()));
            })
            .Build();
        Provider = host.Services;
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        MainView mainView = Provider.GetRequiredService<MainView>();
        mainView.Show();
    }
}