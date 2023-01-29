using Microsoft.Extensions.Configuration;
using ReCaptcha.Desktop.Sample.WinForms.Services;
using Serilog;

namespace ReCaptcha.Desktop.Sample.WinForms;

internal static class Program
{
    public static Models.Configuration Configuration { get; private set; } = default!;

    public static InMemorySink Sink { get; } = new();
    public static ILogger Logger { get; } = new LoggerConfiguration()
        .WriteTo.Debug()
        .WriteTo.Sink(Sink)
        .CreateLogger();

    public static JsonConverter JsonConverter { get; } = new(Logger);

    public static MainForm MainForm { get; } = new MainForm();


    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        Configuration = new ConfigurationBuilder()
           .AddJsonFile("Configuration.json", true)
           .Build()
           .Get<Models.Configuration>() ?? new();

        Application.Run(MainForm);


        string config = JsonConverter.ToString(Configuration);
        File.WriteAllText("Configuration.json", config);

        Logger.Information("[Program-Main] Closed main window");
    }
}