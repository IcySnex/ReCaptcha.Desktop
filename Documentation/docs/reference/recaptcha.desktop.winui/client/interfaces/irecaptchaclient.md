# IReCaptchaClient
Client which handles all ReCaptcha verifications.

**Type:** Interface
<br />
**Namespace:** [ReCaptcha.Desktop.WinUI.Client.Interfaces](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/client/interfaces/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinUI](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/)

```cs
public interface IReCaptchaClient
```


## Properties

### Configuration
The configuration used for this client.

**Type**: `ReCaptchaConfig`
<br />
**Modifier:** none

### WindowConfiguration
The window configuration used for this client.

**Type**: `WindowConfig`
<br />
**Modifier:** none

### VerificationRecieved
Fires when verifcation was recieved.

**Type**: `EventHandler<VerificationRecievedEventArgs>?`
<br />
**Modifier:** `event`

### VerificationCancelled
Fires when verifcation was cancelled.

**Type**: `EventHandler<VerificationCancelledEventArgs>?`
<br />
**Modifier:** `event`

### ReCaptchaResized
Fires when Google reCAPTCHA widget gets resized.

**Type**: `EventHandler<ReCaptchaResizedEventArgs>?`
<br />
**Modifier:** `event`


## Methods

### VerifyAsync
Sets up the reCAPTCHA site and opens a new window for the user to verify.

**Returns:** A Google reCAPTCHA token.
```cs
Task<string> VerifyAsync(
    CancellationToken cancellationToken = default!)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| *`CancellationToken` cancellationToken*                  | The token to cancel this action.      |