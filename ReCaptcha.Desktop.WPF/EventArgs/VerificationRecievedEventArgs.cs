using System;
using System.Text.Json.Serialization;

namespace ReCaptcha.Desktop.WPF.EventArgs;

/// <summary>
/// Event arguments for when a verification successfully recieved
/// </summary>
public class VerificationRecievedEventArgs : System.EventArgs
{
    /// <summary>
    /// The recieved token
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; }

    /// <summary>
    /// The date and time when it got recieved
    /// </summary>
    public DateTime OccurredAt { get; } = DateTime.Now;

    /// <summary>
    /// Creates new VerificationRecievedEventArgs
    /// </summary>
    [JsonConstructor]
    public VerificationRecievedEventArgs(
        string token)
    {
        Token = token;
    }
}