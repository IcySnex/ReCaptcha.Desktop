# Getting Started

## Prerequisites
- [.NET CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/) or IDE with [NuGet Package Manager](https://www.nuget.org/)
- Project using [WPF](https://learn.microsoft.com/en-us/dotnet/desktop/wpf) or [WinUI3](https://learn.microsoft.com/en-us/windows/apps/winui/winui3/) or [UWP](https://learn.microsoft.com/windows/uwp/) or [WinForms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms) or Console
- A Google reCAPTCHA site key


## Installation (.NET CLI)
This section will show you how to install ReCaptcha.Desktop with the [.NET CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/).

- **Step 1:** Install base package (ReCaptcha.Desktop)
```powershell
dotnet add <PROJECT> package ReCaptcha.Desktop
```


## Console
This section will explain how to use ReCaptcha.Desktop without any UI framework.

- **Step 1:** Import ReCaptcha.Desktop dependencies
```cs
using ReCaptcha.Desktop.Client.Base;
using ReCaptcha.Desktop.Client.Interfaces;
using ReCaptcha.Desktop.Configuration;
```

- **Step 2:** Create ReCaptcha [configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop/configuration/recaptchaconfig.html) & [base](/ReCaptcha.Desktop/reference/recaptcha.desktop/client/interfaces/irecaptchabase.html)
```cs
ReCaptchaConfig config = new("SITE_KEY");
IRecaptchaBase reCaptcha = new ReCaptchaBase(config);
```

- **Step 3:** Hook events _(Optional)_

The [`VerificationRecieved`](/ReCaptcha.Desktop/reference/recaptcha.desktop/client/interfaces/irecaptchabase.html#verificationrecieved) event gets fired when the ReCaptcha base successfully recieved a token.
```cs
reCaptcha.VerificationRecieved += (s, e) =>
    Console.WriteLine($"Verification recieved:\n\tToken: {e.Token}\n\tOccurred At: {e.OccurredAt}\n");
```

- **Step 4:** Create verify callback

Since we don't have an UI in a console application and therefore cannot display a popup, we simply open a new browser window and prompt the user to insert the token shown.
```cs
string verifyCallback(string hostUrl, CancellationToken cancellationToken)
{
    Process.Start(new ProcessStartInfo()
    {
        FileName = hostUrl,
        UseShellExecute = true,
        CreateNoWindow = true
    });

    Console.Write("Paste token here: ");
    string? token = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(token))
        throw new Exception("Invalid token");

    Console.Clear();
    return token;
}
```

- **Step 5:** Run `Verify` function
```cs
string token = reCaptcha.Verify(verifyCallback);
```


## WPF / WinUI3 / UWP / WinForms
This section will explain how to use ReCaptcha.Desktop with an UI framework.
Generally the library is used the same for all UI frameworks, but there are a few small adjustments to the respective framework, such as naming conventions or UI related properties.

- **Step 1:** Install UI package
```powershell
dotnet add <PROJECT> package ReCaptcha.Desktop.WPF # WPF
dotnet add <PROJECT> package ReCaptcha.Desktop.WinUI # WinUI3
dotnet add <PROJECT> package ReCaptcha.Desktop.UWP # UWP
dotnet add <PROJECT> package ReCaptcha.Desktop.WinForms # WinForms 
```

- **Step 2:** Import ReCaptcha.Desktop dependencies
```cs
using ReCaptcha.Desktop.Client.WPF; // WPF
using ReCaptcha.Desktop.Client.WinUI; // WinUI3
using ReCaptcha.Desktop.Client.UWP; // UWP
using ReCaptcha.Desktop.Client.WinForms; // WinForms 

using ReCaptcha.Desktop.Client.Interfaces;
using ReCaptcha.Desktop.Configuration;
```

- **Step 3:** Create ReCaptcha [configuration](/ReCaptcha.Desktop/reference/recaptcha.desktop/configuration/recaptchaconfig.html) , window configuration & [client](/ReCaptcha.Desktop/reference/recaptcha.desktop/client/interfaces/irecaptchaclient.html)
```cs
WindowConfig uiConfig = new("WINDOW_TITLE"); // WPF
WindowConfig uiConfig = new("WINDOW_TITLE"); // WinUI3
PopupConfig uiConfig = new("POPUP_TITLE"); // UWP
FormConfig uiConfig = new("FORM_TITLE"); // WinForms 

ReCaptchaConfig config = new("SITE_KEY");
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

Now that we have an UI framework, we don't need to create our own verify callback like in the Console sample - ReCaptcha.Desktop handles everything for us!
Running [`reCaptcha.VerifyAsync`](/ReCaptcha.Desktop/reference/recaptcha.desktop/client/interfaces/irecaptchaclient.html#verifyasync) will show a new window on WPF and WinUI3. On WinForms a new form will be shown. Since multi windowing is really limited in UWP a popup will be shown instead.
```cs
CancellationTokenSource cts = new(TimeSpan.FromMinutes(1));
string token = await reCaptcha.VerifyAsync(cts.Token);
```


## That's it!
As you can see this wasn't really difficult, was it?
Now we can start learning about advanced stuff like [configuring our ReCaptchaClient](/ReCaptcha.Desktop/guide/configurating.html) or widgets that look just like the original "I'm not a robot" widget.