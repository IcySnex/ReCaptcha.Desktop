using System;

namespace ReCaptcha.Desktop.WinUI.EventArgs;

/// <summary>
/// Event arguments for when a verification was cancelled
/// </summary>
public class VerificationCancelledEventArgs : System.EventArgs
{
    /// <summary>
    /// The date and time when it got cancelled
    /// </summary>
    public DateTime OccurredAt { get; } = DateTime.Now;

    /// <summary>
    /// Creates new VerificationCancelledEventArgs
    /// </summary>
    public VerificationCancelledEventArgs() { }
}