# ReCaptchaResizedEventArgs
Event arguments for when a reCAPTCHA widget was resized.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.UWP.EventArgs](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/eventargs/)
<br />
**Assembly:** [ReCaptcha.Desktop.UWP](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/)
<br />
**Inherits from:** [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs)

```cs
public class ReCaptchaResizedEventArgs : System.EventArgs
```

## Constructors
Creates new ReCaptchaResizedEventArgs.
```cs
[JsonConstructor]
public ReCaptchaResizedEventArgs(
    int width,
    int height)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `int` width | The new width of the reCAPTCHA widget. |
| `int` height | The new height of the reCAPTCHA widget. |

## Properties

### Width
The new width of the reCAPTCHA widget.

**Type**: `int`
<br />
**Modifier:** `readonly`, `[JsonPropertyName("width")]`
<br />
**Default Value:** none

### Height
The new height of the reCAPTCHA widget.

**Type**: `int`
<br />
**Modifier:** `readonly`, `[JsonPropertyName("width")]`
<br />
**Default Value:** none

### OccurredAt
The date and time when it got resized.

**Type**: `DateTime`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** `DateTime.Now`