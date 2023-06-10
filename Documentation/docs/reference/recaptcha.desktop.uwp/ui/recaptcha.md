# ReCaptcha
ReCaptcha control that mimics the original Google reCAPTCHA widget.

**Type:** Class
<br />
**Namespace:** [ReCaptcha.Desktop.UWP.UI](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/ui/)
<br />
**Assembly:** [ReCaptcha.Desktop.UWP](/ReCaptcha.Desktop/reference/recaptcha.desktop.uwp/)
<br />
**Inherits from:** [ContentControl](https://learn.microsoft.com/uwp/api/windows.ui.xaml.controls.contentcontrol)

```cs
public sealed class ReCaptcha : ContentControl
```

## Constructors
Creates a new ReCaptcha control.
```cs
public ReCaptcha()
```

## Properties

### VerificationRequested
Fires when the user requests a verification.

**Type**: `EventHandler?`
<br />
**Modifier:** `event`
<br />
**Default Value:** none

### VerificationRemoved
Fires when the user removes a verification or stops a verification request.

**Type**: `EventHandler?`
<br />
**Modifier:** `event`
<br />
**Default Value:** none

### VerificationRequestedCommand
The command that gets executed when the user requests a verification.

**Type**: `ICommand`
<br />
**Modifier:** none
<br />
**Default Value:** none

### VerificationRequestedCommandParameter
The command that gets executed when the user requests a verification.

**Type**: `object`
<br />
**Modifier:** none
<br />
**Default Value:** none

### VerificationRemovedCommand
The command that gets executed when the user removes a verification or stops a verification request.

**Type**: `ICommand`
<br />
**Modifier:** none
<br />
**Default Value:** none

### VerificationRemovedCommandParameter
The command that gets executed when the user removes a verification.

**Type**: `object`
<br />
**Modifier:** none
<br />
**Default Value:** none

### Theme
The theme used by the ReCaptcha control.

**Type**: `ITheme`
<br />
**Modifier:** none
<br />
**Default Value:** `ITheme.Light()`

### Icon
The icon source shown on the right side of the ReCaptcha control.

**Type**: `ImageSource`
<br />
**Modifier:** none
<br />
**Default Value:** `new BitmapImage(new("ms-appx:///ReCaptcha.Desktop.UWP/UI/Assets/Icon.png"))`

### Title
The title shown on the right side of the ReCaptcha control.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** `"reCAPTCHA"`

### FirstUri
The uri thats gets opened in the default browser when clicked on the first hyperlink.

**Type**: `Uri`
<br />
**Modifier:** none
<br />
**Default Value:** `"https://policies.google.com/privacy"`

### FirstUriText
The text of the first hyperlink.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** `"Privacy"`

### SecondaryUri
The uri thats gets opened in the default browser when clicked on the second hyperlink.

**Type**: `Uri`
<br />
**Modifier:** none
<br />
**Default Value:** `"https://policies.google.com/terms"`

### SecondaryUriText
The text of the secondary hyperlink.

**Type**: `string`
<br />
**Modifier:** none
<br />
**Default Value:** `"Terms"`

### IsChecked
Wether the ReCaptcha control is checked, unchecked or loading.

**Type**: `bool`
<br />
**Modifier:** none
<br />
**Default Value:** `false`

### IsLoading
Wether the ReCaptcha control shows loading.

**Type**: `bool`
<br />
**Modifier:** none
<br />
**Default Value:** `false`

### ErrorMessage
The error message which gets displayed if not null.

**Type**: `string?`
<br />
**Modifier:** none
<br />
**Default Value:** `null`

### NavigationCacheMode
The caching characteristics for the control involved in a navigation.

**Type**: `NavigationCacheMode`
<br />
**Modifier:** none
<br />
**Default Value:** `NavigationCacheMode.Disabled`