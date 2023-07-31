# Getting Started

## Prerequisites
- [.NET CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/) or IDE with [NuGet Package Manager](https://www.nuget.org/)
- Project using [WPF](https://learn.microsoft.com/en-us/dotnet/desktop/wpf) or [WinUI3](https://learn.microsoft.com/en-us/windows/apps/winui/winui3/) or [UWP](https://learn.microsoft.com/windows/uwp/) or [WinForms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms)
- A Google reCAPTCHA site key


## Installation
This section will explain how to use ReCaptcha.Desktop with an UI framework.
Generally the library is used the same for all UI frameworks, but there are a few small adjustments to the respective framework, such as naming conventions or UI related properties.

- **Step 1:** Install ReCaptcha.Desktop package
```powershell
dotnet add <PROJECT> package ReCaptcha.Desktop.WPF # WPF
dotnet add <PROJECT> package ReCaptcha.Desktop.WinUI # WinUI3
dotnet add <PROJECT> package ReCaptcha.Desktop.UWP # UWP
dotnet add <PROJECT> package ReCaptcha.Desktop.WinForms # WinForms 
```

- **Step 2:** Import ReCaptcha.Desktop dependencies
```cs
// WPF
using ReCaptcha.Desktop.WPF.Client;
using ReCaptcha.Desktop.WPF.Client.Interfaces;
using ReCaptcha.Desktop.WPF.Configuration;
// WinUI
using ReCaptcha.Desktop.WinUI.Client;
using ReCaptcha.Desktop.WinUI.Client.Interfaces;
using ReCaptcha.Desktop.WinUI.Configuration;
// UWP
using ReCaptcha.Desktop.UWP.Client;
using ReCaptcha.Desktop.UWP.Client.Interfaces;
using ReCaptcha.Desktop.UWP.Configuration;
// WinForms
using ReCaptcha.Desktop.WinForms.Client;
using ReCaptcha.Desktop.WinForms.Client.Interfaces;
using ReCaptcha.Desktop.WinForms.Configuration;
```

- **Step 3:** Create ReCaptcha [configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.wpf/configuration/recaptchaconfig.html) , [window configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop.wpf/configuration/windowconfig.html) & [client](/ReCaptcha.Desktop/reference/recaptcha.desktop.wpf/client/interfaces/irecaptchaclient.html)
```cs
WindowConfig uiConfig = new("WINDOW_TITLE"); // WPF
WindowConfig uiConfig = new("WINDOW_TITLE"); // WinUI3
PopupConfig uiConfig = new("POPUP_TITLE"); // UWP
FormConfig uiConfig = new("FORM_TITLE"); // WinForms 

ReCaptchaConfig config = new("SITE_KEY", "HOST_NAME");
IReCaptchaClient reCaptcha = new ReCaptchaClient(config, uiConfig);
```

- **Step 4:** Hook [events](/ReCaptcha.Desktop/reference/recaptcha.desktop/client/interfaces/irecaptchaclient.html#verificationrecieved) _(Optional)_
```cs
reCaptcha.VerificationRecieved += (s, e) =>
    MessageBox.Show($"Token: {e.Token}\nOccurred At: {e.OccurredAt}", "Verification recieved");

reCaptcha.VerificationCancelled += (s, e) =>
    MessageBox.Show($"Occurred At: {e.OccurredAt}", "Verification cancelled");
```

- **Step 4:** Run verification

Running [`reCaptcha.VerifyAsync`](/ReCaptcha.Desktop/reference/recaptcha.desktop.wpf/client/interfaces/irecaptchaclient.html#verifyasync) will show a new window on WPF and WinUI3. On WinForms a new form will be shown. Since multi windowing is really limited in UWP a popup will be shown instead.
```cs
CancellationTokenSource cts = new(TimeSpan.FromMinutes(1));
string token = await reCaptcha.VerifyAsync(cts.Token);
```


## That's it!
As you can see this wasn't really difficult, was it?
Now we can start learning about advanced stuff like [configuring our ReCaptchaClient](/ReCaptcha.Desktop/guide/configurating.html) or widgets that look just like the original "I'm not a robot" widget.