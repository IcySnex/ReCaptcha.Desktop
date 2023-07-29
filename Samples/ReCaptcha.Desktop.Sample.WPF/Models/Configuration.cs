using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Windows;

namespace ReCaptcha.Desktop.Sample.WPF.Models;

public partial class Configuration : ObservableObject
{
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
    string title = "WPF Sample - Google reCAPTCHA";

    [ObservableProperty]
    string icon = Environment.CurrentDirectory + "\\Icon.png";

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