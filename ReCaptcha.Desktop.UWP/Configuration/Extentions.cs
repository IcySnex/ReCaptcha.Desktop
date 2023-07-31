#nullable enable

using Windows.UI.Xaml.Media;

namespace ReCaptcha.Desktop.UWP.Configuration;

/// <summary>
/// Extension methods to create configurations easier 
/// </summary>
public static class Extentions
{
    /// <summary>
    /// Creates a new ReCaptchaConfig
    /// </summary>
    /// <param name="siteKey">The SiteKey for the Google reCAPTCHA service</param>
    /// <param name="hostName">The name of the virtual host on which the reCAPTCHA is hosted. Should represent your application</param>
    /// <param name="language">The language for the Google reCAPTCHA service</param>
    /// <param name="tokenRecievedHtml">The HTML which gets displayed after the user verifed the reCAPTCHA. Use %token% to embed the token inside the message</param>
    /// <param name="tokenRecievedHookedHtml">The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application. Use %token% to embed the token inside the message</param>
    /// <returns>A new ReCaptchaConfig</returns>
    public static ReCaptchaConfig AsReCaptchaConfig(
        this string siteKey,
        string hostName,
        string language = "en",
        string tokenRecievedHtml = "Token recieved: %token%",
        string tokenRecievedHookedHtml = "Token recieved and sent to application.") =>
        new(siteKey, hostName, language, tokenRecievedHtml, tokenRecievedHookedHtml);

    /// <summary>
    /// Creates a new PopupConfig
    /// </summary>
    /// <param name="title">The title of the dialog. (Only used when HasTitleBar is true)</param>
    /// <param name="icon">The The icon of the dialog. (Only used when HasTitleBar is true)</param>
    /// <param name="hasTitleBar">Wether the dialog has a TitleBar</param>
    /// <param name="isDragable">Wether the dialog is draggable within the main window. (Only used when HasTitleBar is true)</param>
    /// <param name="isDimmed">Wether the dialog dims the main windows background</param>
    /// <param name="hasRoundedCorners">Wether the window has rounded corners. (If null the value is true on Windows 11 and false on Windows 10)</param>
    /// <param name="startupLocation">The startup location of the popup</param>
    /// <param name="left">The left position of the popup</param>
    /// <param name="top">The top position of the popup</param>
    /// <returns>A new DialogCOnfig</returns>
    public static PopupConfig AsPopupConfig(
        this string title,
        ImageSource? icon = null,
        bool hasTitleBar = true,
        bool isDragable = false,
        bool isDimmed = true,
        bool? hasRoundedCorners = null,
        PopupStartupLocation startupLocation = PopupStartupLocation.CenterPrimary,
        int left = 0,
        int top = 0) =>
        new(title, icon, hasTitleBar, isDragable, isDimmed, hasRoundedCorners, startupLocation, left, top);
}