# Configurating

## HttpServerConfig
The `HttpServerConfig` is the configuration which configures the backend [HttpServer](/ReCaptcha.Desktop/reference/recaptcha.desktop/http/httpserver.html) as you might have guessed.
You can change the url and port the server lives on. It is not recommended to change the url through.

To learn more about the `HttpServerConfig` visit the [Reference](/ReCaptcha.Desktop/reference/recaptcha.desktop/configuration/httpserverconfig.html).
It contains an explanation of all properties and functions.

### Creating an instance
```cs
HttpServerConfig serverConfig = new HttpServerConfig(
    url: "http://localhost",
    port: 5000);
```
Optionally you can create a `HttpServerConfig` even easier:
```cs
HttpServerConfig serverConfig = "http://localhost".AsHttpServerConfig(5000);
```

### HTTP port
Since ReCaptcha.Desktop has to host a [HTTPListener](https://learn.microsoft.com/en-us/dotnet/api/system.net.httplistener) to verify the Google reCAPTCHA it may conflict with an exising server on the end users `localhost`. This is why ReCaptcha.Desktop has a little extention method to determite if a HTTP port is already used:
```cs
bool isAvailable = await serverConfig.IsOpenAsync();
// OR
bool isAvailable = await HttpServer.IsOpenAsync(serverConfig);
```

This is how creating a new `HttpServerConfig` could look like in a real world application:
```cs
// Genereate random HTTP port based on IANA's suggestion until open port was found
Random rnd = new();
HttpServerConfig serverConfig = new("http://localhost", rnd.Next(49152, 65535));

while(!await serverConfig.IsOpenAsync())
    serverConfig.Port = rnd.Next(49152, 65535);
```

---

## ReCaptchaConfig
The `ReCaptchaConfig` is the main configuration. This configuration configures everything from the Google sitekey to the UI.
It also contains an instance of a [HttpServerConfig](#httpserverconfig).

To learn more about the `ReCaptchaConfig` visit the [Reference](/ReCaptcha.Desktop/reference/recaptcha.desktop/configuration/recaptchaconfig.html).
It contains an explanation of all properties and functions.

### Creating an instance
```cs
ReCaptchaConfig config = new ReCaptchaConfig(
    siteKey: "GOOGLE_SITE_KEY",
    language: "en",
    tokenRecievedHtml: "Token recieved: %token%",
    tokenRecievedHookedHtml: "Token recieved and sent to application.",
    httpConfiguration: serverConfig);
```
Optionally you can create a `HttpServerConfig` even easier:
```cs
HttpServerConfig config = "GOOGLE_SITE_KEY".AsReCaptchaConfig("en", "Token recieved: %token%", "Token recieved and sent to application.", serverConfig);
```

#### SiteKey
You will need a Google reCAPTCHA site key. You can [sign up for an API key](http://www.google.com/recaptcha/admin) at the official Google reCAPTCHA developers portal.

#### Language
You can optionally define a language in which the Google reCAPTCHA will get rendered.
The [language code](https://developers.google.com/recaptcha/docs/language) will be directly passed to the hosted widget.

#### TokenRecievedHtml
This is the HTML which gets displayed when the end user has successfully verifed the reCAPTCHA.
This property is only useful when using ReCaptcha.Desktop without an UI framework since the user will have to complete the reCAPTCHA in the default browser.
You can use `%token%` to embed the reCAPTCHA token.

#### TokenRecievedHookedHtml
This is similar to the [TokenRecievedHtml](#tokenrecievedhtml) but it will only get displyed when a [WebMessageRecieved](https://learn.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.winforms.webview2.webmessagereceived) event is hooked on a [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/).
The user will propably never see this but you can add for example a "loading spinner" or a "Please close this window" message whenever it's unexpectedly visible.

#### HttpConfiguration
Here you can pass a [HttpServerConfig](#httpserverconfig) to configure the backend HttpServer.