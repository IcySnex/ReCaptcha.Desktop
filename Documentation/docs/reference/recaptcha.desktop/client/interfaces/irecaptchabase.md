# IReCaptchaBase
Base client which manages a ReCaptcha HTTP server.

**Type:** Interface
<br />
**Namespace:** [ReCaptcha.Desktop.Client.Interfaces](/ReCaptcha.Desktop/reference/recaptcha.desktop/client/interfaces)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop)

```cs
public interface IReCaptchaBase
```


## Properties

### Configuration
The configuration used for this base client.

**Type**: `ReCaptchaConfig`
<br />
**Modifier:** none

### VerificationRecieved
Fires when verifcation was recieved.

**Type**: `EventHandler<VerificationRecievedEventArgs>?`
<br />
**Modifier:** `event`


## Methods

### Verify
Starts and stops the HTTP server and calls a verify callback with the url.

**Returns:** A Google reCAPTCHA token
```cs
string Verify(
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
Task<string> VerifyAsync(
    Func<string, CancellationToken, Task<string>> verifyCallback,
    CancellationToken cancellationToken = default!)
```
| Parameter                                                      | Description                           |
|----------------------------------------------------------------|---------------------------------------|
| `Func<string, CancellationToken, Task<string>>` verifyCallback | The callback which is used to verify. |
| *`CancellationToken` cancellationToken*                        | The token to cancel this action.      |