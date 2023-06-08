# HttpServerStoppedEventArgs
Event arguments for when a HttpServer stopped.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Client.EventArgs](/ReCaptcha.Desktop/reference/recaptcha.desktop/eventargs/)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop/)
<br />
**Inherits from:** [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs)

```cs
public class HttpServerStoppedEventArgs : System.EventArgs
```

## Constructors
Creates new HttpServerStoppedEventArgs.
```cs
public HttpServerStoppedEventArgs(
    string url,
    int port)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `string` url | The url the server lived on. |
| `int` port | The port the server lived on. |

## Properties

### Url
The url the server lived on.

**Type**: `string`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** none

### Port
The port the server lived on.

**Type**: `int`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** none

### OccurredAt
The date and time when it got stopped.

**Type**: `DateTime`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** `DateTime.Now`