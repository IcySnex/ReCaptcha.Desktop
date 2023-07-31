# ReCaptchaConfig
Configuration for a ReCaptcha client.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.UWP.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop.UWP](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/)

```cs
public class ReCaptchaConfig
```

## Constructors
Creates a new ReCaptchaConfig.
```cs
public ReCaptchaConfig(
    string siteKey,
    string hostName,
    string language = "en",
    string tokenRecievedHtml = "Token recieved: %token%",
    string tokenRecievedHookedHtml = "Token recieved and sent to application.",
    HttpServerConfig? httpConfiguration = null)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `string` siteKey | The SiteKey for the Google reCAPTCHA service. |
| `string` hostName | The name of the virtual host on which the reCAPTCHA is hosted. Should represent your application. |
| *`string` language* | The language for the Google reCAPTCHA service. |
| *`string` tokenRecievedHtml* | The HTML which gets displayed after the user verifed the reCAPTCHA. Use %token% to embed the token inside the message. |
| *`string` tokenRecievedHookedHtml* | The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application. Use %token% to embed the token inside the message. |
| *`HttpServerConfig?` httpConfiguration* | The configuration for the HttpServer. |

## Properties

### SiteKey
The SiteKey for the Google reCAPTCHA service

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** none

### HostName
The name of the virtual host on which the reCAPTCHA is hosted. Should represent your application.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** none

### Language
The language for the Google reCAPTCHA service.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** `en`

### TokenRecievedHtml
The HTML which gets displayed after the user verifed the reCAPTCHA. Use %token% to embed the token inside the message.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** `Token recieved: %token%`

### TokenRecievedHookedHtml
The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application. Use %token% to embed the token inside the message.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** `Token recieved and sent to application.`

### TokenRecievedHookedHtml
The configuration for the HttpServer

**Type**: `HttpServerConfig`
<br />
**Modifier:** none
<br />
**Default Value:** `new()`