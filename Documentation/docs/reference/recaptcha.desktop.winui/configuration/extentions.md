# Extentions
Extension methods to create configurations easier.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinUI](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/)

```cs
public static class Extentions
```

## Methods

### AsWindowConfig
Creates a new AsWindowConfig.

**Returns:** A new AsWindowConfig.
```cs
public static WindowConfig AsWindowConfig(
    this string title,
    string icon = default!,
    Window? owner = null,
    bool showAsDialog = false,
    WindowStartupLocation startupLocation = WindowStartupLocation.CenterScreen,
    int left = 0,
    int top = 0)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `this string` title | The title of the window. |
| *`string` icon*                  | The icon of the window.      |
| *`Window?` owner*                  | The owner of this window. (Only used for StartupLocation.CenterOwner).      |
| *`bool` showAsDialog*                  | Wether to block the UI thread when showing the window.      |
| *`WindowStartupLocation?` startupLocation*                  | The startup postion of the window.      |
| *`int?` left*                  | The left position of the window.      |
| *`int?` top*                  | The top position of the window.      |