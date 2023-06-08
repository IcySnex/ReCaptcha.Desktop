# IHttpServer
HTTP server for all HTTP requests.

**Type:** Interface
<br />
**Namespace:** [ReCaptcha.Desktop.HTTP.Interfaces](/ReCaptcha.Desktop/reference/recaptcha.desktop/http/interfaces/)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop/)

```cs
public interface IHttpServer
```


## Properties

### Configuration
The configuration the HttppServer should be created with.

**Type**: `HttpServerConfig`
<br />
**Modifier:** none

### WebContent
The HTML web content which should get displayed on the server.

**Type**: `string`
<br />
**Modifier:** none

### Started
Fires when the HttpServer started.

**Type**: `EventHandler<HttpServerStartedEventArgs>?`
<br />
**Modifier:** `event`

### Stopped
Fires when the HttpServer stopped.

**Type**: `EventHandler<HttpServerStoppedEventArgs>?`
<br />
**Modifier:** `event`

### RequestOccurred
Fires when an request occurred in the asynchronous response thread.

**Type**: `EventHandler<RequestOccurredEventArgs>?`
<br />
**Modifier:** `event`

### RequestErrorOccurred
Fires when an exception was thrown inside the asynchronous response thread.

**Type**: `EventHandler<RequestErrorOccurredEventArgs>?`
<br />
**Modifier:** `event`


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