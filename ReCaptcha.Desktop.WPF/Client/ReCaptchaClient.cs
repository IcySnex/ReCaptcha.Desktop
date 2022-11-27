using ReCaptcha.Desktop.Configuration;
using System.Threading;
using System;
using ReCaptcha.Desktop.Client.Interfaces;
using ReCaptcha.Desktop.EventArgs;
using System.Windows;
using Microsoft.Web.WebView2.Wpf;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ReCaptcha.Desktop.Client.WPF;

public class ReCaptchaClient : IReCaptchaClient
{
    readonly Resizeable.ReCaptchaClient baseClient;
    readonly Resizeable.ReCaptchaInterop reCaptchaInterop = new();

    readonly WindowConfig windowConfiguration;
    readonly ILogger<ReCaptchaClient>? logger;

    /// <summary>
    /// Creates a new ReCaptchaClient
    /// </summary>
    /// <param name="configuration">The configuration the ReCaptchaClient should be created with</param>
    /// <param name="windowConfiguration">The configuration the reCAPTCHA window will be created with</param>
    public ReCaptchaClient(
        ReCaptchaConfig configuration,
        WindowConfig windowConfiguration)
    {
        baseClient = IReCaptchaClient.NewResizeable(configuration);

        this.windowConfiguration = windowConfiguration;
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
        ILogger<ReCaptchaClient> logger)
    {
        baseClient = IReCaptchaClient.NewResizeable(configuration);

        this.windowConfiguration = windowConfiguration;
        this.logger = logger;

        logger.LogInformation("[ReCaptchaClient-.ctor] Initialized ReCaptchaClient");
    }


    Window window = default!;
    WebView2 webView = default!;

    bool hasResized = false;

    void CreateWindowAndWebView()
    {
        webView = new();
        window = new()
        {
            Title = windowConfiguration.Title,
            Icon = windowConfiguration.Icon,
            Owner = windowConfiguration.Owner,
            Left = 0,
            Top = 0,
            ResizeMode = ResizeMode.NoResize,
            WindowState = WindowState.Minimized,
            SizeToContent = SizeToContent.WidthAndHeight,
            Content = webView
        };
        hasResized = false;

        logger?.LogInformation("[ReCaptchaClient-CreateWindowAndWebView] Created reCAPTCHA window with webView");
    }


    /// <summary>
    /// Fires when verifcation was recieved
    /// </summary>
    public event EventHandler<VerificationRecievedEventArgs>? VerificationRecieved
    {
        add => reCaptchaInterop.VerificationRecieved += value;
        remove => reCaptchaInterop.VerificationRecieved -= value;
    }

    /// <summary>
    /// Fires when verifcation was cancelled
    /// </summary>
    public event EventHandler<VerificationCancelledEventArgs>? VerificationCancelled
    {
        add => reCaptchaInterop.VerificationCancelled += value;
        remove => reCaptchaInterop.VerificationCancelled -= value;
    }

    /// <summary>
    /// Fires when verifcation was cancelled
    /// </summary>
    public event EventHandler<ReCaptchaResizedEventArgs>? ReCaptchaResized
    {
        add => reCaptchaInterop.ReCaptchaResized += value;
        remove => reCaptchaInterop.ReCaptchaResized -= value;
    }


    /// <summary>
    /// Starts and stops the HTTP server and opens a new window for the user to verify
    /// </summary>
    /// <param name="timeout">The timespan when this action times out</param>
    /// <returns>A Google reCAPTCHA token</returns>
    public async Task<string> VerifyAsync(
        TimeSpan? timeout = null)
    {
        // Create cancellation token based on timeout
        CancellationTokenSource cancelSource = timeout.HasValue ? new(timeout.Value) : new();

        // Create UI
        CreateWindowAndWebView();

        // Hook handlers
        window.Closed += OnWindowClosed;
        void OnWindowClosed(object? _, object _1)
        {
            window.Closed -= OnWindowClosed;

            cancelSource.Cancel();
            webView.Dispose();
            window = default!;
            webView = default!;

            logger?.LogInformation("[ReCaptchaClient-OnWindowClosed] reCAPTCHA window was closed and objects were disposed");
        }

        VerificationCancelled += OnVerificationCancelled;
        void OnVerificationCancelled(object? _, VerificationCancelledEventArgs e)
        {
            VerificationCancelled -= OnVerificationCancelled;
            ReCaptchaResized -= OnReCaptchaResized;

            window.Dispatcher.BeginInvoke(window.Close);

            logger?.LogInformation("[ReCaptchaClient-OnVerificationCancelled] reCAPTCHA vericitaion was cancelled");
        }

        ReCaptchaResized += OnReCaptchaResized;
        void OnReCaptchaResized(object? _, ReCaptchaResizedEventArgs e)
        {
            if (e.Height < 200)
                return;

            window.WindowState = WindowState.Normal;
            window.ShowInTaskbar = true;

            double left = hasResized ? window.Left + (webView.Width / 2) - (e.Width / 2) : windowConfiguration.StartupLocation switch
            {
                WindowStartupLocation.CenterScreen => (SystemParameters.PrimaryScreenWidth - e.Width) / 2,
                WindowStartupLocation.CenterOwner => windowConfiguration.Owner?.Left + (windowConfiguration.Owner?.Width / 2) - (e.Width / 2),
                _ => windowConfiguration.Left
            } ?? windowConfiguration.Left;
            window.Left = left < 0 ? 0 : left > SystemParameters.PrimaryScreenWidth - e.Width ? SystemParameters.PrimaryScreenWidth - e.Width : left;
            double top = hasResized ? window.Top + (webView.Height / 2) - (e.Height / 2) : windowConfiguration.StartupLocation switch
            {
                WindowStartupLocation.CenterScreen => (SystemParameters.PrimaryScreenHeight - e.Height) / 2,
                WindowStartupLocation.CenterOwner => windowConfiguration.Owner?.Top + (windowConfiguration.Owner?.Height / 2) - (e.Height / 2),
                _ => windowConfiguration.Top
            } ?? windowConfiguration.Top;
            window.Top = top < 0 ? 0 : top > SystemParameters.PrimaryScreenHeight - e.Height ? SystemParameters.PrimaryScreenHeight - e.Height - 30 : top;

            webView.Width = e.Width;
            webView.Height = e.Height;
            hasResized = true;

            logger?.LogInformation("[ReCaptchaClient-OnReCaptchaResized] reCAPTCHA widget was resized");
        }


        // Launch window
        if (windowConfiguration.ShowAsDialog)
            await Task.Run(() => window.Dispatcher.BeginInvoke(window.ShowDialog));
        else
            window.Show();


        // Setup WebView
        await webView.EnsureCoreWebView2Async();
        webView.CoreWebView2.AddHostObjectToScript("reciever", reCaptchaInterop);

        webView.CoreWebView2.Settings.AreDevToolsEnabled = false;
        webView.CoreWebView2.Settings.IsZoomControlEnabled = false;


        // Verify reCAPTCHA
        Task<string> WaitForVerificationAsync(string url, CancellationToken cancellationToken)
        {
            logger?.LogInformation("[ReCaptchaClient-WaitForVerificationAsync] reCAPTCHA verification was requested");


            // Set page to hosted reCAPTCHA
            webView.Source = new(url);

            // Wait until verified
            return reCaptchaInterop.WaitAsyc(cancellationToken);
        }

        string token = await baseClient.VerifyAsync(WaitForVerificationAsync, cancelSource.Token);
        logger?.LogInformation("[ReCaptchaClient-VerifyAsync] reCAPTCHA was successfully verified");

        // Close window and return
        window.Close();
        return token;
    }
}