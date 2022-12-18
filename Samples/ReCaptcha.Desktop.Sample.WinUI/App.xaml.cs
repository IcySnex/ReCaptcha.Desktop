using Microsoft.UI.Xaml;
using Microsoft.Extensions.Hosting;
using Serilog;
using Microsoft.Extensions.Configuration;

namespace ReCaptcha.Desktop.Sample.WinUI;

public partial class App : Application
{
    readonly IHost host;

    public static IServiceProvider Provider { get; private set; } = default!;
    //public static InMemorySink Sink { get; private set; } = new();

    public App()
    {
        host = Host.CreateDefaultBuilder()
            .UseSerilog((context, configuration) =>
            {
                configuration.WriteTo.Debug();
                //configuration.WriteTo.Sink(Sink);
            })
            .ConfigureAppConfiguration((context, builder) =>
            {
                builder.AddJsonFile("Configuration.json", true);
            })
            .ConfigureServices((context, services) =>
            {
            })
            .Build();
        Provider = host.Services;
    }


    protected override async void OnLaunched(
        LaunchActivatedEventArgs _)
    {
        await host.StartAsync().ConfigureAwait(false);

        MainWindow window = new();
        window.Activate();
    }
}
