# ITheme
The interface for custom themes.

**Type:** Interface
<br />
**Namespace:** [ReCaptcha.Desktop.WinUI.UI.Themes.Interfaces](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/ui/themes/interfaces/)
<br />
**Assembly:** [ReCaptcha.Desktop.WinUI](/ReCaptcha.Desktop/reference/recaptcha.desktop.winui/)

```cs
public interface ITheme
```

## Properties

### Background
The main backhround color.

**Type**: `Brush`
<br />
**Modifier:** none

### Border
The main border color.

**Type**: `Brush`
<br />
**Modifier:** none

### Foreground
The main foreground color.

**Type**: `Brush`
<br />
**Modifier:** none

### ForegroundSecondary
The secondary foreground color.

**Type**: `Brush`
<br />
**Modifier:** none

### Error
The error message color.

**Type**: `Brush`
<br />
**Modifier:** none

### CheckBoxBackground
The checkbox background color.

**Type**: `Brush`
<br />
**Modifier:** none

### CheckBoxBackgroundHover
The checkbox background color when hovered.

**Type**: `Brush`
<br />
**Modifier:** none

### CheckBoxBackgroundPressed
The checkbox background color when pressed.

**Type**: `Brush`
<br />
**Modifier:** none

### CheckBoxBorder
The checkbox border color.

**Type**: `Brush`
<br />
**Modifier:** none

### CheckBoxBorderHover
The checkbox border color when hovered.

**Type**: `Brush`
<br />
**Modifier:** none

### CheckBoxBorderPressed
The checkbox border color when pressed.

**Type**: `Brush`
<br />
**Modifier:** none

### CheckBoxSpinner
The checkbox loading spinner color.

**Type**: `Brush`
<br />
**Modifier:** none

### CheckBoxCheckmark
The checkbox checkmark color.

**Type**: `Brush`
<br />
**Modifier:** none


## Methods

### Light
Creates a new light theme.

**Returns:** A new light theme.
```cs
public static ITheme Light() 
```

### Dark
Creates a new dark theme.

**Returns:** A new dark theme.
```cs
public static ITheme Dark() 
```