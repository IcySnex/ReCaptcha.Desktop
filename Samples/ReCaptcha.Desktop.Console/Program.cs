using ReCaptcha.Desktop.Client.Interfaces;
using ReCaptcha.Desktop.Configuration;
using System.Diagnostics;

Console.WriteLine("Would you like to get help while creating a reCAPTCHA token?");
Console.WriteLine("Press y to get help.");

if (Console.ReadKey().Key == ConsoleKey.Y)
    VerifyWithHelp();
else
    VerifyWithoutHelp();

Console.ResetColor();
Console.WriteLine("Press any key to exit.");
Console.ReadKey();


void VerifyWithoutHelp()
{
    Console.Clear();

    Console.Write("Enter your Google reCAPTCHA site key: ");
    string? siteKey = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(siteKey))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        throw new Exception("Invalid SiteKey");
    }


    ReCaptchaConfig config = new(siteKey);
    Console.WriteLine($"\nCreated new ReCaptchaConfig with:\n\tSiteKey: {config.SiteKey}\n\tLanguage: {config.Language}\n\tTokenRecievedHtml: {config.TokenRecievedHtml}\n\tTokenRecievedHookedHtml: {config.TokenRecievedHookedHtml}\n\tHttpConfiguration.Url: {config.HttpConfiguration.Url}\n\tHttpConfiguration.Port: {config.HttpConfiguration.Port}");

    IReCaptchaClient reCaptchaClient = IReCaptchaClient.New(config);

    reCaptchaClient.VerificationRecieved += (s, e) =>
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nToken Recieved:\n\tToken: {e.Token}\n\tOccurred At: {e.OccurredAt}\n");
        Console.ResetColor();
    };
    reCaptchaClient.VerificationCancelled += (s, e) =>
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nToken Recieved:\n\tOccurred At: {e.OccurredAt}\n");
        Console.ResetColor();
    };

    string verifyCallback(
        string hostUrl,
        CancellationToken cancellationToken)
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
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new Exception("Invalid token");
        }

        Console.Clear();
        return token;
    }

    string token = reCaptchaClient.Verify(verifyCallback);
}

void VerifyWithHelp()
{
    Console.Clear();

    Console.WriteLine("This sample will show you how to use Google reCAPTCHA with a simple C# console application.");
    Console.WriteLine("You can always press any key to continue from now on!");

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("Alright so first of all we will need a 'ReCaptchaConfig' so we can get started.");
    Console.WriteLine("The configuration has a few options that we will explain now:");

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("SiteKey: This is your private SiteKey for the Google reCAPTCHA service");
    Console.WriteLine("If you dont have one you can obtain one here: https://www.google.com/recaptcha/admin/create");
    Console.Write("Enter your site key: ");
    string? siteKey = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(siteKey))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nThis is not a valid Google reCAPTCHA site key! Please validate your input and try again.");
        throw new Exception("Invalid SiteKey");
    }
    Console.Clear();

    Console.WriteLine("Language: This is the language in which the Google reCAPTCHA widget will get rendered in.");
    Console.WriteLine("The default is 'en' for english but you can enter any two letter language code.");
    Console.Write("Enter your preffered language: ");
    string language = Console.ReadLine() is string languageInput && !string.IsNullOrWhiteSpace(languageInput) ? languageInput : "en";
    Console.Clear();

    Console.WriteLine("TokenRecievedHtml: This is the HTML which gets displayed after the user verifed the reCAPTCHA.");
    Console.WriteLine("You can use '%token%' to embed the verified token inside the rendered HTML.");
    Console.WriteLine("You can leave this out if you want to use the default ('Token recieved: %token%')");
    Console.Write("Enter your token recieved HTML: ");
    string tokenRecievedHtml = Console.ReadLine() is string tokenRecievedHtmlInput && !string.IsNullOrWhiteSpace(tokenRecievedHtmlInput) ? tokenRecievedHtmlInput : "Token recieved: %token%";
    Console.Clear();

    Console.WriteLine("TokenRecievedHookedHtml: This is the HTML which gets displayed after the user verifed the reCAPTCHA AND the page is hooked to the application.");
    Console.WriteLine("This message wont load in your default browser. You have to hook a COM Interop object to the page, for example with a WebView2 in WPF. (This is not important for the Console Application.)");
    Console.WriteLine("You can use '%token%' to embed the verified token inside the rendered HTML like before but its not recomended.");
    Console.WriteLine("You can leave this out if you want to use the default ('Token recieved and sent to application.')");
    Console.Write("Enter your token recieved hooked HTML: ");
    string tokenRecievedHookedHtml = Console.ReadLine() is string tokenRecievedHookedHtmlInput && !string.IsNullOrWhiteSpace(tokenRecievedHookedHtmlInput) ? tokenRecievedHookedHtmlInput : "Token recieved and sent to application.";
    Console.Clear();

    Console.WriteLine("We could be done here but we can also specify a 'HttpServerConfig' to customize the HTTP server which is used in the background.");

    Console.WriteLine("\nHttpConfiguration.Url: This is the the url the server lives on.");
    Console.WriteLine("On your local machine this should always be the default ('http://localhost') but you can customize it to another local ip like '127.0.0.1'.");
    Console.Write("Enter your host url: ");
    string url = Console.ReadLine() is string urlInput && !string.IsNullOrWhiteSpace(urlInput) ? urlInput : "http://localhost";
    Console.Clear();

    Console.WriteLine("HttpConfiguration.Port: This is the port the server lives on.");
    Console.WriteLine("The default is '5000' but you can choose any valid HTTP port.");
    Console.Write("Enter your host url: ");
    if (!int.TryParse(Console.ReadLine(), out int port))
        port = 5000;
    Console.Clear();

    ReCaptchaConfig config = new(siteKey, language, tokenRecievedHtml, tokenRecievedHookedHtml, new(url, port));

    Console.Clear();
    Console.WriteLine("Great! Now we can create a new ReCaptchaClient with this configuration.");

    Console.ReadKey();
    Console.Clear();

    IReCaptchaClient reCaptchaClient = IReCaptchaClient.New(config);

    Console.WriteLine("Before we continue, lets register some events when our verifcation got recieved and when it got cancelled.");

    Console.ReadKey();
    Console.Clear();

    reCaptchaClient.VerificationRecieved += (s, e) =>
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nToken Recieved:\n\tToken: {e.Token}\n\tOccurred At: {e.OccurredAt}\n");
        Console.ResetColor();
    };
    reCaptchaClient.VerificationCancelled += (s, e) =>
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nToken Recieved:\n\tOccurred At: {e.OccurredAt}\n");
        Console.ResetColor();
    };

    Console.WriteLine("With this client we can access the 'Verify' method.");
    Console.WriteLine("This method starts and stops the HTTP server and calls a verify callback with the hosted url.");
    Console.WriteLine("The 'Verify' method has a few parameters:");

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("CancellationToken: This is the token to cancel this action");
    Console.WriteLine("We can specify a cancellation token if for example the user takes too long. But since we are in a console application and cant use an async callback this wont effect us.");

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("VerifyCallback: This is the callback which is used to verify the reCAPTCHA. Since we are not working with any UI framework this will be the bare minimum but you can create your own solutions with this project.");
    Console.WriteLine("So first our callback will be opening a new window where the user has to verify the reCAPTCHA (if google doenst do it automatically).\nAfter the reCAPTCHA is verified the passed HTML from the config will be displayed.\nNow your part:You have to copy this token back into the application and it will continue.");
    Console.WriteLine("\nAs you can see this is not a great user experience. But as mentioned before this will be automated in the UI framework packages with e.g WebView2 or you can even create your own solutions.");

    string verifyCallback(
        string hostUrl,
        CancellationToken cancellationToken)
    {
        Process.Start(new ProcessStartInfo()
        {
            FileName = hostUrl,
            UseShellExecute = true,
            CreateNoWindow = true
        });

        Console.WriteLine("The browser window should have opened now. Please verify the reCAPTCHA.");
        Console.Write("Paste the token here: ");
        string? token = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(token))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThis is not a valid reCAPTCHA token! Please validate your input and try again.");
            throw new Exception("Invalid token");
        }

        Console.Clear();
        return token;
    }

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("If youre ready we can call it now!");

    Console.ReadKey();
    Console.Clear();

    string token = reCaptchaClient.Verify(verifyCallback);
}