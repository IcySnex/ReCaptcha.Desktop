# HttpServerStartedEventArgs
Event arguments for when a HttpServer started.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Client.EventArgs](/ReCaptcha.Desktop/reference/recaptcha.desktop/eventargs/)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop/)
<br />
**Inherits from:** [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs)

```cs
public class HttpServerStartedEventArgs : System.EventArgs
```

## Constructors
Creates new HttpServerStartedEventArgs.
```cs
public HttpServerStartedEventArgs(
    string url,
    int port,
    string[] prefixes)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `string` url | The url the server lives on. |
| `int` port | The port the server lives on. |
| `string[]` prefixes | The array of all prefixes through which the server can be accessed. |

## Properties

### Url
The url the server lives on.

**Type**: `string`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** none

### Port
The port the server lives on.

**Type**: `int`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** none

### Prefixes
The array of all prefixes through which the server can be accessed.

**Type**: `string[]`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** none

### OccurredAt
The date and time when it got started.

**Type**: `DateTime`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** `DateTime.Now`