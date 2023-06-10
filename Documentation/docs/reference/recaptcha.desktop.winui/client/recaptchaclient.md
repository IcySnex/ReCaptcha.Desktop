# ReCaptchaClient
Client which handles all ReCaptcha verifications.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Client.WinUI](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/client/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinUI](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/)
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
    WindowConfig windowConfiguration)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `ReCaptchaConfig` configuration | The configuration the ReCaptchaClient should be created with. |
| `WindowConfig` windowConfiguration | The configuration the reCAPTCHA window will be created with. |

Creates a new ReCaptchaClient with extendended logging functions
```cs
public ReCaptchaClient(
    ReCaptchaConfig configuration,
    WindowConfig windowConfiguration,
    ILogger<IReCaptchaClient> logger)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `ReCaptchaConfig` configuration | The configuration the ReCaptchaClient should be created with. |
| `WindowConfig` windowConfiguration | The configuration the reCAPTCHA window will be created with. |
| `ILogger<IReCaptchaClient>` logger | A logger from Dependency Injection with MVVM. |


## Properties

### Configuration
The configuration used for this client.

**Type**: `ReCaptchaConfig`
<br />
**Modifier:** none
<br />
**Default Value:** none

### WindowConfiguration
The window configuration used for this client.

**Type**: `WindowConfig`
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
Starts and stops the HTTP server and opens a new window for the user to verify.

**Returns:** A Google reCAPTCHA token.
```cs
Task<string> VerifyAsync(
    CancellationToken cancellationToken = default!)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| *`CancellationToken` cancellationToken*                  | The token to cancel this action.      |
