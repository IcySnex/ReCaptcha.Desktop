# Extentions
Extension methods to create configurations easier.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.WPF.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.wpf/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop.WPF](/ReCaptcha.Desktop/reference/recaptcha.desktop.wpf/)

```cs
public static class Extentions
```

## Methods

### AsReCaptchaConfig
Creates a new ReCaptchaConfig.

**Returns:** A new AsReCaptchaConfig.
```cs
public static ReCaptchaConfig AsReCaptchaConfig(
    this string siteKey,
    string hostName,
    string language = "en",
    string tokenRecievedHtml = "Token recieved: %token%",
    string tokenRecievedHookedHtml = "Token recieved and sent to application.",
    HttpServerConfig? httpConfiguration = null)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `this string` siteKey | The SiteKey for the Google reCAPTCHA service. |
| `string` hostName | The name of the virtual host on which the reCAPTCHA is hosted. Should represent your application. |
| *`string` language*                  | The language for the Google reCAPTCHA service.      |
| *`string` tokenRecievedHtml*                  | The HTML which gets displayed after the user verifed the reCAPTCHA. Use %token% to embed the token inside the message.      |
| *`string` tokenRecievedHookedHtml*                  | The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application. Use %token% to embed the token inside the message.      |
| *`HttpServerConfig?` httpConfiguration*                  | The configuration for the HttpServer.      |
### AsWindowConfig
Creates a new AsWindowConfig.

**Returns:** A new AsWindowConfig.
```cs
public static WindowConfig AsWindowConfig(
    this string title,
    ImageSource icon = default!,
    Window? owner = null,
    bool showAsDialog = false,
    WindowStartupLocation startupLocation = WindowStartupLocation.CenterScreen,
    int left = 0,
    int top = 0)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `this string` title | The title of the window. |
| *`ImageSource` icon*                  | The icon of the window.      |
| *`Window?` owner*                  | The owner of this window. (Only used for StartupLocation.CenterOwner).      |
| *`bool` showAsDialog*                  | Wether to block the UI thread when showing the window.      |
| *`WindowStartupLocation?` startupLocation*                  | The startup postion of the window.      |
| *`int?` left*                  | The left position of the window.      |
| *`int?` top*                  | The top position of the window.      |