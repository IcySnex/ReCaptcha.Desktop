using CommunityToolkit.Mvvm.ComponentModel;
using ReCaptcha.Desktop.WinUI.Configuration;

namespace ReCaptcha.Desktop.Sample.WinUI.Models;

public partial class Configuration : ObservableObject
{
    /// <summary>
    /// Requires application restart.
    /// Property is not visible in settings view.
    /// </summary>
    public bool UseMica { get; set; } = true;


    [ObservableProperty]
    string siteKey = "";

    [ObservableProperty]
    string hostName = "recaptcha.desktop";

    [ObservableProperty]
    string language = "en";

    [ObservableProperty]
    string tokenRecievedHtml = "Token recieved: %token%";

    [ObservableProperty]
    string tokenRecievedHookedHtml = "Token recieved and sent to application.";


    [ObservableProperty]
    string title = "WinUI Sample - Google reCAPTCHA";

    [ObservableProperty]
    string icon = "Icon.ico";

    [ObservableProperty]
    WindowStartupLocation startupLocation = WindowStartupLocation.CenterScreen;

    [ObservableProperty]
    int left = 0;

    [ObservableProperty]
    int top = 0;

    [ObservableProperty]
    bool showAsDialog = false;


    [ObservableProperty]
    TimeSpan timeout = TimeSpan.FromMinutes(1);

    [ObservableProperty]
    bool showHandlerMessages = false;
}