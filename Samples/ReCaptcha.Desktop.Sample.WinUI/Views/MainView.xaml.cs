using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using ReCaptcha.Desktop.Sample.WinUI.Services;
using Windows.System;

namespace ReCaptcha.Desktop.Sample.WinUI.Views;

public sealed partial class MainView : Window
{
    public MainView() =>
        InitializeComponent();


    private void OnLoggerClick(object _, RoutedEventArgs _1) =>
        App.Provider.GetRequiredService<WindowHelper>().CreateLoggerView();

    private async void OnGithubClick(object _, RoutedEventArgs _1) =>
        await Launcher.LaunchUriAsync(new("https://github.com/IcySnex/ReCaptcha.Desktop"));
}