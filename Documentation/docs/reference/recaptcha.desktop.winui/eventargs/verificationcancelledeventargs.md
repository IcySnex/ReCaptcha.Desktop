# VerificationCancelledEventArgs
Event arguments for when a verification was cancelled.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.WinUI.EventArgs](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/eventargs/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinUI](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/)
<br />
**Inherits from:** [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs)

```cs
public class VerificationCancelledEventArgs : System.EventArgs
```

## Constructors
Creates new VerificationCancelledEventArgs.
```cs
public VerificationCancelledEventArgs()
```

## Properties

### OccurredAt
The date and time when it got cancelled.

**Type**: `DateTime`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** `DateTime.Now`