namespace ReCaptcha.Desktop.Sample.WinForms.Controls;

public partial class HomeControl : UserControl
{
    public HomeControl()
    {
        InitializeComponent();
    }


    private void StartButton_Click(object sender, System.EventArgs e) =>
        Program.MainForm.Navigate(new CaptchaControl());
}