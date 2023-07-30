using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ReCaptcha.Desktop.Sample.WinForms.Services;
using Serilog;
using Serilog.Extensions.Logging;
using ReCaptcha.Desktop.Sample.WinForms.Models;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace ReCaptcha.Desktop.Sample.WinForms;

internal static class Program
{
    public static Configuration Configuration { get; private set; } = default!;

    public static InMemorySink Sink { get; } = new();
    public static SerilogLoggerFactory LoggerFactory = new(
        new LoggerConfiguration()
        .WriteTo.Debug()
        .WriteTo.Sink(Sink)
        .CreateLogger());

    public static JsonConverter JsonConverter { get; } = new(LoggerFactory.CreateLogger<JsonConverter>());

    public static MainForm MainForm { get; } = new MainForm();


    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        Configuration = new ConfigurationBuilder()
           .AddJsonFile("Configuration.json", true)
           .Build()
           .Get<Configuration>() ?? new();

        Application.Run(MainForm);


        string config = JsonConverter.ToString(Configuration);
        File.WriteAllText("Configuration.json", config);

        ILogger logger = LoggerFactory.CreateLogger(typeof(Program));
        logger.LogInformation("[Program-Main] Closed main window");
    }
}