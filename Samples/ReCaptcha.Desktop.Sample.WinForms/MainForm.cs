using ReCaptcha.Desktop.Sample.WinForms.Controls;
using System.Diagnostics;

namespace ReCaptcha.Desktop.Sample.WinForms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        Navigate(new HomeControl());
    }


    public void Navigate(Control control)
    {
        ContentPanel.Controls.Clear();
        ContentPanel.Controls.Add(control);

        Program.Logger.Information("[MainForm-Navigate] Navigated to control");
    }


    private void HomeButton_Click(object sender, System.EventArgs e) =>
        Navigate(new HomeControl());

    private void SettingsButton_Click(object sender, System.EventArgs e) =>
        Navigate(new SettingsControl());

    private void GitHubButton_Click(object sender, System.EventArgs e) =>
        Process.Start(new ProcessStartInfo()
        {
            FileName = "https://github.com/IcySnex/ReCaptcha.Desktop",
            UseShellExecute = true,
            CreateNoWindow = true
        });


    public Form? LoggerForm;

    private void LoggerButton_Click(object sender, System.EventArgs e)
    {
        if (LoggerForm is not null)
        {
            LoggerForm.Activate();
            return;
        }

        TextBox textBox = new()
        {
            Text = "Hello world",
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Both,
            Dock = DockStyle.Fill
        };

        Form form = new()
        {
            Text = "ReCaptcha.Desktop - WinForms Sample (Logger)",
            Width = 600,
            Height = 400,
        };
        form.Controls.Add(textBox);

        void handler(object? s, string e) =>
            textBox.Text += e;

        Program.Sink.OnNewLog += handler;
        form.Closed += (s, e) =>
        {
            Program.Sink.OnNewLog -= handler;
            LoggerForm = null;
        };

        LoggerForm = form;
        LoggerForm.Show();

        Program.Logger.Information("[MainForm-LoggerButton_Click] Created new LoggerForm and hooked handler");
    }
}