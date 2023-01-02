using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using Windows.System;
using Windows.UI.WindowManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;

namespace ReCaptcha.Desktop.Sample.UWP.Views;

public sealed partial class MainView : Page
{
    public MainView() =>
        InitializeComponent();


    private async void OnLoggerClick(object _, RoutedEventArgs _1)
    {
        if (App.LoggerWindow is not null)
        {
            await App.LoggerWindow.TryShowAsync();
            return;
        }

        TextBlock contentBlock = new()
        {
            Margin = new(4),
            HorizontalAlignment = HorizontalAlignment.Left,
            VerticalAlignment = VerticalAlignment.Top
        };
        ScrollViewer scrollViewer = new() { Content = contentBlock };
        ScrollViewer.SetHorizontalScrollBarVisibility(scrollViewer, ScrollBarVisibility.Auto);
        ScrollViewer.SetVerticalScrollBarVisibility(scrollViewer, ScrollBarVisibility.Auto);

        App.LoggerWindow = await AppWindow.TryCreateAsync();
        App.LoggerWindow.Title = "ReCaptcha.Desktop - UWP Sample (Logger)";
        ElementCompositionPreview.SetAppWindowContent(App.LoggerWindow, scrollViewer);

        void handler(object? s, string e) =>
            contentBlock.Text += e;

        App.Sink.OnNewLog += handler;
        App.LoggerWindow.Closed += (s, e) =>
        {
            App.Sink.OnNewLog -= handler;
            App.LoggerWindow = null;
        };

        await App.LoggerWindow.TryShowAsync();

        App.Provider.GetRequiredService<ILogger<MainView>>().LogInformation("Created new LoggerWindow and hooked handler");
    }

    private async void OnGithubClick(object _, RoutedEventArgs _1) =>
            await Launcher.LaunchUriAsync(new("https://github.com/IcySnex/ReCaptcha.Desktop"));
}