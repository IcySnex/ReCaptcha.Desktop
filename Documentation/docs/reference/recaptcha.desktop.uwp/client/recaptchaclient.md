# ReCaptchaClient
Client which handles all ReCaptcha verifications.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.UWP.Client](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/client/)
<br />
**Assembly:** [ReCaptcha.Desktop.UWP](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/)
<br />
**Inherits from:** [IReCaptchaClient](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/client/interfaces/irecaptchaclient.html)

```cs
public class ReCaptchaBase : IReCaptchaBase
```


## Constructors
Creates a new ReCaptchaClient.
```cs
public ReCaptchaClient(
    ReCaptchaConfig configuration,
    PopupConfig popupConfiguration)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `ReCaptchaConfig` configuration | The configuration the ReCaptchaClient should be created with. |
| `PopupConfig` popupConfiguration | The configuration the reCAPTCHA popup will be created with. |

Creates a new ReCaptchaClient with extendended logging functions
```cs
public ReCaptchaClient(
    ReCaptchaConfig configuration,
    PopupConfig popupConfiguration,
    ILogger<IReCaptchaClient> logger)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `ReCaptchaConfig` configuration | The configuration the ReCaptchaClient should be created with. |
| `PopupConfig` popupConfiguration | The configuration the reCAPTCHA popup will be created with. |
| `ILogger<IReCaptchaClient>` logger | A logger from Dependency Injection with MVVM. |


## Properties

### Configuration
The configuration used for this client.

**Type**: `ReCaptchaConfig`
<br />
**Modifier:** none
<br />
**Default Value:** none

### PopupConfiguration
The popup configuration used for this client.

**Type**: `PopupConfig`
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
Sets up the reCAPTCHA site and opens a new window for the user to verify.

**Returns:** A Google reCAPTCHA token.
```cs
Task<string> VerifyAsync(
    CancellationToken cancellationToken = default!)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| *`CancellationToken` cancellationToken*                  | The token to cancel this action.      |
