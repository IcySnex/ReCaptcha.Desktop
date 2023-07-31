# ReCaptchaReciever
Reciever to communicate with the HTTP server with extended resize functions.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.UWP.Client](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/client/)
<br />
**Assembly:** [ReCaptcha.Desktop.UWP](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/)

```cs
public class ReCaptchaReciever
```


## Constructors
Creates a new ReCaptchaReciever.
```cs
public ReCaptchaReciever()
```


## Properties

### VerificationRecieved
Fires when verifcation was recieved from the HTTP server.

**Type**: `EventHandler<VerificationRecievedEventArgs>?`
<br />
**Modifier:** `event`

### VerificationCancelled
Fires when verifcation was cancelled from the HTTP server.

**Type**: `EventHandler<VerificationCancelledEventArgs>?`
<br />
**Modifier:** `event`

### ReCaptchaResized
Fires when Google reCAPTCHA widget gets resized.

**Type**: `EventHandler<ReCaptchaResizedEventArgs>?`
<br />
**Modifier:** `event`


## Methods

### SetWebView
Set the targeted CoreWebView for the ReCaptchaReciever.
```cs
public void SetWebView(
    CoreWebView2 coreWebView)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `CoreWebView2` coreWebView                | The WebView to hook the web message events.      |


### WaitAsyc
Asynchronously waits until a token was sent by the HTTP server.

**Returns:** A Google reCAPTCHA token.
```cs
public Task<string> WaitAsyc(
    CancellationToken cancellationToken)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `CancellationToken` cancellationToken                | The token to cancel this action.      |
