using Microsoft.Extensions.Logging;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using ReCaptcha.Desktop.WinForms.Client.Interfaces;
using ReCaptcha.Desktop.WinForms.Configuration;
using ReCaptcha.Desktop.WinForms.EventArgs;
using System.Text;

namespace ReCaptcha.Desktop.WinForms.Client;

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
    /// <param name="formConfiguration">The configuration the reCAPTCHA form will be created with</param>
    public ReCaptchaClient(
        ReCaptchaConfig configuration,
        FormConfig formConfiguration)
    {
        Configuration = configuration;
        FormConfiguration = formConfiguration;
    }

    /// <summary>
    /// Creates a new ReCaptchaClient with extendended logging functions
    /// </summary>
    /// <param name="configuration">The configuration the ReCaptchaClient should be created with</param>
    /// <param name="formConfiguration">The configuration the reCAPTCHA form will be created with</param>
    /// <param name="logger">A logger from Dependency Injection with MVVM</param>
    public ReCaptchaClient(
        ReCaptchaConfig configuration,
        FormConfig formConfiguration,
        ILogger<IReCaptchaClient> logger)
    {
        Configuration = configuration;
        FormConfiguration = formConfiguration;

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
    /// The form configuration used for this client
    /// </summary>
    public FormConfig FormConfiguration { get; set; }


    Stream webContentResponse = default!;

    Form form = default!;
    WebView2 webView = default!;

    bool hasResized = false;

    void CreateFormAndWebView()
    {
        webView = new() { Dock = DockStyle.Fill };
        form = new()
        {
            Text = FormConfiguration.Title,
            Icon = FormConfiguration.Icon,
            Owner = FormConfiguration.Parent,
            Left = 0,
            Top = 0,
            FormBorderStyle = FormBorderStyle.FixedSingle,
            MaximizeBox = false,
            MinimizeBox = false,
            WindowState = FormWindowState.Minimized,
        };
        form.Controls.Add(webView);
        hasResized = false;

        logger?.LogInformation("[ReCaptchaClient-CreateFormAndWebView] Created reCAPTCHA form with webView");
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
    /// Sets up the reCAPTCHA site and opens a new form for the user to verify
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
            // If cancelled and token is still not set close form
            if (token is null && form is not null)
                form.BeginInvoke(() => form?.Close());

            logger?.LogInformation("[ReCaptchaClient-OnTokenCancelled] reCAPTCHA vericitaion was cancelled");
        });


        // Create UI
        CreateFormAndWebView();

        // Hook handlers
        form.Closed += OnFormClosed;
        void OnFormClosed(object? _, object _1)
        {
            // Remove all used handlers
            form.Closed -= OnFormClosed;
            ReCaptchaResized -= OnReCaptchaResized;

            // If token stil not set cancel
            if (token is null)
                cancelSource.Cancel();

            // Dispose all objects and clear UI
            cancelSource.Dispose();
            webView.Dispose();
            form = default!;
            webView = default!;

            logger?.LogInformation("[ReCaptchaClient-OnFormClosed] reCAPTCHA form was closed and objects were disposed");
        }

        ReCaptchaResized += OnReCaptchaResized;
        void OnReCaptchaResized(object? _, ReCaptchaResizedEventArgs e)
        {
            // Skip intial startup
            if (e.Height < 200)
                return;

            // Show form
            form.WindowState = FormWindowState.Normal;
            form.ShowInTaskbar = true;

            // Scaling
            double scaling = form.DeviceDpi / 96.0;
            int width = (int)(e.Width * scaling);
            int height = (int)(e.Height * scaling);

            // Set form position based on configuration and size
            Rectangle screen = Screen.GetBounds(webView);

            int left = hasResized ? form.Left + webView.Width / 2 - width / 2 : FormConfiguration.StartPosition switch
            {
                FormStartPosition.CenterScreen => (screen.Width - width) / 2,
                FormStartPosition.CenterParent => FormConfiguration.Parent?.Left + FormConfiguration.Parent?.Width / 2 - width / 2,
                _ => FormConfiguration.Left
            } ?? FormConfiguration.Left;
            form.Left = left < 0 ? 0 : left > screen.Width - width ? screen.Width - width : left;
            int top = hasResized ? form.Top + webView.Height / 2 - height / 2 : FormConfiguration.StartPosition switch
            {
                FormStartPosition.CenterScreen => (screen.Height - height) / 2,
                FormStartPosition.CenterParent => FormConfiguration.Parent?.Top + FormConfiguration.Parent?.Height / 2 - height / 2,
                _ => FormConfiguration.Top
            } ?? FormConfiguration.Top;
            form.Top = top < 0 ? 0 : top > screen.Height - height ? screen.Height - height - 30 : top;

            // Set size
            form.Width = (int)(width + 17 * scaling);
            form.Height = (int)(height + 42 * scaling);
            hasResized = true;

            logger?.LogInformation("[ReCaptchaClient-OnReCaptchaResized] reCAPTCHA widget was resized");
        }


        // Launch form
        if (FormConfiguration.ShowAsDialog && FormConfiguration.Parent is not null)
            await Task.Run(() => FormConfiguration.Parent.BeginInvoke(() => form.ShowDialog()));
        else
            form.Show();


        // Setup WebView
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
        token = await reciever.WaitAsyc(cancelSource.Token);

        logger?.LogInformation("[ReCaptchaClient-VerifyAsync] reCAPTCHA was successfully verified");


        // Close form and return
        form.Close();
        return token;
    }
}