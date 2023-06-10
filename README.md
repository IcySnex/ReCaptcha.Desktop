# ReCaptcha.Desktop
Access Google reCAPTCHA on all major windows dekstop frameworks (WPF, WInUI, UWP, Winforms, Console)

| Across all frameworks | Fast & Reliable | Customizable |
|---|---|---|
| Use Google reCAPTCHA for all your projects with just a few lines of code, regardless of the desktop frameworks. | ReCaptcha.Desktop uses WebView2 and the official reCAPTCHA widget to bring you the best performance and stability. | From themes to fundamental components! ReCaptcha.Desktop allows you to customize just about anything. |

---

## Information
ReCaptcha.Desktop is an open source library to access Google's reCAPTCHA API on all majpr windows desktop frameworks including [WPF](https://learn.microsoft.com/en-us/dotnet/desktop/wpf), [WInUI3](https://learn.microsoft.com/en-us/windows/apps/winui/winui3/), [UWP](https://learn.microsoft.com/windows/uwp/), [WinForms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms) and Console. ReCaptcha.Desktop focuses on simplicity and stability, which means you can get started with just a few lines of code.

ReCaptcha.Desktop is fast and reliable. It uses Microsoft's official [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/) library on each specific plattform and the offical Google [reCAPTCHA widget/API](https://www.google.com/recaptcha/about/) to bring you the best performance and stability. Not only is ReCaptcha.Desktop fast but also highly customizable. You are able to change about anything - from themes to fundamental components like porting it to another plattform is very easy.

## How it works
Since Google does not officially support any .NET desktop framework, ReCaptcha.Desktop has to use a [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/) to display a custom reCAPTCHA widget hosted by a [HTTPListener](https://learn.microsoft.com/en-us/dotnet/api/system.net.httplistener).

You may be wondering why ReCaptcha.Desktop needs to host its own local server instead of just loading the HTML content into the [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/). This is because Google blocks all verifications run from an offline HTML file.

But don't worry, ReCaptcha.Desktop is still fast and the user doesn't see any of the fancy actions. A window appears only when manual user input is requested by Google.

## ReCaptcha control
WPF                                                |  WinUi3                                                |  UWP
:-------------------------------------------------:|:------------------------------------------------------:|:----------------------------------------------------:
![](/Documentation/docs/.vuepress/public/guide/widget/demo-wpf.png)  |  ![](/Documentation/docs/.vuepress/public/guide/widget/demo-winui3.png)  |  ![](/Documentation/docs/.vuepress/public/guide/widget/demo-uwp.png)
