using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.Client.WinForms;
using Microsoft.Extensions.Logging;

namespace ReCaptcha.Desktop.Sample.WinForms.Controls;

public partial class CaptchaControl : UserControl
{
    public CaptchaControl()
    {
        InitializeComponent();
    }


    private async void VerifyButton_Click(object sender, System.EventArgs e)
    {
        ReCaptchaClient client = new(
            "6LcMZR0UAAAAALgPMcgHwga7gY5p8QMg1Hj-bmUv".AsReCaptchaConfig(
                language: "en"),
            "reCAPTCHA".AsWindowConfig(
                icon: new("D:\\Personal\\Coding\\ReCaptcha.Desktop\\Samples\\ReCaptcha.Desktop.Sample.WinUI\\Icon.ico"),
                startupLocation: FormStartPosition.CenterParent,
                showAsDialog: true,
                owner: ParentForm),
            Program.LoggerFactory.CreateLogger<ReCaptchaClient>());

        try
        {
            TokenBox.Text = await client.VerifyAsync();
        }
        catch (Exception ex)
        {
            TokenBox.Text = ex.Message;
        }
    }
}