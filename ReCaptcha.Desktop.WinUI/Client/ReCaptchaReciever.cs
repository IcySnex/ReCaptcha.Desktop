using Microsoft.Web.WebView2.Core;
using ReCaptcha.Desktop.EventArgs;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ReCaptcha.Desktop.Client.WinUI;

/// <summary>
/// Reciever to communicate with the HTTP server with extended resize functions
/// </summary>
public class ReCaptchaReciever
{
    /// <summary>
    /// Creates a new ReCaptchaReciever
    /// </summary>
    public ReCaptchaReciever() { }


    CoreWebView2 currentWebView = default!;

    /// <summary>
    /// Set the targeted CoreWebView for the ReCaptchaReciever
    /// </summary>
    /// <param name="coreWebView"></param>
    public void SetWebView(
        CoreWebView2 coreWebView)
    {
        if (coreWebView is null)
            return;

        // Handler
        void WebMessageRecieved(object? _, CoreWebView2WebMessageReceivedEventArgs e)
        {
            // If message contains token and is deserializable set result and invoke event
            if (e.WebMessageAsJson.Contains("token") && JsonSerializer.Deserialize<VerificationRecievedEventArgs>(e.WebMessageAsJson) is VerificationRecievedEventArgs recToken)
            {
                taskWaiter.SetResult(recToken.Token);
                VerificationRecieved?.Invoke(this, recToken);
            }
            // message must contain width/height and if deserializable invoke event
            else if (JsonSerializer.Deserialize<ReCaptchaResizedEventArgs>(e.WebMessageAsJson) is ReCaptchaResizedEventArgs recResized)
            {
                ReCaptchaResized?.Invoke(this, recResized);
            }
        };

        // if old webView is not null then remove handler
        if (currentWebView is not null)
            currentWebView.WebMessageReceived -= WebMessageRecieved;

        // Set new webView and add handler
        currentWebView = coreWebView;
        currentWebView.WebMessageReceived += WebMessageRecieved;
    }


    /// <summary>
    /// Fires when verifcation was recieved from the HTTP server
    /// </summary>
    public event EventHandler<VerificationRecievedEventArgs>? VerificationRecieved;

    /// <summary>
    /// Fires when verifcation was cancelled from the HTTP server
    /// </summary>
    public event EventHandler<VerificationCancelledEventArgs>? VerificationCancelled;

    /// <summary>
    /// Fires when Google reCAPTCHA widget gets resized
    /// </summary>
    public event EventHandler<ReCaptchaResizedEventArgs>? ReCaptchaResized;


    private TaskCompletionSource<string> taskWaiter = default!;

    /// <summary>
    /// Asynchronously waits until a token was sent by the HTTP server
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<string> WaitAsyc(
        CancellationToken cancellationToken)
    {
        taskWaiter = new();

        cancellationToken.Register(() =>
        {
            taskWaiter.TrySetCanceled();
            VerificationCancelled?.Invoke(this, new());
        }, false);

        return taskWaiter.Task;
    }
}