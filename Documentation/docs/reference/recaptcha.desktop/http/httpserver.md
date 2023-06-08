# HttpServer
HTTP server for all HTTP requests.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.HTTP](/ReCaptcha.Desktop/reference/recaptcha.desktop/http/)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop/)
<br />
**Inherits from:** [IHttpServer](/ReCaptcha.Desktop/reference/recaptcha.desktop/http/interfaces/ihttpserver.html)

```cs
public class HttpServer : IHttpServer
```


## Constructors
Creates a new HttpServer.
```cs
public HttpServer(
    HttpServerConfig configuration,
    string webContent)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `HttpServerConfig` configuration | The configuration the HttppServer should be created with. |
| `string` webContent | The HTML web content which should get displayed on the server. |


## Properties

### Configuration
The configuration the HttppServer should be created with.

**Type**: `HttpServerConfig`
<br />
**Modifier:** none
<br />
**Default Value:** none

### WebContent
The HTML web content which should get displayed on the server.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** none

### Started
Fires when the HttpServer started.

**Type**: `EventHandler<HttpServerStartedEventArgs>?`
<br />
**Modifier:** `event`
<br />
**Default Value:** none

### Stopped
Fires when the HttpServer stopped.

**Type**: `EventHandler<HttpServerStoppedEventArgs>?`
<br />
**Modifier:** `event`
<br />
**Default Value:** none

### RequestOccurred
Fires when an request occurred in the asynchronous response thread.

**Type**: `EventHandler<RequestOccurredEventArgs>?`
<br />
**Modifier:** `event`
<br />
**Default Value:** none

### RequestErrorOccurred
Fires when an exception was thrown inside the asynchronous response thread.

**Type**: `EventHandler<RequestErrorOccurredEventArgs>?`
<br />
**Modifier:** `event`
<br />
**Default Value:** none


## Methods

### Start
Starts the HttpServer with the given configuration.

**Returns:** An array of all prefixes through which the server can be accessed.
```cs
string[] Start()
```

### Stop
Stops the HttpServer.
```cs
void Stop()
```

### IsOpenAsync
Checks wether a connection is open on the given HttpServerConfig.

**Returns:** A bool wether its true.
```cs
public static async Task<bool> IsOpenAsync(
    HttpServerConfig configuration,
    CancellationToken cancellationToken = default!)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| `HttpServerConfig` configuration | The HttpServer configuration to check. |
| *`CancellationToken` cancellationToken* | The token to cancel this action. |