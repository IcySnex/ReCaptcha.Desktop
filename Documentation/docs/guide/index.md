# Introduction
ReCaptcha.Desktop is an open source library to access Google's reCAPTCHA API on all majpr windows desktop frameworks including [WPF](https://learn.microsoft.com/en-us/dotnet/desktop/wpf), [WInUI3](https://learn.microsoft.com/en-us/windows/apps/winui/winui3/), [UWP](https://learn.microsoft.com/windows/uwp/), [WinForms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms). ReCaptcha.Desktop focuses on simplicity and stability, which means you can get started with just a few lines of code.

ReCaptcha.Desktop is fast and reliable. It uses Microsoft's official [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/) library on each specific plattform and the offical Google [reCAPTCHA widget/API](https://www.google.com/recaptcha/about/) to bring you the best performance and stability. Not only is ReCaptcha.Desktop fast but also highly customizable. You are able to change about anything - from themes to fundamental components.


## How it works
Since Google does not officially support any .NET desktop framework, ReCaptcha.Desktop has to use a [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/) to display a custom reCAPTCHA widget.
But don't worry, ReCaptcha.Desktop is still fast and the user doesn't see any of the fancy actions. A window appears only when manual user input is requested by Google.


## Information
- **ReCaptcha.Desktop.WPF:** .NET 6.0
- **ReCaptcha.Desktop.WinUI:** .NET 6.0
- **ReCaptcha.Desktop.UWP:** Target: Windows 11 (10.0; Build 22000) / Minimum: Windows 10, version 1809 (10.0; Build 17763)
- **ReCaptcha.Desktop.WinForms:** .NET 6.0
---
- **ReCaptcha.Desktop.WPF.Sample:** .NET 6.0
- **ReCaptcha.Desktop.WinUI.Sample:** .NET 6.0
- **ReCaptcha.Desktop.UWP.Sample:** Target: Windows 11 (10.0; Build 22000) / Minimum: Windows 10, version 1809 (10.0; Build 17763)
- **ReCaptcha.Desktop.WinForms.Sample:** .NET 6.0


## Dependencies
- **ReCaptcha.Desktop.WPF:**
    - [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions), 7.0.1
    - [Microsoft.Web.WebView2](https://www.nuget.org/packages/Microsoft.Web.WebView2), 1.0.1901.177
- **ReCaptcha.Desktop.WinUI:**
    - [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions), 7.0.1
    - [Microsoft.Windows.SDK.BuildTools](https://www.nuget.org/packages/Microsoft.Windows.SDK.BuildTools), 10.0.22621.756
    - [Microsoft.WindowsAppSDK](https://www.nuget.org/packages/Microsoft.WindowsAppSDK), 1.3.230724000
- **ReCaptcha.Desktop.UWP:**
    - [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions), 7.0.1
    - [Microsoft.NETCore.UniversalWindowsPlatform](https://www.nuget.org/packages/Microsoft.NETCore.UniversalWindowsPlatform), 6.2.14
    - [Microsoft.UI.Xaml](https://www.nuget.org/packages/Microsoft.UI.Xaml), 2.8.5
    - [Microsoft.UI.Xaml](https://www.nuget.org/packages/System.Text.Json), 7.0.3
- **ReCaptcha.Desktop.WinForms:**
    - [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions), 7.0.1
    - [Microsoft.Web.WebView2](https://www.nuget.org/packages/Microsoft.Web.WebView2), 1.0.1901.177