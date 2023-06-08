# ReCaptchaBase
Base client which manages a ReCaptcha HTTP server.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Client.Base](/ReCaptcha.Desktop/reference/recaptcha.desktop/client/base)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop)
<br />
**Inherits from:** [IReCaptchaBase](/ReCaptcha.Desktop/reference/recaptcha.desktop/client/interfaces/irecaptchabase)

```cs
public class ReCaptchaBase : IReCaptchaBase
```


## Constructors
Creates a new ReCaptchaBase.
```cs
public ReCaptchaBase(
    ReCaptchaConfig configuration)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `ReCaptchaConfig` configuration | The configuration the ReCaptchaBase should be created with. |


## Properties

### ReCaptchaHtml
The default reCaptcha HTML page.

**Type**: `string`
<br />
**Modifier:** `static`, `readonly`
<br />
**Default Value:** [...]

### Configuration
The configuration used for this base client.

**Type**: `ReCaptchaConfig`
<br />
**Modifier:** none
<br />
**Default Value:** none

### VerificationRecieved
Fires when verifcation was recieved.

**Type**: `EventHandler<VerificationRecievedEventArgs>?`
<br />
**Modifier:** `event`
<br />
**Default Value:** none


## Methods

### Verify
Starts and stops the HTTP server and calls a verify callback with the url.

**Returns:** A Google reCAPTCHA token
```cs
public string Verify(
    Func<string, CancellationToken, string> verifyCallback,
    CancellationToken cancellationToken = default!)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `Func<string, CancellationToken, string>` verifyCallback | The callback which is used to verify. |
| *`CancellationToken` cancellationToken*                  | The token to cancel this action.      |

### VerifyAsync
Starts and stops the HTTP server and asynchronously calls verify callback with the url.

**Returns:** A Google reCAPTCHA token
```cs
public async Task<string> VerifyAsync(
    Func<string, CancellationToken, Task<string>> verifyCallback,
    CancellationToken cancellationToken = default!)
```
| Parameter                                                      | Description                           |
|----------------------------------------------------------------|---------------------------------------|
| `Func<string, CancellationToken, Task<string>>` verifyCallback | The callback which is used to verify. |
| *`CancellationToken` cancellationToken*                        | The token to cancel this action.      |