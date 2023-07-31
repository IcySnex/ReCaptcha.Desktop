# Extentions
Extension methods to create configurations easier.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.WinForms.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.winforms/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinForms](/ReCaptcha.Desktop/reference/recaptcha.desktop.winforms/)

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

### AsFormConfig
Creates a new FormConfig.

**Returns:** A new FormConfig.
```cs
public static FormConfig AsFormConfig(
    this string title,
    Icon icon = default!,
    Form? parent = null,
    FormStartPosition startPosition = FormStartPosition.CenterScreen,
    int left = 0,
    int top = 0
    bool showAsDialog = false)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `string` title | The title of the form. |
| *`Icon` icon*                  | The icon of the form.      |
| *`Form?` parent*                  | The parent of this form. (Only used for StartupLocation.CenterParent).      |
| *`FormStartPosition` startPosition*                  | The start position of the form.      |
| *`int` left*                  | The left position of the form.      |
| *`int` top*                  | The top position of the form.      |
| *`bool` showAsDialog*                  | Wether to block the UI thread when showing the form.      |