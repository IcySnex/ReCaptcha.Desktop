# Introduction
ReCaptcha.Desktop is an open source library to access Google's reCAPTCHA API on all majpr windows desktop frameworks including [WPF](https://learn.microsoft.com/en-us/dotnet/desktop/wpf), [WInUI3](https://learn.microsoft.com/en-us/windows/apps/winui/winui3/), [UWP](https://learn.microsoft.com/windows/uwp/), [WinForms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms) and Console. ReCaptcha.Desktop focuses on simplicity and stability, which means you can get started with just a few lines of code.

ReCaptcha.Desktop is fast and reliable. It uses Microsoft's official [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/) library on each specific plattform and the offical Google [reCAPTCHA widget/API](https://www.google.com/recaptcha/about/) to bring you the best performance and stability. Not only is ReCaptcha.Desktop fast but also highly customizable. You are able to change about anything - from themes to fundamental components like porting it to another plattform is very easy.


## How it works
Since Google does not officially support any .NET desktop framework, ReCaptcha.Desktop has to use a [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/) to display a custom reCAPTCHA widget hosted by a [HTTPListener](https://learn.microsoft.com/en-us/dotnet/api/system.net.httplistener).

You may be wondering why ReCaptcha.Desktop needs to host its own local server instead of just loading the HTML content into the [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/). This is because Google blocks all verifications run from an offline HTML file.

But don't worry, ReCaptcha.Desktop is still fast and the user doesn't see any of the fancy actions. A window appears only when manual user input is requested by Google.


## Information
- **ReCaptcha.Desktop:** .NET Standard 2.0
- **ReCaptcha.Desktop.Tests:** .NET 6.0
- **ReCaptcha.Desktop.WPF:** .NET 6.0
- **ReCaptcha.Desktop.WinUI:** .NET 6.0
- **ReCaptcha.Desktop.UWP:** Target: Windows 11 (10.0; Build 22000) / Minimum: Windows 10, version 1809 (10.0; Build 17763)
- **ReCaptcha.Desktop.WinForms:** .NET 6.0
---
- **ReCaptcha.Desktop.Sample:** .NET 6.0
- **ReCaptcha.Desktop.WPF:** .NET 6.0
- **ReCaptcha.Desktop.WinUI:** .NET 6.0
- **ReCaptcha.Desktop.UWP.Sample:** Target: Windows 11 (10.0; Build 22000) / Minimum: Windows 10, version 1809 (10.0; Build 17763)
- **ReCaptcha.Desktop.WinForms:** .NET 6.0


## Dependencies
- **ReCaptcha.Desktop:**
    - [NETStandard.Library](https://www.nuget.org/packages/NETStandard.Library/), 2.0.3
    - [System.Text.Json](https://www.nuget.org/packages/System.Text.Json/), 7.01
- **ReCaptcha.Desktop.Tests:**
    - _ReCaptcha.Desktop_
    - [coverlet.collector](https://www.nuget.org/packages/coverlet.collector), 3.2.0
    - [Microsoft.NET.Test.Sdk](https://www.nuget.org/packages/Microsoft.NET.Test.Sdk), 17.4.1
    - [NUnit](https://www.nuget.org/packages/NUnit/), 3.13.3
    - [NUnit.Analyzers](https://www.nuget.org/packages/NUnit.Analyzers), 3.5.0
    - [NUnit3TestAdapter](https://www.nuget.org/packages/NUnit3TestAdapter), 4.3.1
- **ReCaptcha.Desktop.WPF:**
    - _ReCaptcha.Desktop_
    - [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions), 7.0.0
    - [Microsoft.Web.WebView2](https://www.nuget.org/packages/Microsoft.Web.WebView2), 1.0.1518.46
- **ReCaptcha.Desktop.WinUI:**
    - _ReCaptcha.Desktop_
    - [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions), 7.0.0
    - [Microsoft.Windows.SDK.BuildTools](https://www.nuget.org/packages/Microsoft.Windows.SDK.BuildTools), 10.0.22621.755
    - [Microsoft.WindowsAppSDK](https://www.nuget.org/packages/Microsoft.WindowsAppSDK), 1.2.230118.102
- **ReCaptcha.Desktop.UWP.Sample:**
    - _ReCaptcha.Desktop_
    - [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions), 7.0.0
    - [Microsoft.NETCore.UniversalWindowsPlatform](https://www.nuget.org/packages/Microsoft.NETCore.UniversalWindowsPlatform), 6.2.14
    - [Microsoft.UI.Xaml](https://www.nuget.org/packages/Microsoft.UI.Xaml), 2.8.2
- **ReCaptcha.Desktop.WinForms:**
    - _ReCaptcha.Desktop_
    - [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions), 7.0.0
    - [Microsoft.Web.WebView2](https://www.nuget.org/packages/Microsoft.Web.WebView2), 1.0.1518.46