using Microsoft.Extensions.Logging;
using Microsoft.Web.WebView2.WinForms;
using ReCaptcha.Desktop.Client.Interfaces;
using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.EventArgs;

namespace ReCaptcha.Desktop.Client.WinForms;

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
        ILogger<ReCaptchaClient> logger)
    {
        baseClient = new(configuration);

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
            baseClient = new(value);
            logger?.LogInformation("[ReCaptchaClient-Configuration.Set] Created new resizeable BaseClient");

            configuration = value;
        }
    }

    /// <summary>
    /// The window configuration used for this client
    /// </summary>
    public WindowConfig WindowConfiguration { get; set; }


    Form window = default!;
    WebView2 webView = default!;

    bool hasResized = false;

    void CreateWindowAndWebView()
    {
        webView = new()
        {
            Dock = DockStyle.Fill
        };
        window = new()
        {
            Text = WindowConfiguration.Title,
            Icon = WindowConfiguration.Icon,
            Owner = WindowConfiguration.Owner,
            Left = 0,
            Top = 0,
            FormBorderStyle = FormBorderStyle.FixedSingle,
            MaximizeBox = false,
            MinimizeBox = false,
            WindowState = FormWindowState.Minimized,
        };
        window.Controls.Add(webView);
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
                window.BeginInvoke(() => window?.Close());

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
            window.WindowState = FormWindowState.Normal;
            window.ShowInTaskbar = true;

            // Scaling
            double scaling = window.DeviceDpi / 96.0;
            int width = (int)(e.Width * scaling);
            int height = (int)(e.Height * scaling);

            // Set window position based on configuration and size
            Rectangle screen = Screen.GetBounds(webView);

            int left = hasResized ? window.Left + (webView.Width / 2) - (width / 2) : WindowConfiguration.StartupLocation switch
            {
                FormStartPosition.CenterScreen => (screen.Width - width) / 2,
                FormStartPosition.CenterParent => WindowConfiguration.Owner?.Left + (WindowConfiguration.Owner?.Width / 2) - (width / 2),
                _ => WindowConfiguration.Left
            } ?? WindowConfiguration.Left;
            window.Left = left < 0 ? 0 : left > screen.Width - width ? screen.Width - width : left;
            int top = hasResized ? window.Top + (webView.Height / 2) - (height / 2) : WindowConfiguration.StartupLocation switch
            {
                FormStartPosition.CenterScreen => (screen.Height - height) / 2,
                FormStartPosition.CenterParent => WindowConfiguration.Owner?.Top + (WindowConfiguration.Owner?.Height / 2) - (height / 2),
                _ => WindowConfiguration.Top
            } ?? WindowConfiguration.Top;
            window.Top = top < 0 ? 0 : top > screen.Height - height ? screen.Height - height - 30 : top;

            // Set size
            window.Width = (int)(width + 17 * scaling);
            window.Height = (int)(height + 42 * scaling);
            hasResized = true;

            logger?.LogInformation("[ReCaptchaClient-OnReCaptchaResized] reCAPTCHA widget was resized");
        }


        // Launch window
        if (WindowConfiguration.ShowAsDialog && WindowConfiguration.Owner is not null)
            await Task.Run(() => WindowConfiguration.Owner.BeginInvoke(() => window.ShowDialog()));
        else
            window.Show();


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

        token = await baseClient.VerifyAsync(WaitForVerificationAsync, cancelSource.Token);
        logger?.LogInformation("[ReCaptchaClient-VerifyAsync] reCAPTCHA was successfully verified");

        // Close window and return
        window.Close();
        return token;
    }
}