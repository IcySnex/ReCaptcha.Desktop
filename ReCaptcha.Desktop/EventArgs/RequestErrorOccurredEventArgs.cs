namespace ReCaptcha.Desktop.EventArgs;

/// <summary>
/// Event arguments for when an exception was thrown inside an asynchronous response thread
/// </summary>
public class RequestErrorOccurredEventArgs : System.EventArgs
{
    /// <summary>
    /// The exceptions that got thrown
    /// </summary>
    public Exception Exception { get; }

    /// <summary>
    /// The date and time when it got thrown
    /// </summary>
    public DateTime OccurredAt { get; } = DateTime.Now;

    /// <summary>
    /// Creates new RequestErrorOccurredEventArgs
    /// </summary>
    public RequestErrorOccurredEventArgs(
        Exception exception)
    {
        Exception = exception;
    }
}