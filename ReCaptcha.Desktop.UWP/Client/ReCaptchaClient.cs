#nullable enable

using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.Client.Interfaces;
using Microsoft.Extensions.Logging;
using ReCaptcha.Desktop.EventArgs;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.UI.Xaml.Controls;
using ReCaptcha.Desktop.UWP.Internal;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Core;

namespace ReCaptcha.Desktop.Client.UWP;

/// <summary>
/// Client which handles all ReCaptcha verifications
/// </summary>
public class ReCaptchaClient : IReCaptchaClient
{
    Resizeable.ReCaptchaClient baseClient = default!;
    readonly ReCaptchaReciever reciever = new();

    readonly ILogger<ReCaptchaClient>? logger;

    /// <summary>
    /// Creates a new ReCaptchaClient
    /// </summary>
    /// <param name="configuration">The configuration the ReCaptchaClient should be created with</param>
    /// <param name="popupConfiguration">The configuration the reCAPTCHA popup will be created with</param>
    public ReCaptchaClient(
        ReCaptchaConfig configuration,
        PopupConfig popupConfiguration)
    {
        Configuration = configuration;
        PopupConfiguration = popupConfiguration;
    }

    /// <summary>
    /// Creates a new ReCaptchaClient with extendended logging functions
    /// </summary>
    /// <param name="configuration">The configuration the ReCaptchaClient should be created with</param>
    /// <param name="popupConfiguration">The configuration the reCAPTCHA popup will be created with</param>
    /// <param name="logger">A logger from Dependency Injection with MVVM</param>
    public ReCaptchaClient(
        ReCaptchaConfig configuration,
        PopupConfig popupConfiguration,
        ILogger<ReCaptchaClient> logger)
    {
        baseClient = new(configuration);

        Configuration = configuration;
        PopupConfiguration = popupConfiguration;

        this.logger = logger;

        logger.LogInformation("[ReCaptchaClient-.ctor] Initialized ReCaptchaClient");
    }


    ReCaptchaConfig configuration = default!;
    /// <summary>
    /// The configuration used for this client
    /// </summary>
    public ReCaptchaConfig Configuration
    {
        get => configuration;
        set
        {
            baseClient = new(value);
            logger?.LogInformation("[ReCaptchaClient-Configuration.Set] Created new resizeable BaseClient");

            configuration = value;
        }
    }

    /// <summary>
    /// The popup configuration used for this client
    /// </summary>
    public PopupConfig PopupConfiguration { get; set; }


    Popup popup = default!;
    ReCaptchaPopup popupContent = default!;
    WebView2 webView = default!;

    void CreatePopupAndWebView()
    {
        webView = new();
        popupContent = new(webView, PopupConfiguration);
        popup = new()
        {
            ChildTransitions = { new PopupThemeTransition() { FromVerticalOffset = 128 } },
            Child = popupContent
        };

        logger?.LogInformation("[ReCaptchaClient-CreatePopupAndWebView] Created reCAPTCHA popup with webView");
    }


    /// <summary>
    /// Fires when verifcation was recieved
    /// </summary>
    public event EventHandler<VerificationRecievedEventArgs>? VerificationRecieved
    {
        add => reciever.VerificationRecieved += value;
        remove => reciever.VerificationRecieved -= value;
    }

    /// <summary>
    /// Fires when verifcation was cancelled
    /// </summary>
    public event EventHandler<VerificationCancelledEventArgs>? VerificationCancelled
    {
        add => reciever.VerificationCancelled += value;
        remove => reciever.VerificationCancelled -= value;
    }

    /// <summary>
    /// Fires when verifcation was cancelled
    /// </summary>
    public event EventHandler<ReCaptchaResizedEventArgs>? ReCaptchaResized
    {
        add => reciever.ReCaptchaResized += value;
        remove => reciever.ReCaptchaResized -= value;
    }

    /// <summary>
    /// Starts and stops the HTTP server and opens a new window for the user to verify
    /// </summary>
    /// <param name="timeout">The timespan when this action times out</param>
    /// <returns>A Google reCAPTCHA token</returns>
    public async Task<string> VerifyAsync(
        CancellationToken cancellationToken = default!)
    {
        // Define result
        string? token = null;

        // Create cancellation token based on timeout
        CancellationTokenSource cancelSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cancelSource.Token.Register(async () =>
        {
            // If cancelled and token is still not set close window
            if (token is null && popup is not null)
                await popup.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (popup is not null)
                        popup.IsOpen = false;
                });

            logger?.LogInformation("[ReCaptchaClient-OnTokenCancelled] reCAPTCHA vericitaion timed out");
        });


        // Create UI
        CreatePopupAndWebView();

        popup.Closed += OnPopupClosed;
        void OnPopupClosed(object _, object _1)
        {
            // Immediately close and cancel if user closed window
            if (token is null)
            {
                webView.Close();
                cancelSource.Cancel();
            }

            // Remove all used handlers
            popup.Closed -= OnPopupClosed;
            ReCaptchaResized -= OnReCaptchaResized;

            // Dispose all objects and clear UI
            cancelSource.Dispose();
            webView.Close();
            popup = default!;
            popupContent = default!;
            webView = default!;

            logger?.LogInformation("[ReCaptchaClient-OnPopupClosed] reCAPTCHA popup was closed and objects were disposed");
        }

        ReCaptchaResized += OnReCaptchaResized;
        void OnReCaptchaResized(object? _, ReCaptchaResizedEventArgs e)
        {
            // Skip intial startup
            if (e.Height < 200)
                return;

            // Show popup
            popup.IsOpen = true;

            // Set size
            webView.Width = e.Width;
            webView.Height = e.Height;

            popupContent.Resize(e.Width, e.Height);

            logger?.LogInformation("[ReCaptchaClient-OnReCaptchaResized] reCAPTCHA widget was resized");
        }


        // Setup WebView
        await webView.EnsureCoreWebView2Async().AsTask(cancellationToken);
        reciever.SetWebView(webView.CoreWebView2);

        webView.CoreWebView2.Settings.AreDevToolsEnabled = false;
        webView.CoreWebView2.Settings.IsZoomControlEnabled = false;


        // Verify reCAPTCHA
        Task<string> WaitForVerificationAsync(string url, CancellationToken cancellationToken)
        {
            logger?.LogInformation("[ReCaptchaClient-WaitForVerificationAsync] reCAPTCHA verification was requested");

            // Set page to hosted reCAPTCHA
            webView.Source = new(url);
            // Wait until verified
            return reciever.WaitAsyc(cancellationToken);
        }

        token = await baseClient.VerifyAsync(WaitForVerificationAsync, cancelSource.Token);
        logger?.LogInformation("[ReCaptchaClient-VerifyAsync] reCAPTCHA was successfully verified");

        // Close popup and return
        webView.Close();
        popup.IsOpen = false;
        return token;
    }
}