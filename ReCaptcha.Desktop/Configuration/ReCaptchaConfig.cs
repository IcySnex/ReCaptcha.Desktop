namespace ReCaptcha.Desktop.Configuration;

/// <summary>
/// Configuration for a ReCaptcha client
/// </summary>
public class ReCaptchaConfig
{
    /// <summary>
    /// Creates a new ReCaptchaConfig
    /// </summary>
    /// <param name="siteKey">The SiteKey for the Google reCAPTCHA service</param>
    /// <param name="language">The language for the Google reCAPTCHA service</param>
    /// <param name="tokenRecievedHtml">The HTML which gets displayed after the user verifed the reCAPTCHA. Use %token% to embed the token inside the message</param>
    /// <param name="tokenRecievedHookedHtml">The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application. Use %token% to embed the token inside the message</param>
    /// <param name="httpConfiguration">The configuration for the HttpServer</param>
    public ReCaptchaConfig(
        string siteKey,
        string language = "en",
        string tokenRecievedHtml = "Token recieved: %token%",
        string tokenRecievedHookedHtml = "Token recieved and sent to application.",
        HttpServerConfig? httpConfiguration = null)
    {
        SiteKey = siteKey;
        Language = language;
        TokenRecievedHtml = tokenRecievedHtml;
        TokenRecievedHookedHtml = tokenRecievedHookedHtml;
        HttpConfiguration = httpConfiguration is null ? new() : httpConfiguration;
    }


    /// <summary>
    /// The SiteKey for the Google reCAPTCHA service
    /// </summary>
    public string SiteKey { get; set; }

    /// <summary>
    /// The language for the Google reCAPTCHA service
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// The HTML which gets displayed after the user verifed the reCAPTCHA
    /// Use %token% to embed the token inside the message
    /// </summary>
    public string TokenRecievedHtml { get; set; }

    /// <summary>
    /// The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application.
    /// Use %token% to embed the token inside the message
    /// </summary>
    public string TokenRecievedHookedHtml { get; set; }

    /// <summary>
    /// The configuration for the HttpServer
    /// </summary>
    public HttpServerConfig HttpConfiguration { get; set; }
}