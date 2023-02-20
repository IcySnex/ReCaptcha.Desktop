using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.EventArgs;

namespace ReCaptcha.Desktop.HTTP.Interfaces;

/// <summary>
/// HTTP server for all HTTP requests
/// </summary>
public interface IHttpServer
{
    /// <summary>
    /// The configuration the HttppServer should be created with
    /// </summary>
    public HttpServerConfig Configuration { get; set; }

    /// <summary>
    /// The HTML web content which should get displayed on the server
    /// </summary>
    public string WebContent { get; set; }


    /// <summary>
    /// Fires when the HttpServer started
    /// </summary>
    event EventHandler<HttpServerStartedEventArgs>? Started;

    /// <summary>
    /// Fires when the HttpServer stopped
    /// </summary>
    event EventHandler<HttpServerStoppedEventArgs>? Stopped;

    /// <summary>
    /// Fires when an request occurred in the asynchronous response thread
    /// </summary>
    event EventHandler<RequestOccurredEventArgs>? RequestOccurred;

    /// <summary>
    /// Fires when an exception was thrown inside the asynchronous response thread
    /// </summary>
    event EventHandler<RequestErrorOccurredEventArgs>? RequestErrorOccurred;


    /// <summary>
    /// Starts the HttpServer with the given configuration
    /// </summary>
    /// <returns>An array of all prefixes through which the server can be accessed </returns>
    string[] Start();

    /// <summary>
    /// Stops the HttpServer
    /// </summary>
    void Stop();


    ///// <summary>
    ///// Creates a new HttpServer
    ///// </summary>
    ///// <param name="configuration">The configuration the HttppServer should be created with</param>
    ///// <param name="webContent">The HTML web content which should get displayed on the server</param>
    ///// <returns>A new HttpServer</returns>
    //public static IHttpServer New(
    //    HttpServerConfig configuration,
    //    string webContent) =>
    //    new HttpServer(configuration, webContent);
}