using System.Net;

namespace ReCaptcha.Desktop.EventArgs;

/// <summary>
/// Event arguments for when an request occurred in an asynchronous response thread
/// </summary>
public class RequestOccurredEventArgs : System.EventArgs
{
    /// <summary>
    /// The HttpListener context
    /// </summary>
    public HttpListenerContext Context { get; }

    /// <summary>
    /// The reponse which got sent to the request
    /// </summary>
    public byte[] Response { get; }
    
    /// <summary>
    /// The date and time when it got requested
    /// </summary>
    public DateTime OccurredAt { get; } = DateTime.Now;

    /// <summary>
    /// Creates new RequestOccurredEventArgs
    /// </summary>
    public RequestOccurredEventArgs(
        HttpListenerContext context,
        byte[] response)
    {
        Context = context;
        Response = response;
    }
}