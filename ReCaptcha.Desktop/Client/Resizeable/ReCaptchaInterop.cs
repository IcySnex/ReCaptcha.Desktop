using ReCaptcha.Desktop.Client.Interfaces;
using ReCaptcha.Desktop.EventArgs;

namespace ReCaptcha.Desktop.Client.Resizeable;

/// <summary>
/// COM Interop handler for communication with the HTTP server with extended resize functions
/// </summary>
public class ReCaptchaInterop : IReCaptchaInterop
{
    /// <summary>
    /// Creates a new ReCaptchaInterop
    /// </summary>
    public ReCaptchaInterop() { }


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


    private TaskCompletionSource<string> taskWaiter = new();

    /// <summary>
    /// Asynchronously waits until a token was sent by the HTTP server
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<string> WaitAsyc(
        CancellationToken cancellationToken)
    {
        cancellationToken.Register(() =>
        {
            taskWaiter.TrySetCanceled();
            VerificationCancelled?.Invoke(this, new());
        }, false);

        return taskWaiter.Task;
    }


    /// <summary>
    /// Sends a reCAPTCHA token to the ReCaptchaInterop handler
    /// (Should only be used by the HTTP server with javascript/HostedObject)
    /// </summary>
    /// <param name="token">The recieved token to send</param>
    public void SendToken(
        string token)
    {
        taskWaiter.SetResult(token);
        VerificationRecieved?.Invoke(this, new(token));
    }

    /// <summary>
    /// Sends a resized event to the ReCaptchaInterop handler
    /// (Should only be used by the HTTP server with javascript/HostedObject)
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    public void Resize(
        int width,
        int height) =>
        ReCaptchaResized?.Invoke(this, new(width, height));
}