#nullable enable

using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.UI.Xaml.Controls;
using ReCaptcha.Desktop.UWP.Internal;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Core;
using ReCaptcha.Desktop.UWP.Client.Interfaces;
using ReCaptcha.Desktop.UWP.Configuration;
using ReCaptcha.Desktop.UWP.EventArgs;
using Windows.Storage.Streams;
using System.IO;
using System.Text;
using Microsoft.Web.WebView2.Core;
using Windows.Storage;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ReCaptcha.Desktop.UWP.Client;

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
        ILogger<IReCaptchaClient> logger)
    {
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
            if (configuration == value)
                return;

            string formattedWebContent = string.Format(
                WebContent,
                value.Language,
                value.TokenRecievedHookedHtml.Replace("\n", "<br/>"),
                value.TokenRecievedHtml.Replace("\n", "<br/>"),
                value.SiteKey);
            webContentResponse = Encoding.UTF8.GetBytes(formattedWebContent).AsBuffer();

            configuration = value;
        }
    }

    /// <summary>
    /// The popup configuration used for this client
    /// </summary>
    public PopupConfig PopupConfiguration { get; set; }


    IBuffer webContentResponse = default!;

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
    /// Fires when Google reCAPTCHA widget gets resized
    /// </summary>
    public event EventHandler<ReCaptchaResizedEventArgs>? ReCaptchaResized
    {
        add => reciever.ReCaptchaResized += value;
        remove => reciever.ReCaptchaResized -= value;
    }

    /// <summary>
    /// Sets up the reCAPTCHA site and opens a new popup for the user to verify
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
        cancelSource.Token.Register(async () =>
        {
            // If cancelled and token is still not set close window
            if (token is null && popup is not null)
                await popup.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (popup is not null)
                        popup.IsOpen = false;
                });

            logger?.LogInformation("[ReCaptchaClient-OnTokenCancelled] reCAPTCHA vericitaion was cancelled");
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
        logger?.LogInformation("[ReCaptchaClient-VerifyAsync] Setting up WebView2");

        await webView.EnsureCoreWebView2Async().AsTask(cancelSource.Token);
        reciever.SetWebView(webView.CoreWebView2);

        webView.CoreWebView2.Settings.AreDevToolsEnabled = false;
        webView.CoreWebView2.Settings.IsZoomControlEnabled = false;
        webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
        webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;

        webView.CoreWebView2.AddWebResourceRequestedFilter($"http://{Configuration.HostName.ToLower()}/webview/overridenresources/recaptcha", CoreWebView2WebResourceContext.All);
        webView.CoreWebView2.WebResourceRequested += WebResourceRequested;
        async void WebResourceRequested(object? _, CoreWebView2WebResourceRequestedEventArgs e)
        {
            logger?.LogInformation("[ReCaptchaClient-WebResourceRequested] WebView2 requested resource: Overriding to reCAPTCHA web content response");
            IRandomAccessStream randomMemoryStream = new InMemoryRandomAccessStream();
            await randomMemoryStream.WriteAsync(webContentResponse);
            e.Response = webView.CoreWebView2.Environment.CreateWebResourceResponse(randomMemoryStream, 200, "OK", "Content-Type: text/html");
        };


        // Verify
        webView.CoreWebView2.Navigate($"http://{Configuration.HostName.ToLower()}/webview/overridenresources/recaptcha");
        token = await reciever.WaitAsyc(cancelSource.Token);

        logger?.LogInformation("[ReCaptchaClient-VerifyAsync] reCAPTCHA was successfully verified");


        // Close popup and return
        webView.Close();
        popup.IsOpen = false;
        return token;
    }
}