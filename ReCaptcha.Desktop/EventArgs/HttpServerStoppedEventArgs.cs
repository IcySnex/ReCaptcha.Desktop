namespace ReCaptcha.Desktop.EventArgs;

/// <summary>
/// Event arguments for when a HttpServer stopped
/// </summary>
public class HttpServerStoppedEventArgs : System.EventArgs
{
    /// <summary>
    /// The url the server lived on
    /// </summary>
    public string Url { get; }

    /// <summary>
    /// The port the server lived on
    /// </summary>
    public int Port { get; }

    /// <summary>
    /// The date and time when it got stopped
    /// </summary>
    public DateTime OccurredAt { get; } = DateTime.Now;

    /// <summary>
    /// Creates new HttpServerStoppedEventArgs
    /// </summary>
    public HttpServerStoppedEventArgs(
        string url,
        int port)
    {
        Url = url;
        Port = port;
    }
}