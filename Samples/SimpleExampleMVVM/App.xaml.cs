﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ReCaptcha.Desktop.WPF.Client;
using ReCaptcha.Desktop.WPF.Client.Interfaces;
using ReCaptcha.Desktop.WPF.Configuration;
using SimpleExampleMVVM.ViewModel;
using System;
using System.Windows;

namespace SimpleExampleMVVM;

public partial class App : Application
{
    readonly IHost host;
    public static IServiceProvider Provider { get; private set; } = default!;

    public App()
    {
        host = Host.CreateDefaultBuilder()
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddDebug();
            })
            .ConfigureServices((context, services) =>
            {
                // Add Services
                services.AddSingleton<IReCaptchaClient>(provider => new ReCaptchaClient(
                    "SITE_KEY".AsReCaptchaConfig("example.mvvm"),
                    "WINDOW_TITLE".AsWindowConfig(),
                    provider.GetRequiredService<ILogger<IReCaptchaClient>>()));

                // Add ViewModels
                services.AddSingleton<CaptchaViewModel>();
            })
            .Build();
        Provider = host.Services;
    }
}