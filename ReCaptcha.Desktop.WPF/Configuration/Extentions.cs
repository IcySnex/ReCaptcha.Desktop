using System.Windows;
using System.Windows.Media;

namespace ReCaptcha.Desktop.WPF.Configuration;

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
    /// Creates a new WindowConfig
    /// </summary>
    /// <param name="title">The title of the window</param>
    /// <param name="icon">The icon of the window</param>
    /// <param name="owner">The owner of this window. (Only used for StartupLocation.CenterOwner)</param>
    /// <param name="startupLocation">The startup postion of the window</param>
    /// <param name="left">The left position of the window</param>
    /// <param name="top">The top position of the window</param>
    /// <param name="showAsDialog">Wether to block the UI thread when showing the window</param>
    /// <returns>A new WindowConfig</returns>
    public static WindowConfig AsWindowConfig(
        this string title,
        ImageSource icon = default!,
        Window? owner = null,
        bool showAsDialog = false,
        WindowStartupLocation startupLocation = WindowStartupLocation.CenterScreen,
        int left = 0,
        int top = 0) =>
        new(title, icon, owner, startupLocation, left, top, showAsDialog);
}