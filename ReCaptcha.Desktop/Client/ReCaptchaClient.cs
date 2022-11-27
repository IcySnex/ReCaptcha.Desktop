﻿using ReCaptcha.Desktop.Client.Interfaces;
using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.EventArgs;
using ReCaptcha.Desktop.HTTP.Interfaces;

namespace ReCaptcha.Desktop.Client;

/// <summary>
/// Client which handles all ReCaptcha verifications
/// </summary>
public class ReCaptchaClient : IReCaptchaClient
{
    /// <summary>
    /// The default reCaptcha HTML page
    /// </summary>
    public static readonly string ReCaptchaHtml =
        "<script src='https://www.google.com/recaptcha/api.js?hl={0}' async defer></script> <script> window.onload = async function() {{ grecaptcha.execute(); let rendered = false; while (!rendered) {{ rendered = document.body.childElementCount > 1; await (new Promise(resolve => setTimeout(resolve, 100))); }}; document.body.childNodes[1].style = null; new MutationObserver(() => grecaptcha.execute()).observe(document.body.childNodes[1], {{ attributes: true, attributeFilter: ['style'] }}); }}; function onTokenRecieved(token) {{ try {{ const reciever = chrome.webview.hostObjects.reciever; reciever.SendToken(token); document.write('{1}'); }} catch {{ document.write('{2}'.replace('%token%', token)); }}; }}; </script> <style> body {{ overflow: hidden; }} .grecaptcha-badge {{ display: none; }} </style> <div class='g-recaptcha' on data-sitekey='{3}' data-callback='onTokenRecieved' data-size='invisible'></div>";


    readonly IHttpServer httpServer;

    /// <summary>
    /// Creates a new ReCaptchaClient
    /// </summary>
    /// <param name="configuration">The configuration the ReCaptchaClient should be created with</param>
    public ReCaptchaClient(
        ReCaptchaConfig configuration)
    {
        httpServer = IHttpServer.New(
            configuration.HttpConfiguration,
            string.Format(ReCaptchaHtml,
                configuration.Language,
                configuration.TokenRecievedHookedHtml.Replace("\n", "<br/>"),
                configuration.TokenRecievedHtml.Replace("\n", "<br/>"),
                configuration.SiteKey));
    }


    /// <summary>
    /// Fires when verifcation was recieved
    /// </summary>
    public event EventHandler<VerificationRecievedEventArgs>? VerificationRecieved;


    /// <summary>
    /// Starts and stops the HTTP server and calls a verify callback with the url
    /// </summary>
    /// <param name="verifyCallback">The callback which is used to verify</param>
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns>A Google reCAPTCHA token</returns>
    public string Verify(
        Func<string, CancellationToken, string> verifyCallback,
        CancellationToken cancellationToken = default!)
    {
        // Start HTTP server
        string hostUrl = httpServer.Start()[0];

        // Verify reCAPTCHA
        string token = verifyCallback.Invoke(hostUrl, cancellationToken);

        // Stop Server
        httpServer.Stop();

        // Invoke event and return token
        VerificationRecieved?.Invoke(this, new(token));
        return token;
    }


    /// <summary>
    /// Starts and stops the HTTP server and asynchronously calls verify callback with the url
    /// </summary>
    /// <param name="verifyCallback">The callback which is used to verify</param>
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns>A Google reCAPTCHA token</returns>
    public async Task<string> VerifyAsync(
        Func<string, CancellationToken, Task<string>> verifyCallback,
        CancellationToken cancellationToken = default!)
    {
        // Start HTTP server
        string hostUrl = httpServer.Start()[0];

        // Verify reCAPTCHA
        string token = await verifyCallback.Invoke(hostUrl, cancellationToken);

        // Stop Server
        httpServer.Stop();

        // Invoke event and return token
        VerificationRecieved?.Invoke(this, new(token));
        return token;
    }
}