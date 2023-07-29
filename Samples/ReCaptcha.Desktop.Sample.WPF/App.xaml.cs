using Microsoft.Extensions.Hosting;
using System;
using Serilog;
using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReCaptcha.Desktop.Sample.WPF.Services;
using ReCaptcha.Desktop.Sample.WPF.ViewModels;
using Microsoft.Extensions.Logging;
using ReCaptcha.Desktop.WPF.Client;
using ReCaptcha.Desktop.WPF.Client.Interfaces;
using ReCaptcha.Desktop.Sample.WPF.Models;

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
                services.Configure<Configuration>(context.Configuration);
                Configuration configuration = context.Configuration.Get<Configuration>() ?? new();

                // Add ViewModels and MainView
                services.AddSingleton<HomeViewModel>();
                services.AddSingleton<CaptchaViewModel>();
                services.AddSingleton<SettingsViewModel>();

                services.AddSingleton<MainViewModel>();


                // Add services
                services.AddSingleton<JsonConverter>();
                services.AddSingleton<IReCaptchaClient>(s => new ReCaptchaClient(
                    new(configuration.SiteKey, configuration.HostName),
                    new(configuration.Title),
                    s.GetRequiredService<ILogger<IReCaptchaClient>>()));
            })
            .Build();
        Provider = host.Services;
    }


    protected override void OnStartup(StartupEventArgs _) =>
        Provider.GetRequiredService<MainViewModel>().Navigate<HomeViewModel>();
}