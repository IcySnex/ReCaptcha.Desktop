using System.Threading;
using System;
using System.Windows;
using Microsoft.Web.WebView2.Wpf;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Web.WebView2.Core;
using System.IO;
using System.Text;
using ReCaptcha.Desktop.WPF.Client.Interfaces;
using ReCaptcha.Desktop.WPF.Configuration;
using ReCaptcha.Desktop.WPF.EventArgs;

namespace ReCaptcha.Desktop.WPF.Client;

/// <summary>
/// Client which handles all ReCaptcha verifications
/// </summary>
public class ReCaptchaClient : IReCaptchaClient
{
    /// <summary>
    /// The default reCaptcha HTML web content
    /// </summary>
    public static readonly string WebContent =
        "<script src='https://www.google.com/recaptcha/api.js?hl={0}' async defer></script> <script> window.onload = async function() {{ grecaptcha.execute(); let rendered = false; while (!rendered) {{ rendered = document.body.childElementCount > 1; await (new Promise(resolve => setTimeout(resolve, 100))); }}; document.body.childNodes[1].style = null; new MutationObserver(() => grecaptcha.execute()).observe(document.body.childNodes[1], {{ attributes: true, attributeFilter: ['style'] }}); try {{ new ResizeObserver(() => chrome.webview.postMessage({{ 'width': document.body.childNodes[1].childNodes[1].offsetWidth, 'height': document.body.childNodes[1].childNodes[1].offsetHeight}})).observe(document.body.childNodes[1].childNodes[1]); }} catch {{}}; }}; function onTokenRecieved(token) {{ try {{ chrome.webview.postMessage({{ 'token': token }}); document.write('{1}'.replace('%token%', token)); }} catch {{ document.write('{2}'.replace('%token%', token)); }}; }}; </script> <style> body {{ overflow: hidden; }} .grecaptcha-badge {{ display: none; }} </style> <div class='g-recaptcha' on data-sitekey='{3}' data-callback='onTokenRecieved' data-size='invisible'></div>";


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
        Configuration = configuration;
        WindowConfiguration = windowConfiguration;

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
            if (configuration == value)
                return;

            string formattedWebContent = string.Format(
                WebContent,
                value.Language,
                value.TokenRecievedHookedHtml.Replace("\n", "<br/>"),
                value.TokenRecievedHtml.Replace("\n", "<br/>"),
                value.SiteKey);
            webContentResponse = new MemoryStream(Encoding.UTF8.GetBytes(formattedWebContent));

            configuration = value;
        }
    }

    /// <summary>
    /// The window configuration used for this client
    /// </summary>
    public WindowConfig WindowConfiguration { get; set; }


    Stream webContentResponse = default!;

    Window window = default!;
    WebView2 webView = default!;

    bool hasResized = false;

    void CreateWindowAndWebView()
    {
        webView = new();
        window = new()
        {
            Title = WindowConfiguration.Title,
            Icon = WindowConfiguration.Icon,
            Owner = WindowConfiguration.Owner,
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
    /// Fires when Google reCAPTCHA widget gets resized
    /// </summary>
    public event EventHandler<ReCaptchaResizedEventArgs>? ReCaptchaResized
    {
        add => reciever.ReCaptchaResized += value;
        remove => reciever.ReCaptchaResized -= value;
    }


    /// <summary>
    /// Sets up the reCAPTCHA site and opens a new window for the user to verify
    /// </summary>
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns>A Google reCAPTCHA token</returns>
    public async Task<string> VerifyAsync(
        CancellationToken cancellationToken = default!)
    {
        logger?.LogInformation("[ReCaptchaClient-VerifyAsync] reCAPTCHA verification was requested");

        // Define result
        string? token = null;

        // Create cancellation token based on timeout
        CancellationTokenSource cancelSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cancelSource.Token.Register(() =>
        {
            // If cancelled and token is still not set close window
            if (token is null && window is not null)
                window.Dispatcher.BeginInvoke(() => window?.Close());

            logger?.LogInformation("[ReCaptchaClient-OnTokenCancelled] reCAPTCHA vericitaion timed out");
        });


        // Create UI
        CreateWindowAndWebView();

        // Hook handlers
        window.Closed += OnWindowClosed;
        void OnWindowClosed(object? _, object _1)
        {
            // Remove all used handlers
            window.Closed -= OnWindowClosed;
            ReCaptchaResized -= OnReCaptchaResized;

            // If token stil not set cancel
            if (token is null)
                cancelSource.Cancel();

            // Dispose all objects and clear UI
            cancelSource.Dispose();
            webView.Dispose();
            window = default!;
            webView = default!;

            logger?.LogInformation("[ReCaptchaClient-OnWindowClosed] reCAPTCHA window was closed and objects were disposed");
        }

        ReCaptchaResized += OnReCaptchaResized;
        void OnReCaptchaResized(object? _, ReCaptchaResizedEventArgs e)
        {
            // Skip intial startup
            if (e.Height < 200)
                return;

            // Shoe window
            window.WindowState = WindowState.Normal;
            window.ShowInTaskbar = true;

            // Set window position based on configuration and size
            double left = hasResized ? window.Left + webView.Width / 2 - e.Width / 2 : WindowConfiguration.StartupLocation switch
            {
                WindowStartupLocation.CenterScreen => (SystemParameters.PrimaryScreenWidth - e.Width) / 2,
                WindowStartupLocation.CenterOwner => WindowConfiguration.Owner?.Left + WindowConfiguration.Owner?.Width / 2 - e.Width / 2,
                _ => WindowConfiguration.Left
            } ?? WindowConfiguration.Left;
            window.Left = left < 0 ? 0 : left > SystemParameters.PrimaryScreenWidth - e.Width ? SystemParameters.PrimaryScreenWidth - e.Width : left;
            double top = hasResized ? window.Top + webView.Height / 2 - e.Height / 2 : WindowConfiguration.StartupLocation switch
            {
                WindowStartupLocation.CenterScreen => (SystemParameters.PrimaryScreenHeight - e.Height) / 2,
                WindowStartupLocation.CenterOwner => WindowConfiguration.Owner?.Top + WindowConfiguration.Owner?.Height / 2 - e.Height / 2,
                _ => WindowConfiguration.Top
            } ?? WindowConfiguration.Top;
            window.Top = top < 0 ? 0 : top > SystemParameters.PrimaryScreenHeight - e.Height ? SystemParameters.PrimaryScreenHeight - e.Height - 30 : top;

            // Set size
            webView.Width = e.Width;
            webView.Height = e.Height;
            hasResized = true;

            logger?.LogInformation("[ReCaptchaClient-OnReCaptchaResized] reCAPTCHA widget was resized");
        }


        // Launch window
        if (WindowConfiguration.ShowAsDialog && WindowConfiguration.Owner is not null)
            await Task.Run(() => window.Dispatcher.BeginInvoke(window.ShowDialog));
        else
            window.Show();


        // Setup WebView
        logger?.LogInformation("[ReCaptchaClient-VerifyAsync] Setting up WebView2");

        await webView.EnsureCoreWebView2Async();
        reciever.SetWebView(webView.CoreWebView2);

        webView.CoreWebView2.Settings.AreDevToolsEnabled = false;
        webView.CoreWebView2.Settings.IsZoomControlEnabled = false;
        webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
        webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;

        webView.CoreWebView2.AddWebResourceRequestedFilter($"http://{Configuration.HostName.ToLower()}/webview/overridenresources/recaptcha", CoreWebView2WebResourceContext.All);
        webView.CoreWebView2.WebResourceRequested += WebResourceRequested;
        void WebResourceRequested(object? _, CoreWebView2WebResourceRequestedEventArgs e)
        {
            logger?.LogInformation("[ReCaptchaClient-WebResourceRequested] WebView2 requested resource: Overriding to reCAPTCHA web content response");
            e.Response = webView.CoreWebView2.Environment.CreateWebResourceResponse(webContentResponse, 200, "OK", "Content-Type: text/html");
        };


        // Verify
        webView.CoreWebView2.Navigate($"http://{Configuration.HostName.ToLower()}/webview/overridenresources/recaptcha");
        token = await reciever.WaitAsyc(cancellationToken);

        logger?.LogInformation("[ReCaptchaClient-VerifyAsync] reCAPTCHA was successfully verified");


        // Close window and return
        window.Close();
        return token;
    }
}