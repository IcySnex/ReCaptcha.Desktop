#nullable enable

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReCaptcha.Desktop.Sample.UWP.Models;
using ReCaptcha.Desktop.Sample.UWP.Services;
using ReCaptcha.Desktop.Sample.UWP.ViewModels;
using Serilog;
using System;
using System.Diagnostics;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace ReCaptcha.Desktop.Sample.UWP
{
    sealed partial class App : Application
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
                services.AddSingleton<SettingsViewModel>();
                //services.AddSingleton<CaptchaViewModel>();

                // Add services
                //services.AddSingleton<JsonConverter>();
                //services.AddSingleton<WindowHelper>();
                //services.AddSingleton<MicaBackdropHandler>();
                //services.AddSingleton<AcrylicBackdropHandler>();
                services.AddSingleton<Navigation>();
                //services.AddSingleton(new ReCaptchaClient(new(configuration.SiteKey), new(configuration.Title)));
            })
            .Build();
            Provider = host.Services;

            Suspending += OnSuspending;
        }


        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            // UI
            Frame contentFrame = new() { Background = (Brush)Current.Resources["SystemControlAcrylicWindowBrush"] };

            StackPanel footer = new() { Spacing = 8, Orientation = Orientation.Horizontal };
            footer.Children.Add(new Button()
            {
                Content = "Show Logger",
                Background = new SolidColorBrush(Colors.Transparent),
                BorderBrush = new SolidColorBrush(Colors.Transparent)
            });
            footer.Children.Add(new Button()
            {
                Content = "Open GitHub",
                Background = new SolidColorBrush(Colors.Transparent),
                BorderBrush = new SolidColorBrush(Colors.Transparent)
            });

            NavigationView navigationView = new()
            {
                IsSettingsVisible = false,
                PaneDisplayMode = NavigationViewPaneDisplayMode.Top,
                PaneFooter = footer,
                Content = contentFrame,
            };
            BindingOperations.SetBinding(navigationView, NavigationView.IsBackEnabledProperty, new Binding()
            {
                Source = contentFrame,
                Path = new("CanGoBack"),
                Mode = BindingMode.OneWay
            });
            navigationView.MenuItems.Add(new NavigationViewItem() { Content = "Home", Icon = new SymbolIcon(Symbol.Home) });
            navigationView.MenuItems.Add(new NavigationViewItem() { Content = "Settings", Icon = new SymbolIcon(Symbol.Setting) });
            navigationView.PaneFooter = footer;
            Grid.SetRow(navigationView, 1);

            StackPanel titleBarContainer = new()
            {
                Spacing = 12,
                Orientation = Orientation.Horizontal,
                Padding = new(12, 0, 0, 0),
                Background = (Brush)Current.Resources["NavigationViewDefaultPaneBackground"]
            };
            titleBarContainer.Children.Add(new Image()
            {
                Source = new BitmapImage(new("ms-appx:///Icon.png")),
                Height = 19,
                Width = 19,
                HorizontalAlignment = HorizontalAlignment.Left
            });
            titleBarContainer.Children.Add(new TextBlock()
            {
                Text = "ReCaptcha.Desktop - UWP Sample",
                FontSize = 12,
                VerticalAlignment = VerticalAlignment.Center
            });

            Grid rootLayout = new();
            rootLayout.RowDefinitions.Add(new() { Height = new(48) });
            rootLayout.RowDefinitions.Add(new() { Height = new(1, GridUnitType.Star) });
            rootLayout.Children.Add(titleBarContainer);
            rootLayout.Children.Add(navigationView);

            Window.Current.Content = rootLayout;


            // Window
            ApplicationView.PreferredLaunchViewSize = new(900, 500);

            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;


            // Navigation
            Navigation navigation = Provider.GetRequiredService<Navigation>();
            navigation.Navigate("Home");

            Window.Current.Activate();

        }


        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            Debug.WriteLine("ter");
            deferral.Complete();
        }
    }

    public static class Extentions
    {
        public static Type? AsType(this string input,
            string assembly = "ReCaptcha.Desktop.Sample.UWP") =>
            Type.GetType($"{assembly}.{input}, {assembly}");
    }
}
