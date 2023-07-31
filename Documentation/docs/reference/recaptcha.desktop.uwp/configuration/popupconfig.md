# PopupConfig
Configuration for a ReCaptcha popup.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.UWP.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop.UWP](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/)

```cs
public class PopupConfig
```

## Constructors
Creates a new PopupConfig.
```cs
public PopupConfig(
    string? title = null,
    ImageSource? icon = null,
    bool hasTitlebar = true,
    bool isDraggable = false,
    bool isDimmed = true,
    bool? hasRoundedCorners = null,
    PopupStartupLocation startupLocation = PopupStartupLocation.CenterPrimary,
    int left = 0,
    int top = 0)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| *`string?` title* | The title of the dialog (Only used when HasTitleBar is true). |
| *`ImageSource?` icon*                  | The icon of the dialog (Only used when HasTitleBar is true).      |
| *`bool` hasTitlebar*                  | Wether the dialog has a TitleBar.      |
| *`bool` isDraggable*                  | Wether the dialog is draggable within the main window (Only used when HasTitleBar is true).      |
| *`bool` isDimmed*                  | Wether the dialog dims the main windows background.      |
| *`bool?` hasRoundedCorners*                  | Wether the window has rounded corners (If null the value is true on Windows 11 and false on Windows 10).      |
| *`PopupStartupLocation` startupLocation*                  | The startup location of the popup.      |
| *`int` left*                  | The left position of the window.      |
| *`int` top*                  | The top position of the window.      |

## Properties

### Title
The title of the dialog (Only used when HasTitleBar is true).

**Type**: `string?`
<br />
**Modifier:** none
<br />
**Default Value:** `null`

### Icon
The icon of the dialog (Only used when HasTitleBar is true).

**Type**: `ImageSource?`
<br />
**Modifier:** none
<br />
**Default Value:** `null`

### HasTitleBar
Wether the dialog has a TitleBar.

**Type**: `bool`
<br />
**Modifier:** none
<br />
**Default Value:** `true`

### IsDragable
Wether the dialog is draggable within the main window (Only used when HasTitleBar is true).

**Type**: `bool`
<br />
**Modifier:** none
<br />
**Default Value:** `false`

### IsDimmed
Wether the dialog dims the main windows background.

**Type**: `bool`
<br />
**Modifier:** none
<br />
**Default Value:** `true`

### HasRoundedCorners
Wether the window has rounded corners (If null the value is true on Windows 11 and false on Windows 10).

**Type**: `bool?`
<br />
**Modifier:** none
<br />
**Default Value:** `null`

### StartupLocation
The startup location of the popup.

**Type**: `PopupStartupLocation`
<br />
**Modifier:** none
<br />
**Default Value:** `PopupStartupLocation.CenterPrimary`

### Left
The left position of the popup.

**Type**: `int`
<br />
**Modifier:** none
<br />
**Default Value:** `0`

### Top
The top position of the popup.

**Type**: `int`
<br />
**Modifier:** none
<br />
**Default Value:** `0`
