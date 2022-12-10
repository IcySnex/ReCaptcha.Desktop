using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ReCaptcha.Desktop.Sample.WPF.Services;
using ReCaptcha.Desktop.Sample.WPF.Views;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace ReCaptcha.Desktop.Sample.WPF.ViewModels;

public partial class MainViewModel : ObservableObject
{
    readonly ILogger<MainViewModel> logger;

    readonly public MainView MainView;

    public MainViewModel(
        ILogger<MainViewModel> logger,
        IOptions<Models.Configuration> configuration,
        JsonConverter jsonConverter)
    {
        this.logger = logger;

        MainView = new() { DataContext = this };
        MainView.Show();

        MainView.Closed += async (s, e) =>
        {
            if (LoggerWindow is not null)
                LoggerWindow.Close();

            string config = jsonConverter.ToString(configuration.Value);
            await File.WriteAllTextAsync("Configuration.json", config);

            logger.LogInformation("[MainView-Closed] Closed main window");
        };
    }


    [ObservableProperty]
    ObservableObject? currentViewModel;

    public bool Navigate<T>()
    {
        if (!(App.Provider.GetService<T>() is ObservableObject viewModel))
            return false;

        CurrentViewModel = viewModel;
        logger.LogInformation("[MainViewModel-Navigate] Navigated to page");

        return true;
    }


    [RelayCommand]
    void NavigateToHome() =>
        Navigate<HomeViewModel>();

    [RelayCommand]
    void NavigateToSettings() =>
        Navigate<SettingsViewModel>();

    [RelayCommand]
    void OpenGithub() =>
        Process.Start(new ProcessStartInfo()
        {
            FileName = "https://github.com/IcySnex/ReCaptcha.Desktop",
            UseShellExecute = true,
            CreateNoWindow = true
        });


    public Window? LoggerWindow;

    [RelayCommand]
    void CreateLogger()
    {
        if (LoggerWindow is not null)
        {
            LoggerWindow.Activate();
            return;
        }

        TextBox textBox = new()
        {
            IsReadOnly = true,
            VerticalAlignment = VerticalAlignment.Stretch,
            HorizontalAlignment = HorizontalAlignment.Stretch
        };
        ScrollViewer.SetVerticalScrollBarVisibility(textBox, ScrollBarVisibility.Auto);
        ScrollViewer.SetHorizontalScrollBarVisibility(textBox, ScrollBarVisibility.Auto);

        Window window = new()
        {
            Title = "ReCaptcha.Desktop - WPF Sample (Logger)",
            Width = 600,
            Height = 400,
            Content = textBox
        };

        void handler(object? s, string e) =>
            textBox.Text += e;

        App.Sink.OnNewLog += handler;
        window.Closed += (s, e) =>
        {
            App.Sink.OnNewLog -= handler;
            LoggerWindow = null;
        };

        LoggerWindow = window;
        LoggerWindow.Show();

        logger.LogInformation("[HomeViewModel-CreateLoggerWindow] Created new LoggerWindow and hooked handler");
    }
}