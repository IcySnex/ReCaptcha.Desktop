namespace ReCaptcha.Desktop.EventArgs;

/// <summary>
/// Event arguments for when a reCAPTCHA widget was resized
/// </summary>
public class ReCaptchaResizedEventArgs : System.EventArgs
{
    /// <summary>
    /// The new width of the reCAPTCHA widget
    /// </summary>
    public int Width { get; }

    /// <summary>
    /// The new height of the reCAPTCHA widget
    /// </summary>
    public int Height { get; }

    /// <summary>
    /// The date and time when it got resized
    /// </summary>
    public DateTime OccurredAt { get; } = DateTime.Now;

    /// <summary>
    /// Creates new ReCaptchaResizedEventArgs
    /// </summary>
    public ReCaptchaResizedEventArgs(
        int width,
        int height)
    {
        Width = width;
        Height = height;
    }
}