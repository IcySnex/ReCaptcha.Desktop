using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.Client.WinForms;
using Microsoft.Extensions.Logging;

namespace ReCaptcha.Desktop.Sample.WinForms.Controls;

public partial class CaptchaControl : UserControl
{
    readonly ILogger logger = Program.LoggerFactory.CreateLogger<CaptchaControl>();
    readonly ReCaptchaClient captchaClient = new(new(Program.Configuration.SiteKey), new(Program.Configuration.Title));

    public CaptchaControl()
    {
        InitializeComponent();

        HookHandlers();
    }


    CancellationTokenSource? cancelSource;

    void HookHandlers()
    {
        captchaClient.VerificationRecieved += (s, e) =>
        {
            logger.LogInformation("[CaptchaControl-VerificationRecieved] Verification was recieved\n\t Token: {token}...\n\tOccurred at: {occurred}", e.Token[..15], e.OccurredAt);

            if (Program.Configuration.ShowHandlerMessages)
                MessageBox.Show($"Token: {e.Token[..15]}...\nOccurred at: {e.OccurredAt}", "Verification was recieved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        captchaClient.VerificationCancelled += (s, e) =>
        {
            logger.LogInformation("[CaptchaControl-VerificationCancelled] Verification was cancelled\n\tOccurred at {occurred}", e.OccurredAt);

            if (Program.Configuration.ShowHandlerMessages)
                MessageBox.Show($"Occurred at {e.OccurredAt}", "Verification was cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        captchaClient.ReCaptchaResized += (s, e) =>
        {
            logger.LogInformation("[CaptchaControl-ReCaptchaResized] ReCaptcha was resized\n\tWidth: {width}\n\tHeight: {height}\n\tOccurred at: {occurred}", e.Width, e.Height, e.OccurredAt);

            if (Program.Configuration.ShowHandlerMessages)
                MessageBox.Show($"Width: {e.Width}\nHeight: {e.Height}\nOccurred at: {e.OccurredAt}", "ReCaptcha resized", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };
    }

    void UpdateConfigurations()
    {
        HttpServerConfig httpConfig = new(
            url: Program.Configuration.HttpUrl,
            port: Program.Configuration.HttpPort);
        ReCaptchaConfig reCaptchaConfig = new(
            siteKey: Program.Configuration.SiteKey,
            language: Program.Configuration.Language,
            tokenRecievedHtml: Program.Configuration.TokenRecievedHtml,
            tokenRecievedHookedHtml: Program.Configuration.TokenRecievedHookedHtml,
            httpConfiguration: httpConfig);

        FormConfig formConfig = new(
            title: Program.Configuration.Title,
            icon: new Icon(Program.Configuration.Icon),
            parent: ParentForm,
            startPosition: Program.Configuration.StartPosition,
            left: Program.Configuration.Left,
            top: Program.Configuration.Top,
            showAsDialog: Program.Configuration.ShowAsDialog);

        captchaClient.Configuration = reCaptchaConfig;
        captchaClient.FormConfiguration = formConfig;

        logger.LogInformation("[CaptchaControl-UpdateConfigurations] Updated client configuration and form configuration");
    }


    private async void VerifyButton_Click(object sender, System.EventArgs e)
    {
        // Disable verify button & set verify/cancel button text
        VerifyButton.Enabled = false;
        VerifyButton.Text = "Verifying...";
        CancelButton.Text = "Cancel";

        // Update configuration so ReCaptcha configs are equal to local settings
        UpdateConfigurations();

        try // Create a new cancel token and await verification
        {
            cancelSource = new(Program.Configuration.Timeout);
            TokenBox.Text = await captchaClient.VerifyAsync(cancelSource.Token);
        }
        catch (TaskCanceledException) // Task was cancelled by user or timed out: Reset token 
        {
            TokenBox.Text = "Press \"I'm not a robot\"!";
        }
        catch (Exception ex) // Error was thrown: Set error message 
        {
            TokenBox.Text = $"Exception was thrown: {ex.Message} - {ex.InnerException?.Message}";
        }
        finally // Enable verify button & set verify/cancel button text and reset cancel token
        {
            VerifyButton.Enabled = true;
            VerifyButton.Text = "I'm not a robot";
            CancelButton.Text = "Reset";
            cancelSource = null;
        }
    }

    private void CancelButton_Click(object sender, System.EventArgs e)
    {
        // Reset token & cancel verification if not already reset
        TokenBox.Text = "Press \"I'm not a robot\"!";
        cancelSource?.Cancel();

        // Enable verify button & set verify/cancel button text
        VerifyButton.Enabled = true;
        VerifyButton.Text = "I'm not a robot";
        CancelButton.Text = "Reset";
    }
}