using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.EventArgs;

namespace ReCaptcha.Desktop.Client.Interfaces;

public interface IReCaptchaClient
{
    /// <summary>
    /// Fires when verifcation was recieved
    /// </summary>
    event EventHandler<VerificationRecievedEventArgs>? VerificationRecieved;

    /// <summary>
    /// Fires when verifcation was cancelled
    /// </summary>
    event EventHandler<VerificationCancelledEventArgs>? VerificationCancelled;


    /// <summary>
    /// Starts and stops the HTTP server and calls a verify callback with the url
    /// </summary>
    /// <param name="verifyCallback">The callback which is used to verify</param>
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns></returns>
    public string Verify(
        Func<string, CancellationToken, string> verifyCallback,
        CancellationToken cancellationToken = default!);


    /// <summary>
    /// Creates a new ReCaptchaClient
    /// </summary>
    /// <param name="configuration">The configuration the ReCaptchaClient should be created with</param>
    public static ReCaptchaClient New(
        ReCaptchaConfig configuration) =>
        new ReCaptchaClient(configuration);
}