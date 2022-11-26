namespace ReCaptcha.Desktop.EventArgs;

/// <summary>
/// Event arguments for when a HttpServer started
/// </summary>
public class HttpServerStartedEventArgs : System.EventArgs
{
    /// <summary>
    /// The url the server lives on
    /// </summary>
    public string Url { get; }

    /// <summary>
    /// The port the server lives on
    /// </summary>
    public int Port { get; }

    /// <summary>
    /// The array of all prefixes through which the server can be accessed
    /// </summary>
    public string[] Prefixes { get; }

    /// <summary>
    /// The date and time when it got started
    /// </summary>
    public DateTime OccurredAt { get; } = DateTime.Now;

    /// <summary>
    /// Creates new HttpServerStartedEventArgs
    /// </summary>
    public HttpServerStartedEventArgs(
        string url,
        int port,
        string[] prefixes)
    {
        Url = url;
        Port = port;
        Prefixes = prefixes;
    }
}