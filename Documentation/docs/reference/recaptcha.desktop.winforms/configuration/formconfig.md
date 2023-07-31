# FormConfig
Configuration for a ReCaptcha form.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.WinForms.Configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.winforms/configuration/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinForms](/ReCaptcha.Desktop/reference/recaptcha.desktop.winforms/)

```cs
public class FormConfig
```

## Constructors
Creates a new FormConfig.
```cs
public FormConfig(
    string title,
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

## Properties

### Title
The title of the form.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** none

### Icon
The icon of the form.

**Type**: `Icon`
<br />
**Modifier:** none
<br />
**Default Value:** `default!`

### Parent
The parent of this form. (Only used for StartupLocation.CenterParent).

**Type**: `Form?`
<br />
**Modifier:** none
<br />
**Default Value:** `null`

### StartupLocation
The start position of the form.

**Type**: `WindowStartupLocation`
<br />
**Modifier:** none
<br />
**Default Value:** `WindowStartupLocation.CenterScreen`

### Left
The left position of the form.

**Type**: `int`
<br />
**Modifier:** none
<br />
**Default Value:** `0`

### Top
The top position of the form.

**Type**: `int`
<br />
**Modifier:** none
<br />
**Default Value:** `0`

### ShowAsDialog
Wether to block the UI thread when showing the form.

**Type**: `bool`
<br />
**Modifier:** none
<br />
**Default Value:** `false`
