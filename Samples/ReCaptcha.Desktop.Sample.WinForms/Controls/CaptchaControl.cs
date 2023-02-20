using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.Client.WinForms;
using Microsoft.Extensions.Logging;

namespace ReCaptcha.Desktop.Sample.WinForms.Controls;

public partial class CaptchaControl : UserControl
{
    public CaptchaControl()
    {
        InitializeComponent();

        client = new(
        "6LcMZR0UAAAAALgPMcgHwga7gY5p8QMg1Hj-bmUv".AsReCaptchaConfig(
            language: "en"),
        "reCAPTCHA".AsFormConfig(
            icon: new("D:\\Personal\\Coding\\ReCaptcha.Desktop\\Samples\\ReCaptcha.Desktop.Sample.WinUI\\Icon.ico"),
            startPosition: FormStartPosition.CenterParent,
            showAsDialog: true,
            parent: ParentForm),
        Program.LoggerFactory.CreateLogger<ReCaptchaClient>());
    }

    ReCaptchaClient client;

    private async void VerifyButton_Click(object sender, System.EventArgs e)
    {

        try
        {
            TokenBox.Text = await client.VerifyAsync();
        }
        catch (Exception ex)
        {
            TokenBox.Text = ex.Message;
        }
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
        client = new(
        "6LcMZR0UAAAAALgPMcgHwga7gY5p8QMg1Hj-bmUv".AsReCaptchaConfig(
            language: "de"),
        "AAAAAAAAAA".AsFormConfig(
            startPosition: FormStartPosition.CenterScreen,
            showAsDialog: true,
            parent: ParentForm),
        Program.LoggerFactory.CreateLogger<ReCaptchaClient>());
    }
}