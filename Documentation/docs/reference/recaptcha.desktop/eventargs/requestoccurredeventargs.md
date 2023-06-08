# RequestOccurredEventArgs
Event arguments for when an request occurred in an asynchronous response thread.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Client.EventArgs](/ReCaptcha.Desktop/reference/recaptcha.desktop/eventargs/)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop/)
<br />
**Inherits from:** [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs)

```cs
public class RequestOccurredEventArgs : System.EventArgs
```

## Constructors
Creates new RequestOccurredEventArgs.
```cs
public RequestOccurredEventArgs(
    HttpListenerContext context,
    byte[] response)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `HttpListenerContext` context | The HttpListener context. |
| `byte[]` response | The reponse which got sent to the request. |

## Properties

### Context
The HttpListener context.

**Type**: `HttpListenerContext`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** none

### Response
The reponse which got sent to the request.

**Type**: `byte[]`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** none

### OccurredAt
The date and time when it got requested.

**Type**: `DateTime`
<br />
**Modifier:** `readonly`
<br />
**Default Value:** `DateTime.Now`