using Serilog;
using System.Text.Json;

namespace ReCaptcha.Desktop.Sample.WinForms.Services;

public class JsonConverter
{
    readonly ILogger logger;

    public JsonConverter(
        ILogger logger)
    {
        this.logger = logger;

        logger.Information("Registered JsonConverter");
    }


    public string ToString(
        object input)
    {
        logger.Information("Serializing object to string");
        return JsonSerializer.Serialize(input);
    }

    public T? ToObject<T>(
        string input)
    {
        logger.Information("Deserializing string to object");
        return JsonSerializer.Deserialize<T>(input);
    }
}