namespace ReCaptcha.Desktop.Sample.WinForms.Models;

public class Configuration
{
    public string HttpUrl { get; set; } = "http://localhost";

    public int HttpPort { get; set; } = 5000;


    public string SiteKey { get; set; } = "";

    public string Language { get; set; } = "en";

    public string TokenRecievedHtml { get; set; } = "Token recieved: %token%";

    public string TokenRecievedHookedHtml { get; set; } = "Token recieved and sent to application.";


    public string Title { get; set; } = "WinForms Sample - Google reCAPTCHA";

    public string Icon { get; set; } = "icon.ico";

    public FormStartPosition StartPosition { get; set; } = FormStartPosition.CenterScreen;

    public int Left { get; set; } = 0;
    
    public int Top { get; set; } = 0;

    public bool ShowAsDialog { get; set; } = false;


    public TimeSpan Timeout { get; set; } = TimeSpan.FromMinutes(1);

    public bool ShowHandlerMessages { get; set; } = false;
}