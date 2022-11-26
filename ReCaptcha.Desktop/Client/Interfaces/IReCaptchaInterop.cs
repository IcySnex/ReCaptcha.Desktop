using ReCaptcha.Desktop.EventArgs;

namespace ReCaptcha.Desktop.Client.Interfaces;

/// <summary>
/// COM Interop handler for communication with the HTTP server
/// </summary>
public interface IReCaptchaInterop
{
    /// <summary>
    /// Fires when verifcation was recieved from the HTTP server
    /// </summary>
    event EventHandler<VerificationRecievedEventArgs>? VerificationRecieved;

    /// <summary>
    /// Fires when verifcation was cancelled from the HTTP server
    /// </summary>
    event EventHandler<VerificationCancelledEventArgs>? VerificationCancelled;


    /// <summary>
    /// Asynchronously waits until a token was sent by the HTTP server
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<string> WaitAsyc(
        CancellationToken cancellationToken);


    /// <summary>
    /// Sends a reCAPTCHA token to the ReCaptchaInterop handler
    /// (Should only be used by the HTTP server with javascript/HostedObject)
    /// </summary>
    /// <param name="token"></param>
    void SendToken(
        string token);


    /// <summary>
    /// Creates a new ReCaptchaInterop
    /// </summary>
    public static ReCaptchaInterop New() =>
        new ReCaptchaInterop();
}