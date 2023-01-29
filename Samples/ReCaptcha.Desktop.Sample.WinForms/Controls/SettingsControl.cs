﻿namespace ReCaptcha.Desktop.Sample.WinForms.Controls;

public partial class SettingsControl : UserControl
{
    public SettingsControl()
    {
        InitializeComponent();

        ContentLayoutPanel.VerticalScroll.Value = 1;

        HttpUrlContent.DataBindings.Add(new("Text", Program.Configuration, "HttpUrl"));
        HttpPortContent.DataBindings.Add(new("Value", Program.Configuration, "HttpPort"));
        SiteKeyContent.DataBindings.Add(new("Text", Program.Configuration, "SiteKey"));
        LanguageContent.DataBindings.Add(new("Text", Program.Configuration, "Language"));
        TokenRecievedHtmlContent.DataBindings.Add(new("Text", Program.Configuration, "TokenRecievedHtml"));
        TokenRecievedHookedHtmlContent.DataBindings.Add(new("Text", Program.Configuration, "TokenRecievedHookedHtml"));
        TitleContent.DataBindings.Add(new("Text", Program.Configuration, "Title"));
        IconContent.DataBindings.Add(new("Text", Program.Configuration, "Icon"));
        StartupLocationContent.DataSource = Enum.GetValues(typeof(FormStartPosition));
        StartupLocationContent.DataBindings.Add(new("SelectedItem", Program.Configuration, "StartupLocation"));
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