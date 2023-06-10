# HttpServerConfig
Configuration for a HttpServer.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop](/ReCaptcha.Desktop/reference/recaptcha.desktop/)

```cs
public class HttpServerConfig
```

## Constructors
Creates a new HttpServerConfig.
```cs
public HttpServerConfig(
    string url = "http://localhost",
    int port = 5000)
```
| Parameter                                                                                   | Description                                                 |
|---------------------------------------------------------------------------------------------|-------------------------------------------------------------|
| *`string` url* | The url the server lives on. |
| *`int` port* | The port the server lives on. |

## Properties

### Url
The url the server lives on.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** `http://localhost`

### Port
The port the server lives on.

**Type**: `int`
<br />
**Modifier:** none
<br />
**Default Value:** `5000`