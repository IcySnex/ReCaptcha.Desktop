namespace ReCaptcha.Desktop.WinForms.Configuration;

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
    /// Creates a new FormConfig
    /// </summary>
    /// <param name="title">The title of the form</param>
    /// <param name="icon">The icon of the form</param>
    /// <param name="parent">The parent of this form. (Only used for StartupLocation.CenterParent)</param>
    /// <param name="startPosition">The start position of the form</param>
    /// <param name="left">The left position of the form</param>
    /// <param name="top">The top position of the form</param>
    /// <param name="showAsDialog">Wether to block the UI thread when showing the form</param>
    /// <returns>A new FormConfig</returns>
    public static FormConfig AsFormConfig(
        this string title,
        Icon icon = default!,
        Form? parent = null,
        bool showAsDialog = false,
        FormStartPosition startPosition = FormStartPosition.CenterScreen,
        int left = 0,
        int top = 0) =>
        new(title, icon, parent, startPosition, left, top, showAsDialog);
}