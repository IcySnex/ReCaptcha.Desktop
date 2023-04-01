using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.EventArgs;
using ReCaptcha.Desktop.HTTP.Interfaces;
using System.Net;
using System.Text;

namespace ReCaptcha.Desktop.HTTP;

/// <summary>
/// HTTP server for all HTTP requests
/// </summary>
public class HttpServer : IHttpServer
{
    readonly HttpListener listener = new();

    /// <summary>
    /// Creates a new HttpServer
    /// </summary>
    /// <param name="configuration">The configuration the HttppServer should be created with</param>
    /// <param name="webContent">The HTML web content which should get displayed on the server</param>
    public HttpServer(
        HttpServerConfig configuration,
        string webContent)
    {
        Configuration = configuration;
        WebContent = webContent;

        //listener.TimeoutManager.EntityBody = configuration.Timeout;
    }


    HttpServerConfig configuration = default!;
    /// <summary>
    /// The configuration the HttppServer should be created with
    /// </summary>
    public HttpServerConfig Configuration
    {
        get => configuration;
        set
        {
            listener.Prefixes.Clear();
            listener.Prefixes.Add($"{value.Url}:{value.Port}/");

            configuration = value;
        }
    }

    /// <summary>
    /// The HTML web content which should get displayed on the server
    /// </summary>
    public string WebContent { get; set; } = default!;


    /// <summary>
    /// Fires when the HttpServer started
    /// </summary>
    public event EventHandler<HttpServerStartedEventArgs>? Started;

    /// <summary>
    /// Fires when the HttpServer stopped
    /// </summary>
    public event EventHandler<HttpServerStoppedEventArgs>? Stopped;

    /// <summary>
    /// Fires when an request occurred in the asynchronous response thread
    /// </summary>
    public event EventHandler<RequestOccurredEventArgs>? RequestOccurred;

    /// <summary>
    /// Fires when an exception was thrown inside the asynchronous response thread
    /// </summary>
    public event EventHandler<RequestErrorOccurredEventArgs>? RequestErrorOccurred;


    /// <summary>
    /// Starts the HttpServer with the given configuration
    /// </summary>
    /// <returns>An array of all prefixes through which the server can be accessed </returns>
    public string[] Start()
    {
        // Start HttpListener and start asynchronous response thread
        listener.Start();
        Task.Factory.StartNew(ResponseThreadAsync, TaskCreationOptions.LongRunning);

        // Invoke event and return prefixes
        string[] prefixes = listener.Prefixes.ToArray();
        Started?.Invoke(this, new(configuration.Url, configuration.Port, prefixes));
        return prefixes;
    }

    /// <summary>
    /// Stops the HttpServer
    /// </summary>
    public void Stop()
    {
        // Stop HttpListener
        listener.Stop();

        // Invoke event
        Stopped?.Invoke(this, new(configuration.Url, configuration.Port));
    }


    /// <summary>
    /// Asynchronous response thread for upcoming HTTP requests
    /// </summary>
    async Task ResponseThreadAsync()
    {
        while (listener.IsListening)
            try
            {
                // Get HTTP context
                HttpListenerContext context = await listener.GetContextAsync();

                // Write web content
                byte[] response = Encoding.ASCII.GetBytes(WebContent);
                await context.Response.OutputStream.WriteAsync(response, 0, response.Length);

                // Invoke event
                RequestOccurred?.Invoke(this, new(context, response));

                // Close response
                context.Response.KeepAlive = false;
                context.Response.Close();
            }
            catch (Exception ex)
            {
                // Invoke event
                RequestErrorOccurred?.Invoke(this, new(ex));
            }
    }


    /// <summary>
    /// Checks wether a connection is open on the given HttpServerConfig
    /// </summary>
    /// <param name="configuration">The HttpServer configuration to check</param>
    /// <param name="cancellationToken">The token to cancel this action</param>
    /// <returns>A bool wether its true</returns>
    public static async Task<bool> IsOpenAsync(
        HttpServerConfig configuration,
        CancellationToken cancellationToken = default!)
    {
        try
        {
            using HttpClient client = new();
            await client.GetAsync($"{configuration.Url}:{configuration.Port}/", cancellationToken);
            return false;
        }
        catch
        {
            return true;
        }
    }
}