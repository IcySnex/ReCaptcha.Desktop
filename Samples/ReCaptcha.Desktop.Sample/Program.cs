using ReCaptcha.Desktop.Client;
using ReCaptcha.Desktop.Client.Interfaces;
using ReCaptcha.Desktop.Configuration;
using System.Diagnostics;

Console.WriteLine("This tool will allow you to get a Google reCAPTCHA token via a Google reCAPTCHA site key on any desktop .NET platform.");
Console.WriteLine("Press any key to start.");

Console.ReadKey();
Console.Clear();

Console.Write("Enter your Google reCAPTCHA site key: ");
string? siteKey = Console.ReadLine();
if (string.IsNullOrWhiteSpace(siteKey))
{
    Console.ForegroundColor = ConsoleColor.Red;
    throw new Exception("Invalid SiteKey");
}
Console.Clear();

Console.Write("Enter your preffered language: ");
string language = Console.ReadLine() is string languageInput && !string.IsNullOrWhiteSpace(languageInput) ? languageInput : "en";
Console.Clear();

Console.Write("Enter your token recieved HTML: ");
string tokenRecievedHtml = Console.ReadLine() is string tokenRecievedHtmlInput && !string.IsNullOrWhiteSpace(tokenRecievedHtmlInput) ? tokenRecievedHtmlInput : "Token recieved: %token%";
Console.Clear();

Console.Write("Enter your token recieved hooked HTML: ");
string tokenRecievedHookedHtml = Console.ReadLine() is string tokenRecievedHookedHtmlInput && !string.IsNullOrWhiteSpace(tokenRecievedHookedHtmlInput) ? tokenRecievedHookedHtmlInput : "Token recieved and sent to application.";
Console.Clear();

Console.Write("Enter your host url: ");
string url = Console.ReadLine() is string urlInput && !string.IsNullOrWhiteSpace(urlInput) ? urlInput : "http://localhost";
Console.Clear();

Console.Write("Enter your host port: ");
if (!int.TryParse(Console.ReadLine(), out int port))
    port = 5000;

ReCaptchaConfig config = new(siteKey, language, tokenRecievedHtml, tokenRecievedHookedHtml, new(url, port));
Console.WriteLine($"\nCreated new ReCaptchaConfig with:\n\tSiteKey: {config.SiteKey}\n\tLanguage: {config.Language}\n\tTokenRecievedHtml: {config.TokenRecievedHtml}\n\tTokenRecievedHookedHtml: {config.TokenRecievedHookedHtml}\n\tHttpConfiguration.Url: {config.HttpConfiguration.Url}\n\tHttpConfiguration.Port: {config.HttpConfiguration.Port}");

Console.WriteLine("\nPress any key to continue.");
Console.ReadKey();
Console.Clear();

ReCaptchaClient reCaptchaClient = IReCaptchaClient.New(config);

reCaptchaClient.VerificationRecieved += (s, e) =>
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\nToken Recieved:\n\tToken: {e.Token}\n\tOccurred At: {e.OccurredAt}\n");
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

Console.ResetColor();
Console.WriteLine("Press any key to exit.");
Console.ReadKey();