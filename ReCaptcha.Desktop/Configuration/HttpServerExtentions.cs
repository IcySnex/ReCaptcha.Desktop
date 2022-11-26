using ReCaptcha.Desktop.Configuration;

namespace ReCaptcha.Desktop.Configuration;

public static class HttpServerExtentions
{
    /// <summary>
    /// Creates a new HttpServerConfig
    /// </summary>
    /// <param name="url">The url the server lives on</param>
    /// <param name="port">The port the server lives on</param>
    /// <returns>A new HttpServerConfig</returns>
    public static HttpServerConfig AsHttpServerConfig(
        this string url,
        int port = 5000) =>
        new(url, port);
}