namespace ReCaptcha.Desktop.EventArgs;

/// <summary>
/// Event arguments for when a verification successfully recieved
/// </summary>
public class VerificationRecievedEventArgs : System.EventArgs
{
    /// <summary>
    /// The recieved token
    /// </summary>
    public string Token { get; }

    /// <summary>
    /// The date and time when it got recieved
    /// </summary>
    public DateTime OccurredAt { get; } = DateTime.Now;

    /// <summary>
    /// Creates new VerificationRecievedEventArgs
    /// </summary>
    public VerificationRecievedEventArgs(
        string token)
    {
        Token = token;
    }
}