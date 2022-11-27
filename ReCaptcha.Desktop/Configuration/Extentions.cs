using ReCaptcha.Desktop.HTTP;

namespace ReCaptcha.Desktop.Configuration;

public static class Extentions
{
    /// <summary>
    /// Creates a new HttpServerConfig
    /// </summary>
    /// <param name="url">The url the server lives on</param>
    /// <param name="port">The port the server lives on</param>
    /// <returns>A new HttpServerConfig</returns>
    public static HttpServerConfig AsHttpServerConfig(
        this string url,
        int port = 5000) =>
        new(url, port);

    /// <summary>
    /// Checks wether a connection is open on the given HttpServerConfig
    /// </summary>
    /// <param name="configuration">The HttpServer configuration to check</param>
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns>A bool wether its true</returns>
    public static Task<bool> IsOpenAsync(
        this HttpServerConfig configuration,
        CancellationToken cancellationToken = default!) =>
        HttpServer.IsOpenAsync(configuration, cancellationToken);


    /// <summary>
    /// Creates a new ReCaptchaConfig
    /// </summary>
    /// <param name="siteKey">The SiteKey for the Google reCAPTCHA service</param>
    /// <param name="language">The language for the Google reCAPTCHA service</param>
    /// <param name="tokenRecievedHtml">The HTML which gets displayed after the user verifed the reCAPTCHA. Use %token% to embed the token inside the message</param>
    /// <param name="tokenRecievedHookedHtml">The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application. Use %token% to embed the token inside the message</param>
    /// <param name="httpConfiguration">The configuration for the HttpServer</param>
    /// <returns>A new ReCaptchaConfig</returns>
    public static ReCaptchaConfig AsReCaptchaConfig(
        this string siteKey,
        string language = "en",
        string tokenRecievedHtml = "Token recieved: %token%",
        string tokenRecievedHookedHtml = "Token recieved and sent to application.",
        HttpServerConfig? httpConfiguration = null) =>
        new(siteKey, language, tokenRecievedHtml, tokenRecievedHookedHtml, httpConfiguration);
}