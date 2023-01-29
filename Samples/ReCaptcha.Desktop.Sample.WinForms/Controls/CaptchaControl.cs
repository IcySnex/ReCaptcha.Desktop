using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.Client.WinForms;

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
            "6LcMZR0UAAAAALgPMcgHwga7gY5p8QMg1Hj-bmUv".AsReCaptchaConfig(),
            "reCAPTCHA".AsWindowConfig());

        TokenBox.Text = await client.VerifyAsync();
    }
}