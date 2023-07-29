﻿using ReCaptcha.Desktop.WinUI.Configuration;
using System;
using System.Threading.Tasks;
using System.Threading;
using ReCaptcha.Desktop.WinUI.EventArgs;

namespace ReCaptcha.Desktop.WinUI.Client.Interfaces;

public interface IReCaptchaClient
{
    /// <summary>
    /// The configuration used for this client
    /// </summary>
    public ReCaptchaConfig Configuration { get; set; }

    /// <summary>
    /// The window configuration used for this client
    /// </summary>
    public WindowConfig WindowConfiguration { get; set; }


    /// <summary>
    /// Fires when verifcation was recieved
    /// </summary>
    public event EventHandler<VerificationRecievedEventArgs>? VerificationRecieved;

    /// <summary>
    /// Fires when verifcation was cancelled
    /// </summary>
    public event EventHandler<VerificationCancelledEventArgs>? VerificationCancelled;

    /// <summary>
    /// Fires when Google reCAPTCHA widget gets resized
    /// </summary>
    public event EventHandler<ReCaptchaResizedEventArgs>? ReCaptchaResized;


    /// <summary>
    /// Sets up the reCAPTCHA site and opens a new window for the user to verify
    /// </summary>
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns>A Google reCAPTCHA token</returns>
    public Task<string> VerifyAsync(
        CancellationToken cancellationToken = default!);
}