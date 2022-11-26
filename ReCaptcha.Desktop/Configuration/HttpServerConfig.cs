namespace ReCaptcha.Desktop.Configuration;

/// <summary>
/// Configuration for a HttpServer
/// </summary>
public class HttpServerConfig
{
    /// <summary>
    /// Creates a new HttpServerConfig
    /// </summary>
    /// <param name="url">The url the server lives on</param>
    /// <param name="port">The port the server lives on</param>
    public HttpServerConfig(
        string url = "http://localhost",
        int port = 5000)
    {
        Url = url;
        Port = port;
    }
    

    /// <summary>
    /// The url the server lives on
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// The port the server lives on
    /// </summary>
    public int Port { get; set; }
}