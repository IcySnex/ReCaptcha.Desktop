using Microsoft.UI.Xaml;
using Microsoft.Extensions.Hosting;
using Serilog;
using Microsoft.Extensions.Configuration;
using ReCaptcha.Desktop.Sample.WinUI.Services;
using Microsoft.Extensions.DependencyInjection;
using ReCaptcha.Desktop.Client.WinUI;
using ReCaptcha.Desktop.Sample.WinUI.Views;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ReCaptcha.Desktop.Sample.WinUI.ViewModels;

namespace ReCaptcha.Desktop.Sample.WinUI;

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

                // Add ViewModels and MainView
                services.AddSingleton<HomeViewModel>();
                services.AddSingleton<SettingsViewModel>();
                services.AddSingleton<CaptchaViewModel>();

                services.AddSingleton(provider => new MainView() { Title = "ReCaptcha.Desktop - WinUI3 Sample" });


                // Add services
                services.AddSingleton<JsonConverter>();
                services.AddSingleton<WindowHelper>();
                services.AddSingleton<MicaBackdropHandler>();
                services.AddSingleton<AcrylicBackdropHandler>();
                services.AddSingleton<Navigation>();
                services.AddSingleton(new ReCaptchaClient(new(configuration.SiteKey), new(configuration.Title)));
            })
            .Build();
        Provider = host.Services;
    }


    protected override async void OnLaunched(LaunchActivatedEventArgs _)
    {
        await host.StartAsync().ConfigureAwait(false);

        ILogger<App> logger = Provider.GetRequiredService<ILogger<App>>();
        IOptions<Models.Configuration> configuration = Provider.GetRequiredService<IOptions<Models.Configuration>>();
        WindowHelper windowHelper = Provider.GetRequiredService<WindowHelper>();
        MicaBackdropHandler mica = Provider.GetRequiredService<MicaBackdropHandler>();
        AcrylicBackdropHandler acrylic = Provider.GetRequiredService<AcrylicBackdropHandler>();
        JsonConverter converter = Provider.GetRequiredService<JsonConverter>();
        MainView mainView = Provider.GetRequiredService<MainView>();
        Navigation navigation = Provider.GetRequiredService<Navigation>();

        windowHelper.SetTitleBar(mainView.TitleBarDragArea, mainView.TitleBarContainer);
        windowHelper.SetIcon("Icon.ico");
        windowHelper.SetSize(900, 500);

        windowHelper.EnsureWindowsSystemDispatcherQueueController();
        if (!configuration.Value.UseMica || !mica.EnableBackdrop())
            acrylic.EnableBackdrop();

        mainView.Closed += async (s, e) =>
        {
            windowHelper.LoggerView?.Close();

            string config = converter.ToString(configuration.Value);
            await File.WriteAllTextAsync("Configuration.json", config);

            logger.LogInformation("[MainView-Closed] Closed main window");
        };
        mainView.Activate();

        navigation.Navigate("Home");
    }
}

public static class Extentions
{
    public static Type? AsType(this string input,
        string assembly = "ReCaptcha.Desktop.Sample.WinUI") =>
        Type.GetType($"{assembly}.{input}, {assembly}");
}