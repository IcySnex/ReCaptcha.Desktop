# Extentions
Extension methods to create configurations easier.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.winforms/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinForms](/ReCaptcha.Desktop/reference/recaptcha.desktop.winforms/)

```cs
public static class Extentions
```

## Methods

### AsFormConfig
Creates a new FormConfig.

**Returns:** A new FormConfig.
```cs
public static FormConfig AsFormConfig(
    this string title,
    Icon icon = default!,
    Form? parent = null,
    FormStartPosition startPosition = FormStartPosition.CenterScreen,
    int left = 0,
    int top = 0
    bool showAsDialog = false,)
```
| Parameter                                                | Description                           |
|----------------------------------------------------------|---------------------------------------|
| `string` title | The title of the form. |
| *`Icon` icon*                  | The icon of the form.      |
| *`Form?` parent*                  | The parent of this form. (Only used for StartupLocation.CenterParent).      |
| *`FormStartPosition` startPosition*                  | The start position of the form.      |
| *`int` left*                  | The left position of the form.      |
| *`int` top*                  | The top position of the form.      |
| *`bool` showAsDialog*                  | Wether to block the UI thread when showing the form.      |