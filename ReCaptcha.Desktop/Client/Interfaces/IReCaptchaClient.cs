using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.EventArgs;

namespace ReCaptcha.Desktop.Client.Interfaces;

/// <summary>
/// Client which handles all ReCaptcha verification
/// </summary>
public interface IReCaptchaClient
{
    /// <summary>
    /// The configuration used for this client
    /// </summary>
    ReCaptchaConfig Configuration { get; set; }


    /// <summary>
    /// Fires when verifcation was recieved
    /// </summary>
    event EventHandler<VerificationRecievedEventArgs>? VerificationRecieved;

    /// <summary>
    /// Fires when verifcation was cancelled
    /// </summary>
    event EventHandler<VerificationCancelledEventArgs>? VerificationCancelled;

    /// <summary>
    /// Fires when verifcation was cancelled
    /// </summary>
    event EventHandler<ReCaptchaResizedEventArgs>? ReCaptchaResized;


    /// <summary>
    /// Starts and stops the HTTP server and opens a new window for the user to verify
    /// </summary>
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns>A Google reCAPTCHA token</returns>
    Task<string> VerifyAsync(
        CancellationToken cancellationToken = default!);
}