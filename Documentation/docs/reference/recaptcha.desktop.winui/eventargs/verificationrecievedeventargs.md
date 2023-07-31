# VerificationRecievedEventArgs
Event arguments for when a verification successfully recieved.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.WinUI.EventArgs](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/eventargs/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinUI](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/)
<br />
**Inherits from:** [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs)

```cs
public class VerificationRecievedEventArgs : System.EventArgs
```

## Constructors
Creates new VerificationRecievedEventArgs.
```cs
public VerificationRecievedEventArgs(
    string token)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `string` token | The recieved token. |

## Properties

### Token
The recieved token.

**Type**: `string`
<br />
**Modifier:** `readonly`, `[JsonPropertyName("token")]`
<br />
**Default Value:** none

### OccurredAt
The date and time when it got recieved.

**Type**: `DateTime`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** `DateTime.Now`