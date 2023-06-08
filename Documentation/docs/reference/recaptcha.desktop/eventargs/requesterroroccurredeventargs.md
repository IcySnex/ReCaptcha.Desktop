# RequestErrorOccurredEventArgs
Event arguments for when an exception was thrown inside an asynchronous response thread.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Client.EventArgs](/ReCaptcha.Desktop/reference/recaptcha.desktop/eventargs/)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop/)
<br />
**Inherits from:** [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs)

```cs
public class RequestErrorOccurredEventArgs : System.EventArgs
```

## Constructors
Creates new RequestErrorOccurredEventArgs.
```cs
public RequestErrorOccurredEventArgs(
    Exception exception)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `Exception` exception | The exceptions that got thrown. |

## Properties

### Exception
The exceptions that got thrown.

**Type**: `Exception`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** none

### OccurredAt
The date and time when it got thrown.

**Type**: `DateTime`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** `DateTime.Now`