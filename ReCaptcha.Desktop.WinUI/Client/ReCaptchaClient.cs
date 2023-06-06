using ReCaptcha.Desktop.Configuration;
using System.Threading;
using System;
using ReCaptcha.Desktop.Client.Interfaces;
using ReCaptcha.Desktop.EventArgs;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using ReCaptcha.Desktop.WinUI.Internal;
using Windows.Graphics;
using ReCaptcha.Desktop.Client.Base;

namespace ReCaptcha.Desktop.Client.WinUI;

/// <summary>
/// Client which handles all ReCaptcha verifications
/// </summary>
public class ReCaptchaClient : IReCaptchaClient
{
    readonly IReCaptchaBase reCaptcha = default!;
    readonly ReCaptchaReciever reciever = new();

    readonly ILogger<IReCaptchaClient>? logger;

    /// <summary>
    /// Creates a new ReCaptchaClient
    /// </summary>
    /// <param name="configuration">The configuration the ReCaptchaClient should be created with</param>
    /// <param name="windowConfiguration">The configuration the reCAPTCHA window will be created with</param>
    public ReCaptchaClient(
        ReCaptchaConfig configuration,
        WindowConfig windowConfiguration)
    {
        reCaptcha = new ReCaptchaResizeableBase(configuration);

        Configuration = configuration;
        WindowConfiguration = windowConfiguration;
    }

    /// <summary>
    /// Creates a new ReCaptchaClient with extendended logging functions
    /// </summary>
    /// <param name="configuration">The configuration the ReCaptchaClient should be created with</param>
    /// <param name="windowConfiguration">The configuration the reCAPTCHA window will be created with</param>
    /// <param name="logger">A logger from Dependency Injection with MVVM</param>
    public ReCaptchaClient(
        ReCaptchaConfig configuration,
        WindowConfig windowConfiguration,
        ILogger<IReCaptchaClient> logger)
    {
        reCaptcha = new ReCaptchaResizeableBase(configuration);

        Configuration = configuration;
        WindowConfiguration = windowConfiguration;

        this.logger = logger;

        logger.LogInformation("[ReCaptchaClient-.ctor] Initialized ReCaptchaClient");
    }


    /// <summary>
    /// The configuration used for this client
    /// </summary>
    public ReCaptchaConfig Configuration
    {
        get => reCaptcha.Configuration;
        set => reCaptcha.Configuration = value;
    }

    /// <summary>
    /// The window configuration used for this client
    /// </summary>
    public WindowConfig WindowConfiguration { get; set; }


    Window window = default!;
    WebView2 webView = default!;
    WindowHelper windowHelper = default!;

    bool hasResized = false;

    void CreateWindowAndWebView()
    {
        webView = new();
        window = new()
        {
            Title = WindowConfiguration.Title,
            Content = webView
        };
        windowHelper = new(window, logger);
        hasResized = false;

        windowHelper.SetSize(0, 0);
        windowHelper.SetPosition(-100, -100);
        windowHelper.SetIcon(WindowConfiguration.Icon);

        logger?.LogInformation("[ReCaptchaClient-CreateWindowAndWebView] Created reCAPTCHA window with webView");
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
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns>A Google reCAPTCHA token</returns>
    public async Task<string> VerifyAsync(
        CancellationToken cancellationToken = default!)
    {
        // Define result
        string? token = null;

        // Create cancellation token based on timeout
        CancellationTokenSource cancelSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cancelSource.Token.Register(() =>
        {
            // If cancelled and token is still not set close window
            if (token is null && window is not null)
                window.DispatcherQueue.TryEnqueue(() => window?.Close());

            logger?.LogInformation("[ReCaptchaClient-OnTokenCancelled] reCAPTCHA vericitaion timed out");
        });


        // Create UI
        CreateWindowAndWebView();

        window.Closed += OnWindowClosed;
        void OnWindowClosed(object _, object _1)
        {
            // Immediately close and cancel if user closed window
            if (token is null)
            {
                webView.Close();
                cancelSource.Cancel();
            }

            // Remove all used handlers
            window.Closed -= OnWindowClosed;
            ReCaptchaResized -= OnReCaptchaResized;

            // Dispose all objects and clear UI
            cancelSource.Dispose();
            window = default!;
            webView = default!;

            // If SetWindowLongPtr was set before, owner window will be minimized at closing => Manually activate it
            WindowConfiguration.Owner?.Activate();

            logger?.LogInformation("[ReCaptchaClient-OnWindowClosing] reCAPTCHA window is closing and objects were disposed");
        }

        ReCaptchaResized += OnReCaptchaResized;
        void OnReCaptchaResized(object? _, ReCaptchaResizedEventArgs e)
        {
            // Skip intial startup
            if (e.Height < 200)
                return;

            // Set window position based on configuration and size
            (PointInt32? ownerPosition, SizeInt32? ownerSize) = WindowConfiguration.StartupLocation == WindowStartupLocation.CenterOwner ? WindowHelper.GetOwnerWindow(WindowConfiguration.Owner) : (null, null);
            double left = hasResized ? windowHelper.Position.X + (webView.Width / 2) - (e.Width / 2) : WindowConfiguration.StartupLocation switch
            {
                WindowStartupLocation.CenterScreen => (windowHelper.ScreenSize.Width - e.Width) / 2,
                WindowStartupLocation.CenterOwner => ownerPosition?.X + (ownerSize?.Width / 2) - (e.Width / 2),
                _ => WindowConfiguration.Left
            } ?? WindowConfiguration.Left;
            left = left < 0 ? 0 : left > windowHelper.ScreenSize.Width - e.Width ? windowHelper.ScreenSize.Width - e.Width : left;
            double top = hasResized ? windowHelper.Position.Y + (webView.Height / 2) - (e.Height / 2) : WindowConfiguration.StartupLocation switch
            {
                WindowStartupLocation.CenterScreen => (windowHelper.ScreenSize.Height - e.Height) / 2,
                WindowStartupLocation.CenterOwner => ownerPosition?.Y + (ownerSize?.Height / 2) - (e.Height / 2),
                _ => WindowConfiguration.Top
            } ?? WindowConfiguration.Top;
            top = top < 0 ? 0 : top > windowHelper.ScreenSize.Height - e.Height ? windowHelper.ScreenSize.Height - e.Height - 30 : top;
            windowHelper.SetPosition((int)left, (int)top);

            // Set size
            webView.Width = e.Width;
            webView.Height = e.Height;

            windowHelper.SetSize(e.Width, e.Height);
            hasResized = true;

            logger?.LogInformation("[ReCaptchaClient-OnReCaptchaResized] reCAPTCHA widget was resized");
        }


        // Launch window
        window.Activate();
        // Set owner window and set reCAPTCHA window as modal
        if (WindowConfiguration.ShowAsDialog && WindowConfiguration.Owner is not null)
        {
            WindowHelper.SetWindowLongPtr(windowHelper.HWnd, -8, WindowHelper.GetHWnd(WindowConfiguration.Owner));
            windowHelper.IsModal = WindowConfiguration.ShowAsDialog;
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

        token = await reCaptcha.VerifyAsync(WaitForVerificationAsync, cancelSource.Token);
        logger?.LogInformation("[ReCaptchaClient-VerifyAsync] reCAPTCHA was successfully verified");

        // Close window and return
        webView.Close();
        window.Close();
        return token;
    }
}