using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.EventArgs;

namespace ReCaptcha.Desktop.Client.Interfaces;

/// <summary>
/// Client which handles all ReCaptcha verifications
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
    /// Creates a new ReCaptchaClient
    /// </summary>
    /// <param name="configuration">The configuration the ReCaptchaClient should be created with</param>
    public static ReCaptchaClient New(
        ReCaptchaConfig configuration) =>
        new ReCaptchaClient(configuration);

    /// <summary>
    /// Creates a new ReCaptchaClient with extended resize functions
    /// </summary>
    /// <param name="configuration">The configuration the ReCaptchaClient should be created with</param>
    public static Resizeable.ReCaptchaClient NewResizeable(
        ReCaptchaConfig configuration) =>
        new Resizeable.ReCaptchaClient(configuration);
}