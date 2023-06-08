# IReCaptchaClient
Client which handles all ReCaptcha verification.

**Type:** Interface
<br />
**Namespace:** [ReCaptcha.Desktop.Client.Interfaces](/ReCaptcha.Desktop/reference/recaptcha.desktop/client/interfaces/)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop/)

```cs
public interface IReCaptchaBase
```


## Properties

### Configuration
The configuration used for this client.

**Type**: `ReCaptchaConfig`
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
Fires when verifcation was cancelled.

**Type**: `EventHandler<ReCaptchaResizedEventArgs>?`
<br />
**Modifier:** `event`


## Methods

### VerifyAsync
Starts and stops the HTTP server and opens a new window for the user to verify.

**Returns:** A Google reCAPTCHA token.
```cs
Task<string> VerifyAsync(
    CancellationToken cancellationToken = default!)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| *`CancellationToken` cancellationToken*                  | The token to cancel this action.      |