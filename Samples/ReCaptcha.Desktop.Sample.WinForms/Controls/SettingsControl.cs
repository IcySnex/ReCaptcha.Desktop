namespace ReCaptcha.Desktop.Sample.WinForms.Controls;

public partial class SettingsControl : UserControl
{
    public SettingsControl()
    {
        InitializeComponent();

        ContentLayoutPanel.VerticalScroll.Value = 1;

        SiteKeyContent.DataBindings.Add(new("Text", Program.Configuration, "SiteKey"));
        HostNameContent.DataBindings.Add(new("Text", Program.Configuration, "HostName"));
        LanguageContent.DataBindings.Add(new("Text", Program.Configuration, "Language"));
        TokenRecievedHtmlContent.DataBindings.Add(new("Text", Program.Configuration, "TokenRecievedHtml"));
        TokenRecievedHookedHtmlContent.DataBindings.Add(new("Text", Program.Configuration, "TokenRecievedHookedHtml"));
        TitleContent.DataBindings.Add(new("Text", Program.Configuration, "Title"));
        IconContent.DataBindings.Add(new("Text", Program.Configuration, "Icon"));
        StartPositionContent.DataSource = Enum.GetValues(typeof(FormStartPosition));
        StartPositionContent.DataBindings.Add(new("SelectedItem", Program.Configuration, "StartPosition"));
        LeftContent.DataBindings.Add(new("Value", Program.Configuration, "Left"));
        TopContent.DataBindings.Add(new("Value", Program.Configuration, "Top"));
        ShowAsDialogContent.DataBindings.Add(new("Checked", Program.Configuration, "ShowAsDialog"));
        TimeoutContent.DataBindings.Add(new("Text", this, "Timeout"));
        ShowHandlerMessagesContent.DataBindings.Add(new("Checked", Program.Configuration, "ShowHandlerMessages"));
    }

    public string Timeout
    {
        get => Program.Configuration.Timeout.ToString();
        set => Program.Configuration.Timeout = TimeSpan.Parse(value);
    }
}