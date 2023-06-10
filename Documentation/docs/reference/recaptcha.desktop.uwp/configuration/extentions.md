# Extentions
Extension methods to create configurations easier.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop.UWP](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/)

```cs
public static class Extentions
```

## Methods

### AsPopupConfig
Creates a new PopupConfig.

**Returns:** A new PopupConfig.
```cs
public static PopupConfig AsPopupConfig(
    this string title,
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
| `string` title | The title of the dialog (Only used when HasTitleBar is true). |
| *`ImageSource?` icon*                  | The icon of the dialog (Only used when HasTitleBar is true).      |
| *`bool` hasTitlebar*                  | Wether the dialog has a TitleBar.      |
| *`bool` isDraggable*                  | Wether the dialog is draggable within the main window (Only used when HasTitleBar is true).      |
| *`bool` isDimmed*                  | Wether the dialog dims the main windows background.      |
| *`bool?` hasRoundedCorners*                  | Wether the window has rounded corners (If null the value is true on Windows 11 and false on Windows 10).      |
| *`PopupStartupLocation` startupLocation*                  | The startup location of the popup.      |
| *`int` left*                  | The left position of the window.      |
| *`int` top*                  | The top position of the window.      |