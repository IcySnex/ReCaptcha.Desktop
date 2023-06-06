using Microsoft.Extensions.Logging;
using Microsoft.Web.WebView2.WinForms;
using ReCaptcha.Desktop.Client.Base;
using ReCaptcha.Desktop.Client.Interfaces;
using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.EventArgs;

namespace ReCaptcha.Desktop.Client.WinForms;

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
    /// <param name="formConfiguration">The configuration the reCAPTCHA form will be created with</param>
    public ReCaptchaClient(
        ReCaptchaConfig configuration,
        FormConfig formConfiguration)
    {
        reCaptcha = new ReCaptchaResizeableBase(configuration);

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
        reCaptcha = new ReCaptchaResizeableBase(configuration);

        Configuration = configuration;
        FormConfiguration = formConfiguration;

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
    /// The form configuration used for this client
    /// </summary>
    public FormConfig FormConfiguration { get; set; }


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
    /// Starts and stops the HTTP server and opens a new form for the user to verify
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
            // If cancelled and token is still not set close form
            if (token is null && form is not null)
                form.BeginInvoke(() => form?.Close());

            logger?.LogInformation("[ReCaptchaClient-OnTokenCancelled] reCAPTCHA vericitaion timed out");
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

            int left = hasResized ? form.Left + (webView.Width / 2) - (width / 2) : FormConfiguration.StartPosition switch
            {
                FormStartPosition.CenterScreen => (screen.Width - width) / 2,
                FormStartPosition.CenterParent => FormConfiguration.Parent?.Left + (FormConfiguration.Parent?.Width / 2) - (width / 2),
                _ => FormConfiguration.Left
            } ?? FormConfiguration.Left;
            form.Left = left < 0 ? 0 : left > screen.Width - width ? screen.Width - width : left;
            int top = hasResized ? form.Top + (webView.Height / 2) - (height / 2) : FormConfiguration.StartPosition switch
            {
                FormStartPosition.CenterScreen => (screen.Height - height) / 2,
                FormStartPosition.CenterParent => FormConfiguration.Parent?.Top + (FormConfiguration.Parent?.Height / 2) - (height / 2),
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

        // Close form and return
        form.Close();
        return token;
    }
}