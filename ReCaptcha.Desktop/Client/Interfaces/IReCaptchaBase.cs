using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.EventArgs;

namespace ReCaptcha.Desktop.Client.Interfaces;

/// <summary>
/// Base client which manages a ReCaptcha HTTP server
/// </summary>
public interface IReCaptchaBase
{
    /// <summary>
    /// The configuration used for this base client
    /// </summary>
    ReCaptchaConfig Configuration { get; set; }


    /// <summary>
    /// Fires when verifcation was recieved
    /// </summary>
    event EventHandler<VerificationRecievedEventArgs>? VerificationRecieved;


    /// <summary>
    /// Starts and stops the HTTP server and calls a verify callback with the url
    /// </summary>
    /// <param name="verifyCallback">The callback which is used to verify</param>
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns>A Google reCAPTCHA token</returns>
    string Verify(
        Func<string, CancellationToken, string> verifyCallback,
        CancellationToken cancellationToken = default!);

    /// <summary>
    /// Starts and stops the HTTP server and asynchronously calls verify callback with the url
    /// </summary>
    /// <param name="verifyCallback">The callback which is used to verify</param>
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns>A Google reCAPTCHA token</returns>
    Task<string> VerifyAsync(
        Func<string, CancellationToken, Task<string>> verifyCallback,
        CancellationToken cancellationToken = default!);
}