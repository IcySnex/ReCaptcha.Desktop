# WindowConfig
Configuration for a ReCaptcha window.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.WinUI.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinUI](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/)

```cs
public class WindowConfig
```

## Constructors
Creates a new WindowConfig.
```cs
public WindowConfig(
    string title,
    ImageSource icon = default!,
    Window? owner = null,
    bool showAsDialog = false,
    WindowStartupLocation startupLocation = WindowStartupLocation.CenterScreen,
    int left = 0,
    int top = 0)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `string` title | The title of the window. |
| *`ImageSource` icon*                  | The icon of the window.      |
| *`Window?` owner*                  | The owner of this window. (Only used for StartupLocation.CenterOwner).      |
| *`bool` showAsDialog*                  | Wether to block the UI thread when showing the window.      |
| *`WindowStartupLocation` startupLocation*                  | The startup postion of the window.      |
| *`int` left*                  | The left position of the window.      |
| *`int` top*                  | The top position of the window.      |

## Properties

### Title
The title of the window.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** none

### Icon
The icon of the window.

**Type**: `ImageSource`
<br />
**Modifier:** none
<br />
**Default Value:** `default!`

### Owner
The owner of this window. (Only used for StartupLocation.CenterOwner).

**Type**: `Window?`
<br />
**Modifier:** none
<br />
**Default Value:** `null`

### ShowAsDialog
Wether to block the UI thread when showing the window.

**Type**: `bool`
<br />
**Modifier:** none
<br />
**Default Value:** `false`

### StartupLocation
The startup postion of the window.

**Type**: `WindowStartupLocation`
<br />
**Modifier:** none
<br />
**Default Value:** `WindowStartupLocation.CenterScreen`

### Left
The left position of the window.

**Type**: `int`
<br />
**Modifier:** none
<br />
**Default Value:** `0`

### Top
The top position of the window.

**Type**: `int`
<br />
**Modifier:** none
<br />
**Default Value:** `0`
