# IReCaptchaClient
Client which handles all ReCaptcha verifications.

**Type:** Interface
<br />
**Namespace:** [ReCaptcha.Desktop.WinForms.Client.Interfaces](/ReCaptcha.Desktop/reference/recaptcha.desktop.winforms/client/interfaces/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinForms](/ReCaptcha.Desktop/reference/recaptcha.desktop.winforms/)

```cs
public interface IReCaptchaClient
```


## Properties

### Configuration
The configuration used for this client.

**Type**: `ReCaptchaConfig`
<br />
**Modifier:** none

### FormConfiguration
The form configuration used for this client.

**Type**: `FormConfig`
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