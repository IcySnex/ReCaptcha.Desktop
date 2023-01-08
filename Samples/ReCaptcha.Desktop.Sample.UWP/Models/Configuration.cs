using CommunityToolkit.Mvvm.ComponentModel;
using ReCaptcha.Desktop.Configuration;
using System;

namespace ReCaptcha.Desktop.Sample.UWP.Models;

public partial class Configuration : ObservableObject
{
    [ObservableProperty]
    string httpUrl = "http://localhost";

    [ObservableProperty]
    int httpPort = 5000;


    [ObservableProperty]
    string siteKey = "";

    [ObservableProperty]
    string language = "en";

    [ObservableProperty]
    string tokenRecievedHtml = "Token recieved: %token%";

    [ObservableProperty]
    string tokenRecievedHookedHtml = "Token recieved and sent to application.";


    [ObservableProperty]
    string title = "UWP Sample - Google reCAPTCHA";

    [ObservableProperty]
    string icon = "ms-appx:///Icon.png";

    [ObservableProperty]
    bool hasTitleBar = true;

    [ObservableProperty]
    bool isDragable = false;

    [ObservableProperty]
    bool isDimmed = true;

    [ObservableProperty]
    bool? hasRoundedCorners = null;

    [ObservableProperty]
    PopupStartupLocation startupLocation = PopupStartupLocation.CenterPrimary;

    [ObservableProperty]
    int left = 0;

    [ObservableProperty]
    int top = 0;



    [ObservableProperty]
    TimeSpan timeout = TimeSpan.FromMinutes(1);

    [ObservableProperty]
    bool showHandlerMessages = false;
}