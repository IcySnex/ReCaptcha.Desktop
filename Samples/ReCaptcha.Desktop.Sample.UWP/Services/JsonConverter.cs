using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace ReCaptcha.Desktop.Sample.UWP.Services;

public class JsonConverter
{
    readonly ILogger<JsonConverter> logger;

    public JsonConverter(
        ILogger<JsonConverter> logger)
    {
        this.logger = logger;

        logger.LogInformation("Registered JsonConverter");
    }


    public string ToString(
        object input)
    {
        logger.LogInformation("Serializing object to string");
        return JsonSerializer.Serialize(input);
    }

    public T? ToObject<T>(
        string input)
    {
        logger.LogInformation("Deserializing string to object");
        return JsonSerializer.Deserialize<T>(input);
    }
}