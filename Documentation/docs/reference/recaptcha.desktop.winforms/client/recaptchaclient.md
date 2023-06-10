# ReCaptchaClient
Client which handles all ReCaptcha verifications.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Client.WinForms](/ReCaptcha.Desktop/reference/recaptcha.desktop.winforms/client/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinForms](/ReCaptcha.Desktop/reference/recaptcha.desktop.winforms/)
<br />
**Inherits from:** [IReCaptchaClient](/ReCaptcha.Desktop/reference/recaptcha.desktop/client/interfaces/irecaptchaclient.html)

```cs
public class ReCaptchaBase : IReCaptchaBase
```


## Constructors
Creates a new ReCaptchaClient.
```cs
public ReCaptchaClient(
    ReCaptchaConfig configuration,
    FormConfig formConfiguration)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `ReCaptchaConfig` configuration | The configuration the ReCaptchaClient should be created with. |
| `FormConfig` formConfiguration | The configuration the reCAPTCHA form will be created with. |

Creates a new ReCaptchaClient with extendended logging functions
```cs
public ReCaptchaClient(
    ReCaptchaConfig configuration,
    FormConfig formConfiguration,
    ILogger<IReCaptchaClient> logger)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `ReCaptchaConfig` configuration | The configuration the ReCaptchaClient should be created with. |
| `FormConfig` formConfiguration | The configuration the reCAPTCHA form will be created with. |
| `ILogger<IReCaptchaClient>` logger | A logger from Dependency Injection with MVVM. |


## Properties

### Configuration
The configuration used for this client.

**Type**: `ReCaptchaConfig`
<br />
**Modifier:** none
<br />
**Default Value:** none

### FormConfiguration
The form configuration used for this client.

**Type**: `FormConfig`
<br />
**Modifier:** none
<br />
**Default Value:** none

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
Starts and stops the HTTP server and opens a new form for the user to verify.

**Returns:** A Google reCAPTCHA token.
```cs
Task<string> VerifyAsync(
    CancellationToken cancellationToken = default!)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| *`CancellationToken` cancellationToken*                  | The token to cancel this action.      |
