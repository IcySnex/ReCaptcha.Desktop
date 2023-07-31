# Configurating

The `ReCaptchaConfig` is the main configuration. This configuration configures everything from the Google sitekey to what the end user sees.

To learn more about the `ReCaptchaConfig` visit the [Reference](/ReCaptcha.Desktop/reference/recaptcha.desktop.wpf/configuration/recaptchaconfig.html).
It contains an explanation of all properties and functions.

### Creating an instance
```cs
ReCaptchaConfig config = new ReCaptchaConfig(
    siteKey: "GOOGLE_SITE_KEY",
    hostName: "HOST_NAME",
    language: "en",
    tokenRecievedHtml: "Token recieved: %token%",
    tokenRecievedHookedHtml: "Token recieved and sent to application.",
    httpConfiguration: serverConfig);
```
Optionally you can create a `ReCaptchaConfig` even easier:
```cs
ReCaptchaConfig config = "GOOGLE_SITE_KEY".AsReCaptchaConfig("HOST_NAME", "en", "Token recieved: %token%", "Token recieved and sent to application.");
```

#### SiteKey
You will need a Google reCAPTCHA site key. You can [sign up for an API key](http://www.google.com/recaptcha/admin) at the official Google reCAPTCHA developers portal.

#### HostName
The reCAPTCHA token also stores the hostname of the site on which the verifcaiton was made. Since we are using a windows desktop framework and not an actual website we can modify our hostname to whatever we like.
Just make sure that this hostname is whitelisted on your reCAPTCHA authorized domainss
To not get confused you should set this to something which represents your application for example the applications name or website.

#### Language
You can optionally define a language in which the Google reCAPTCHA will get rendered.
The [language code](https://developers.google.com/recaptcha/docs/language) will be directly passed to the hosted widget.

#### TokenRecievedHtml
This is the HTML which gets displayed when the end user has successfully verifed the reCAPTCHA.
This is only visible if something went wrong while sending back the token to the application. Normally a user should never see this.
You can use `%token%` to embed the reCAPTCHA token.

#### TokenRecievedHookedHtml
This is similar to the [TokenRecievedHtml](#tokenrecievedhtml) but it will only get displyed when a [WebMessageRecieved](https://learn.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.winforms.webview2.webmessagereceived) event is hooked on a [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/).
The user will propably never see this but you can add for example a "loading spinner" or a "Please close this window" message whenever it's unexpectedly visible.