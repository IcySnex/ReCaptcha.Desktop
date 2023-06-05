# Widget
ReCaptcha.Desktop allows your UI to have the same feeling as if you were using the origignal [Google reCAPTCHA widget](https://www.google.com/recaptcha/api2/demo). But of course you can also customize the ReCaptcha control as you like. You can choose cusotm colors, texts, links and much more. By default ReCaptcha.Desktop has a light and a dark Theme.

The ReCaptcha control is available for [WPF](reference/wpf/ui), [WinUI3](reference/winui/ui) and [UWP](reference/uwp/ui). Currently there is no support for WinForms.

WPF                                                |  WinUi3                                                |  UWP
:-------------------------------------------------:|:------------------------------------------------------:|:----------------------------------------------------:
![](/ReCaptcha.Desktop/guide/widget/demo-wpf.png)  |  ![](/ReCaptcha.Desktop/guide/widget/demo-winui3.png)  |  ![](/ReCaptcha.Desktop/guide/widget/demo-uwp.png)


## Installation
Installing ReCaptcha.Desktop to your application is not very hard but it is slightly different for each platform. This section will explain how to prepare your application for using the ReCaptcha control. Before using the widget please follow the instructions here: [Getting Started](getting-started.html#wpf-winui3-uwp-winforms)

### WPF
- **Step 1:** Add `ReCaptcha.Desktop.WPF.UI` namespaces to your page container
```xml
</UserControl
    xmlns:ui="clr-namespace:ReCaptcha.Desktop.WPF.UI;assembly=ReCaptcha.Desktop.WPF"
    xmlns:themes="clr-namespace:ReCaptcha.Desktop.WPF.UI.Themes;assembly=ReCaptcha.Desktop.WPF">

    <!-- YOU PAGE CONTENT -->
</UserCOntrol>
```

- **Step 2:** Import the `CommonDictionary` to your App ResourceDictionary 
```xml
</Application>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <CommonDictionary xmlns="clr-namespace:ReCaptcha.Desktop.WPF.UI;assembly=ReCaptcha.Desktop.WPF" />
            </ResourceDictionary.MergedDictionaries>

        <!-- OITHER APP RESOURCES -->
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

### WinUI3

- **Step 1:** Add `ReCaptcha.Desktop.WinUI.UI` namespaces to your page container
```xml
</Page
    xmlns:ui="using:ReCaptcha.Desktop.WinUI.UI"
    xmlns:themes="using:ReCaptcha.Desktop.WinUI.UI.Themes">

    <!-- YOU PAGE CONTENT -->
</UserCOntrol>
```

- **Step 2:** Import the `CommonDictionary` to your App ResourceDictionary 
```xml
</Application>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <XamlControlsResources xmlns="using:Microsoft.UI.Xaml.Controls" /> <!-- Required for WinUI3 -->
                <CommonDictionary xmlns="using:ReCaptcha.Desktop.WinUI.UI" />
            </ResourceDictionary.MergedDictionaries>

            <!-- OITHER APP RESOURCES -->
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

### UWP

- **Step 1:** Add `ReCaptcha.Desktop.UWP.UI` namespaces to your page container
```xml
</Page
    xmlns:ui="using:ReCaptcha.Desktop.UWP.UI"
    xmlns:themes="using:ReCaptcha.Desktop.UWP.UI.Themes">

    <!-- YOU PAGE CONTENT -->
</UserCOntrol>
```

- **Step 2:** Import the `CommonDictionary` to your App ResourceDictionary 
```xml
</Application>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <CommonDictionary xmlns="using:ReCaptcha.Desktop.UWP.UI" />
            </ResourceDictionary.MergedDictionaries>
            
        <!-- OITHER APP RESOURCES -->
        </ResourceDictionary>
    </Application.Resources>
</Application>
```


## How to use (MVVM)
Using the ReCaptcha control in your applications is really easy and the exact same for all supported platforms. This section will explain how to use and customize the control inside a MVVM application.
This is how you can set a theme directly with XAML (make sure you have the `themes` namespace imported):

### Control
By simply adding the control to your visual tree, you can see that it looks exactly like the Google reCAPTCHA widget. By not setting any properties the control will act like a normal checkbox
```xml
<ui:ReCaptcha />
```
![](/ReCaptcha.Desktop/guide/widget/howtouse-control.gif)

### Themes
Like said before, ReCaptcha.Desktop supports varios themes. The default theme is `Light` which mimics the Google reCAPTCHA colors. There is also an out of the box `Dark` theme which mimics Googles dark mode colors.
```xml
<ui:ReCaptcha>
    <ui:ReCaptcha.Theme>
        <themes:LightTheme />
    </ui:ReCaptcha.Theme>
</ui:ReCaptcha>

<ui:ReCaptcha>
    <ui:ReCaptcha.Theme>
        <themes:DarkTheme />
    </ui:ReCaptcha.Theme>
</ui:ReCaptcha>
```
![](/ReCaptcha.Desktop/guide/widget/howtouse-themes.png)

### Text & Assets
As you may already noticed, the official Google reCAPTCHA widget has a `I'm not a robot` label in the center, a reCAPTCHA icon with label on the right side and underneath 2 hyperlinks for `Privacy` and `Terms`.
ReCaptcha.Desktop allows you to customize everything about that.
- The `Content` property allows you to edit the main text on the widget
- The `Icon` property allows you to set a custom image as the reCAPTCHA icon
- THe `TItle` property allows you to edit the reCAPTCHA label
- The `FirstUri` & `SecondtUri` property allow you to set a custom URL for the two hyperlinks
- The `FirstUriText` & `SecondtUriText` property allow you to edit the text of the two hyperlinks
A customized widget may look like this:
```xml
<ui:ReCaptcha
   Title="420 Inc."
   Content="me is 100% human"
   FirstUri="https://github.com/IcySnex/ReCaptcha.Desktop"
   FirstUriText="github :)"
   Icon="https://cdn-icons-png.flaticon.com/512/9061/9061613.png"
   SecondaryUri="https://icysnex.github.io/ReCaptcha.Desktop/"
   SecondaryUriText="DOCSSSSS" />
```
![](/ReCaptcha.Desktop/guide/widget/howtouse-textassets.png)