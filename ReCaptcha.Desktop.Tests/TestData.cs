namespace ReCaptcha.Desktop.Tests;

class TestData
{
    /// <summary>
    /// Wether to wait for WaitTimespan in running server tests for test purposes
    /// </summary>
    public static readonly bool WaitInTests = true;

    /// <summary>
    /// The default wait time on tests
    /// </summary>
    public static readonly TimeSpan WaitTimespan = TimeSpan.FromSeconds(10);


    /// <summary>
    /// The HTML web content which should get displayed on the server
    /// </summary>
    public static readonly string WebContent = "<h1>hello world</h1>";

    /// <summary>
    /// The default host url for the HttpServer
    /// </summary>
    public static readonly string HostUrl = "http://localhost";

    /// <summary>
    /// The default host port for the HttpServer
    /// </summary>
    public static readonly int HostPort = 5000;


    /// <summary>
    /// The default SiteKey for the Google reCAPTCHA service
    /// </summary>
    public static readonly string SiteKey = "6LcMZR0UAAAAALgPMcgHwga7gY5p8QMg1Hj-bmUv";//"<SITE KEY>";

    /// <summary>
    /// The default language for the Google reCAPTCHA service
    /// </summary>
    public static readonly string Language = "en";

    /// <summary>
    /// The message which gets displayed after the user verifed the reCAPTCHA
    /// Use %token% to embed the token inside the message
    /// </summary>
    public static readonly string TokenRecievedHtml = "Successfully verfied Google reCAPTCHA.\nYou can copy this code now into the application:\n\n %token%";

    /// <summary>
    /// The default message which gets displayed after the user verifed the reCAPTCHA and its hooked to the application
    /// Use %token% to embed the token inside the message
    /// </summary>
    public static readonly string TokenRecievedHookedHtml = "Successfully verfied Google reCAPTCHA.\nThe token was sent to the reciever. This window should close automatically. If not, please contact the developer.";
}