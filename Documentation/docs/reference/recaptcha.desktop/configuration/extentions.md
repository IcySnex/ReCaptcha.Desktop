# Extentions
Extension methods to create configurations easier.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Client.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop/)

```cs
public static class Extentions
```

## Methods

### AsHttpServerConfig
Creates a new HttpServerConfig.

**Returns:** A new HttpServerConfig
```cs
public static HttpServerConfig AsHttpServerConfig(
    this string url,
    int port = 5000)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `this string` url | The url the server lives on. |
| *`int` port*                  | The port the server lives on.      |

### AsHttpServerConfig
Checks wether a connection is open on the given HttpServerConfig.

**Returns:** A bool wether its true
```cs
public static Task<bool> IsOpenAsync(
    this HttpServerConfig configuration,
    CancellationToken cancellationToken = default!)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `this HttpServerConfig` configuration | The HttpServer configuration to check. |
| *`CancellationToken` cancellationToken*                  | The token to cancel this action.      |

### AsReCaptchaConfig
Creates a new ReCaptchaConfig.

**Returns:** A bool wether its true
```cs
public static ReCaptchaConfig AsReCaptchaConfig(
    this string siteKey,
    string language = "en",
    string tokenRecievedHtml = "Token recieved: %token%",
    string tokenRecievedHookedHtml = "Token recieved and sent to application.",
    HttpServerConfig? httpConfiguration = null)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `this string` siteKey | The SiteKey for the Google reCAPTCHA service. |
| *`string` language*                  | The language for the Google reCAPTCHA service.      |
| *`string` tokenRecievedHtml*                  | The HTML which gets displayed after the user verifed the reCAPTCHA. Use %token% to embed the token inside the message.      |
| *`string` tokenRecievedHookedHtml*                  | The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application. Use %token% to embed the token inside the message.      |
| *`HttpServerConfig?` httpConfiguration*                  | The configuration for the HttpServer.      |