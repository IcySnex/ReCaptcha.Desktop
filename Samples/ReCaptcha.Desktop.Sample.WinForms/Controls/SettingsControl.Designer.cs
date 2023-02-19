namespace ReCaptcha.Desktop.Sample.WinForms.Controls
{
    partial class SettingsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.DividerPanel = new System.Windows.Forms.Panel();
            this.ContentLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HttpUrlPanel = new System.Windows.Forms.Panel();
            this.HttpUrlContent = new System.Windows.Forms.TextBox();
            this.HttpUrlDescription = new System.Windows.Forms.Label();
            this.HttpUrlTitle = new System.Windows.Forms.Label();
            this.HttpPortPanel = new System.Windows.Forms.Panel();
            this.HttpPortDescription = new System.Windows.Forms.Label();
            this.HttpPortContent = new System.Windows.Forms.NumericUpDown();
            this.HttpPortTitle = new System.Windows.Forms.Label();
            this.SiteKeyPanel = new System.Windows.Forms.Panel();
            this.SiteKeyDescription = new System.Windows.Forms.Label();
            this.SiteKeyTitle = new System.Windows.Forms.Label();
            this.SiteKeyContent = new System.Windows.Forms.TextBox();
            this.LanguagePanel = new System.Windows.Forms.Panel();
            this.LanguageDescription = new System.Windows.Forms.Label();
            this.LanguageTitle = new System.Windows.Forms.Label();
            this.LanguageContent = new System.Windows.Forms.TextBox();
            this.TokenRecievedHtmlPanel = new System.Windows.Forms.Panel();
            this.TokenRecievedHtmlDescription = new System.Windows.Forms.Label();
            this.TokenRecievedHtmlTitle = new System.Windows.Forms.Label();
            this.TokenRecievedHtmlContent = new System.Windows.Forms.TextBox();
            this.TokenRecievedHookedHtmlPanel = new System.Windows.Forms.Panel();
            this.TokenRecievedHookedHtmlTitle = new System.Windows.Forms.Label();
            this.TokenRecievedHookedHtmlContent = new System.Windows.Forms.TextBox();
            this.TokenRecievedHookedHtmlDescription = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleTitle = new System.Windows.Forms.Label();
            this.TitleContent = new System.Windows.Forms.TextBox();
            this.TitleDescription = new System.Windows.Forms.Label();
            this.IconPanel = new System.Windows.Forms.Panel();
            this.IconTitle = new System.Windows.Forms.Label();
            this.IconContent = new System.Windows.Forms.TextBox();
            this.IconDescription = new System.Windows.Forms.Label();
            this.StartupLocationPanel = new System.Windows.Forms.Panel();
            this.StartupLocationTitle = new System.Windows.Forms.Label();
            this.StartupLocationDescription = new System.Windows.Forms.Label();
            this.StartupLocationContent = new System.Windows.Forms.ComboBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftDescription = new System.Windows.Forms.Label();
            this.LeftContent = new System.Windows.Forms.NumericUpDown();
            this.LeftTitle = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.RightDescription = new System.Windows.Forms.Label();
            this.TopContent = new System.Windows.Forms.NumericUpDown();
            this.TopTitle = new System.Windows.Forms.Label();
            this.ShowAsDialogpanel = new System.Windows.Forms.Panel();
            this.ShowAsDialogContent = new System.Windows.Forms.CheckBox();
            this.ShowAsDialogDescription = new System.Windows.Forms.Label();
            this.ShowAsDialogTitle = new System.Windows.Forms.Label();
            this.TimeoutPanel = new System.Windows.Forms.Panel();
            this.TimeoutContent = new System.Windows.Forms.MaskedTextBox();
            this.TimeoutDescription = new System.Windows.Forms.Label();
            this.TimeoutTitle = new System.Windows.Forms.Label();
            this.ShowHandlerMessagesPanel = new System.Windows.Forms.Panel();
            this.ShowHandlerMessagesContent = new System.Windows.Forms.CheckBox();
            this.ShowHandlerMessagesDescription = new System.Windows.Forms.Label();
            this.ShowHandlerMessagesTitle = new System.Windows.Forms.Label();
            this.ContentLayoutPanel.SuspendLayout();
            this.HttpUrlPanel.SuspendLayout();
            this.HttpPortPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HttpPortContent)).BeginInit();
            this.SiteKeyPanel.SuspendLayout();
            this.LanguagePanel.SuspendLayout();
            this.TokenRecievedHtmlPanel.SuspendLayout();
            this.TokenRecievedHookedHtmlPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.IconPanel.SuspendLayout();
            this.StartupLocationPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftContent)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopContent)).BeginInit();
            this.ShowAsDialogpanel.SuspendLayout();
            this.TimeoutPanel.SuspendLayout();
            this.ShowHandlerMessagesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SettingsLabel.Location = new System.Drawing.Point(12, 12);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(108, 35);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Settings";
            // 
            // DividerPanel
            // 
            this.DividerPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DividerPanel.Location = new System.Drawing.Point(12, 52);
            this.DividerPanel.Name = "DividerPanel";
            this.DividerPanel.Size = new System.Drawing.Size(860, 2);
            this.DividerPanel.TabIndex = 1;
            // 
            // ContentLayoutPanel
            // 
            this.ContentLayoutPanel.AutoScroll = true;
            this.ContentLayoutPanel.Controls.Add(this.HttpUrlPanel);
            this.ContentLayoutPanel.Controls.Add(this.HttpPortPanel);
            this.ContentLayoutPanel.Controls.Add(this.SiteKeyPanel);
            this.ContentLayoutPanel.Controls.Add(this.LanguagePanel);
            this.ContentLayoutPanel.Controls.Add(this.TokenRecievedHtmlPanel);
            this.ContentLayoutPanel.Controls.Add(this.TokenRecievedHookedHtmlPanel);
            this.ContentLayoutPanel.Controls.Add(this.TitlePanel);
            this.ContentLayoutPanel.Controls.Add(this.IconPanel);
            this.ContentLayoutPanel.Controls.Add(this.StartupLocationPanel);
            this.ContentLayoutPanel.Controls.Add(this.LeftPanel);
            this.ContentLayoutPanel.Controls.Add(this.TopPanel);
            this.ContentLayoutPanel.Controls.Add(this.ShowAsDialogpanel);
            this.ContentLayoutPanel.Controls.Add(this.TimeoutPanel);
            this.ContentLayoutPanel.Controls.Add(this.ShowHandlerMessagesPanel);
            this.ContentLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContentLayoutPanel.Location = new System.Drawing.Point(12, 72);
            this.ContentLayoutPanel.Name = "ContentLayoutPanel";
            this.ContentLayoutPanel.Size = new System.Drawing.Size(872, 344);
            this.ContentLayoutPanel.TabIndex = 2;
            this.ContentLayoutPanel.WrapContents = false;
            // 
            // HttpUrlPanel
            // 
            this.HttpUrlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HttpUrlPanel.Controls.Add(this.HttpUrlContent);
            this.HttpUrlPanel.Controls.Add(this.HttpUrlDescription);
            this.HttpUrlPanel.Controls.Add(this.HttpUrlTitle);
            this.HttpUrlPanel.Location = new System.Drawing.Point(3, 3);
            this.HttpUrlPanel.Name = "HttpUrlPanel";
            this.HttpUrlPanel.Size = new System.Drawing.Size(840, 66);
            this.HttpUrlPanel.TabIndex = 0;
            // 
            // HttpUrlContent
            // 
            this.HttpUrlContent.Location = new System.Drawing.Point(567, 22);
            this.HttpUrlContent.Name = "HttpUrlContent";
            this.HttpUrlContent.PlaceholderText = "http://localhost";
            this.HttpUrlContent.Size = new System.Drawing.Size(256, 23);
            this.HttpUrlContent.TabIndex = 5;
            // 
            // HttpUrlDescription
            // 
            this.HttpUrlDescription.AutoSize = true;
            this.HttpUrlDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HttpUrlDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HttpUrlDescription.Location = new System.Drawing.Point(15, 35);
            this.HttpUrlDescription.Name = "HttpUrlDescription";
            this.HttpUrlDescription.Size = new System.Drawing.Size(176, 20);
            this.HttpUrlDescription.TabIndex = 4;
            this.HttpUrlDescription.Text = "The url the server lives on";
            // 
            // HttpUrlTitle
            // 
            this.HttpUrlTitle.AutoSize = true;
            this.HttpUrlTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HttpUrlTitle.Location = new System.Drawing.Point(12, 12);
            this.HttpUrlTitle.Name = "HttpUrlTitle";
            this.HttpUrlTitle.Size = new System.Drawing.Size(73, 25);
            this.HttpUrlTitle.TabIndex = 3;
            this.HttpUrlTitle.Text = "HttpUrl";
            // 
            // HttpPortPanel
            // 
            this.HttpPortPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HttpPortPanel.Controls.Add(this.HttpPortDescription);
            this.HttpPortPanel.Controls.Add(this.HttpPortContent);
            this.HttpPortPanel.Controls.Add(this.HttpPortTitle);
            this.HttpPortPanel.Location = new System.Drawing.Point(3, 75);
            this.HttpPortPanel.Name = "HttpPortPanel";
            this.HttpPortPanel.Size = new System.Drawing.Size(840, 66);
            this.HttpPortPanel.TabIndex = 1;
            // 
            // HttpPortDescription
            // 
            this.HttpPortDescription.AutoSize = true;
            this.HttpPortDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HttpPortDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HttpPortDescription.Location = new System.Drawing.Point(15, 35);
            this.HttpPortDescription.Name = "HttpPortDescription";
            this.HttpPortDescription.Size = new System.Drawing.Size(176, 20);
            this.HttpPortDescription.TabIndex = 4;
            this.HttpPortDescription.Text = "The url the server lives on";
            // 
            // HttpPortContent
            // 
            this.HttpPortContent.Location = new System.Drawing.Point(703, 22);
            this.HttpPortContent.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.HttpPortContent.Name = "HttpPortContent";
            this.HttpPortContent.Size = new System.Drawing.Size(120, 23);
            this.HttpPortContent.TabIndex = 2;
            // 
            // HttpPortTitle
            // 
            this.HttpPortTitle.AutoSize = true;
            this.HttpPortTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HttpPortTitle.Location = new System.Drawing.Point(12, 12);
            this.HttpPortTitle.Name = "HttpPortTitle";
            this.HttpPortTitle.Size = new System.Drawing.Size(82, 25);
            this.HttpPortTitle.TabIndex = 3;
            this.HttpPortTitle.Text = "HttpPort";
            // 
            // SiteKeyPanel
            // 
            this.SiteKeyPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SiteKeyPanel.Controls.Add(this.SiteKeyDescription);
            this.SiteKeyPanel.Controls.Add(this.SiteKeyTitle);
            this.SiteKeyPanel.Controls.Add(this.SiteKeyContent);
            this.SiteKeyPanel.Location = new System.Drawing.Point(3, 147);
            this.SiteKeyPanel.Name = "SiteKeyPanel";
            this.SiteKeyPanel.Size = new System.Drawing.Size(840, 66);
            this.SiteKeyPanel.TabIndex = 5;
            // 
            // SiteKeyDescription
            // 
            this.SiteKeyDescription.AutoSize = true;
            this.SiteKeyDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SiteKeyDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SiteKeyDescription.Location = new System.Drawing.Point(15, 35);
            this.SiteKeyDescription.Name = "SiteKeyDescription";
            this.SiteKeyDescription.Size = new System.Drawing.Size(317, 20);
            this.SiteKeyDescription.TabIndex = 4;
            this.SiteKeyDescription.Text = "The SiteKey for the Google reCAPTCHA service";
            // 
            // SiteKeyTitle
            // 
            this.SiteKeyTitle.AutoSize = true;
            this.SiteKeyTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SiteKeyTitle.Location = new System.Drawing.Point(12, 12);
            this.SiteKeyTitle.Name = "SiteKeyTitle";
            this.SiteKeyTitle.Size = new System.Drawing.Size(73, 25);
            this.SiteKeyTitle.TabIndex = 3;
            this.SiteKeyTitle.Text = "SiteKey";
            // 
            // SiteKeyContent
            // 
            this.SiteKeyContent.Location = new System.Drawing.Point(567, 22);
            this.SiteKeyContent.Name = "SiteKeyContent";
            this.SiteKeyContent.Size = new System.Drawing.Size(256, 23);
            this.SiteKeyContent.TabIndex = 6;
            // 
            // LanguagePanel
            // 
            this.LanguagePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LanguagePanel.Controls.Add(this.LanguageDescription);
            this.LanguagePanel.Controls.Add(this.LanguageTitle);
            this.LanguagePanel.Controls.Add(this.LanguageContent);
            this.LanguagePanel.Location = new System.Drawing.Point(3, 219);
            this.LanguagePanel.Name = "LanguagePanel";
            this.LanguagePanel.Size = new System.Drawing.Size(840, 66);
            this.LanguagePanel.TabIndex = 6;
            // 
            // LanguageDescription
            // 
            this.LanguageDescription.AutoSize = true;
            this.LanguageDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LanguageDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LanguageDescription.Location = new System.Drawing.Point(15, 35);
            this.LanguageDescription.Name = "LanguageDescription";
            this.LanguageDescription.Size = new System.Drawing.Size(330, 20);
            this.LanguageDescription.TabIndex = 4;
            this.LanguageDescription.Text = "The language for the Google reCAPTCHA service";
            // 
            // LanguageTitle
            // 
            this.LanguageTitle.AutoSize = true;
            this.LanguageTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LanguageTitle.Location = new System.Drawing.Point(12, 12);
            this.LanguageTitle.Name = "LanguageTitle";
            this.LanguageTitle.Size = new System.Drawing.Size(95, 25);
            this.LanguageTitle.TabIndex = 3;
            this.LanguageTitle.Text = "Language";
            // 
            // LanguageContent
            // 
            this.LanguageContent.Location = new System.Drawing.Point(703, 22);
            this.LanguageContent.Name = "LanguageContent";
            this.LanguageContent.PlaceholderText = "en";
            this.LanguageContent.Size = new System.Drawing.Size(120, 23);
            this.LanguageContent.TabIndex = 6;
            // 
            // TokenRecievedHtmlPanel
            // 
            this.TokenRecievedHtmlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TokenRecievedHtmlPanel.Controls.Add(this.TokenRecievedHtmlDescription);
            this.TokenRecievedHtmlPanel.Controls.Add(this.TokenRecievedHtmlTitle);
            this.TokenRecievedHtmlPanel.Controls.Add(this.TokenRecievedHtmlContent);
            this.TokenRecievedHtmlPanel.Location = new System.Drawing.Point(3, 291);
            this.TokenRecievedHtmlPanel.Name = "TokenRecievedHtmlPanel";
            this.TokenRecievedHtmlPanel.Size = new System.Drawing.Size(840, 66);
            this.TokenRecievedHtmlPanel.TabIndex = 7;
            // 
            // TokenRecievedHtmlDescription
            // 
            this.TokenRecievedHtmlDescription.AutoSize = true;
            this.TokenRecievedHtmlDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TokenRecievedHtmlDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TokenRecievedHtmlDescription.Location = new System.Drawing.Point(15, 35);
            this.TokenRecievedHtmlDescription.Name = "TokenRecievedHtmlDescription";
            this.TokenRecievedHtmlDescription.Size = new System.Drawing.Size(465, 20);
            this.TokenRecievedHtmlDescription.TabIndex = 4;
            this.TokenRecievedHtmlDescription.Text = "The HTML which gets displayed after the user verifed the reCAPTCHA";
            // 
            // TokenRecievedHtmlTitle
            // 
            this.TokenRecievedHtmlTitle.AutoSize = true;
            this.TokenRecievedHtmlTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TokenRecievedHtmlTitle.Location = new System.Drawing.Point(12, 12);
            this.TokenRecievedHtmlTitle.Name = "TokenRecievedHtmlTitle";
            this.TokenRecievedHtmlTitle.Size = new System.Drawing.Size(175, 25);
            this.TokenRecievedHtmlTitle.TabIndex = 3;
            this.TokenRecievedHtmlTitle.Text = "TokenRecievedHtml";
            // 
            // TokenRecievedHtmlContent
            // 
            this.TokenRecievedHtmlContent.Location = new System.Drawing.Point(567, 22);
            this.TokenRecievedHtmlContent.Name = "TokenRecievedHtmlContent";
            this.TokenRecievedHtmlContent.PlaceholderText = "Token recieved: %token%";
            this.TokenRecievedHtmlContent.Size = new System.Drawing.Size(256, 23);
            this.TokenRecievedHtmlContent.TabIndex = 6;
            // 
            // TokenRecievedHookedHtmlPanel
            // 
            this.TokenRecievedHookedHtmlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TokenRecievedHookedHtmlPanel.Controls.Add(this.TokenRecievedHookedHtmlTitle);
            this.TokenRecievedHookedHtmlPanel.Controls.Add(this.TokenRecievedHookedHtmlContent);
            this.TokenRecievedHookedHtmlPanel.Controls.Add(this.TokenRecievedHookedHtmlDescription);
            this.TokenRecievedHookedHtmlPanel.Location = new System.Drawing.Point(3, 363);
            this.TokenRecievedHookedHtmlPanel.Name = "TokenRecievedHookedHtmlPanel";
            this.TokenRecievedHookedHtmlPanel.Size = new System.Drawing.Size(840, 66);
            this.TokenRecievedHookedHtmlPanel.TabIndex = 8;
            // 
            // TokenRecievedHookedHtmlTitle
            // 
            this.TokenRecievedHookedHtmlTitle.AutoSize = true;
            this.TokenRecievedHookedHtmlTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TokenRecievedHookedHtmlTitle.Location = new System.Drawing.Point(12, 12);
            this.TokenRecievedHookedHtmlTitle.Name = "TokenRecievedHookedHtmlTitle";
            this.TokenRecievedHookedHtmlTitle.Size = new System.Drawing.Size(240, 25);
            this.TokenRecievedHookedHtmlTitle.TabIndex = 3;
            this.TokenRecievedHookedHtmlTitle.Text = "TokenRecievedHookedHtml";
            // 
            // TokenRecievedHookedHtmlContent
            // 
            this.TokenRecievedHookedHtmlContent.Location = new System.Drawing.Point(567, 22);
            this.TokenRecievedHookedHtmlContent.Name = "TokenRecievedHookedHtmlContent";
            this.TokenRecievedHookedHtmlContent.PlaceholderText = "Token recieved and sent to application.";
            this.TokenRecievedHookedHtmlContent.Size = new System.Drawing.Size(256, 23);
            this.TokenRecievedHookedHtmlContent.TabIndex = 6;
            // 
            // TokenRecievedHookedHtmlDescription
            // 
            this.TokenRecievedHookedHtmlDescription.AutoSize = true;
            this.TokenRecievedHookedHtmlDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TokenRecievedHookedHtmlDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TokenRecievedHookedHtmlDescription.Location = new System.Drawing.Point(15, 35);
            this.TokenRecievedHookedHtmlDescription.Name = "TokenRecievedHookedHtmlDescription";
            this.TokenRecievedHookedHtmlDescription.Size = new System.Drawing.Size(689, 20);
            this.TokenRecievedHookedHtmlDescription.TabIndex = 4;
            this.TokenRecievedHookedHtmlDescription.Text = "The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked" +
    " to the application";
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TitlePanel.Controls.Add(this.TitleTitle);
            this.TitlePanel.Controls.Add(this.TitleContent);
            this.TitlePanel.Controls.Add(this.TitleDescription);
            this.TitlePanel.Location = new System.Drawing.Point(3, 435);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(840, 66);
            this.TitlePanel.TabIndex = 9;
            // 
            // TitleTitle
            // 
            this.TitleTitle.AutoSize = true;
            this.TitleTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleTitle.Location = new System.Drawing.Point(12, 12);
            this.TitleTitle.Name = "TitleTitle";
            this.TitleTitle.Size = new System.Drawing.Size(48, 25);
            this.TitleTitle.TabIndex = 3;
            this.TitleTitle.Text = "Title";
            // 
            // TitleContent
            // 
            this.TitleContent.Location = new System.Drawing.Point(567, 22);
            this.TitleContent.Name = "TitleContent";
            this.TitleContent.PlaceholderText = "WinForms Sample - Google reCAPTCHA";
            this.TitleContent.Size = new System.Drawing.Size(256, 23);
            this.TitleContent.TabIndex = 6;
            // 
            // TitleDescription
            // 
            this.TitleDescription.AutoSize = true;
            this.TitleDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleDescription.Location = new System.Drawing.Point(15, 35);
            this.TitleDescription.Name = "TitleDescription";
            this.TitleDescription.Size = new System.Drawing.Size(162, 20);
            this.TitleDescription.TabIndex = 4;
            this.TitleDescription.Text = "The title of the window";
            // 
            // IconPanel
            // 
            this.IconPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IconPanel.Controls.Add(this.IconTitle);
            this.IconPanel.Controls.Add(this.IconContent);
            this.IconPanel.Controls.Add(this.IconDescription);
            this.IconPanel.Location = new System.Drawing.Point(3, 507);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(840, 66);
            this.IconPanel.TabIndex = 10;
            // 
            // IconTitle
            // 
            this.IconTitle.AutoSize = true;
            this.IconTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IconTitle.Location = new System.Drawing.Point(12, 12);
            this.IconTitle.Name = "IconTitle";
            this.IconTitle.Size = new System.Drawing.Size(48, 25);
            this.IconTitle.TabIndex = 3;
            this.IconTitle.Text = "Icon";
            // 
            // IconContent
            // 
            this.IconContent.Location = new System.Drawing.Point(567, 22);
            this.IconContent.Name = "IconContent";
            this.IconContent.PlaceholderText = "Icon.ico";
            this.IconContent.Size = new System.Drawing.Size(256, 23);
            this.IconContent.TabIndex = 6;
            // 
            // IconDescription
            // 
            this.IconDescription.AutoSize = true;
            this.IconDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IconDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IconDescription.Location = new System.Drawing.Point(15, 35);
            this.IconDescription.Name = "IconDescription";
            this.IconDescription.Size = new System.Drawing.Size(164, 20);
            this.IconDescription.TabIndex = 4;
            this.IconDescription.Text = "The icon of the window";
            // 
            // StartupLocationPanel
            // 
            this.StartupLocationPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartupLocationPanel.Controls.Add(this.StartupLocationTitle);
            this.StartupLocationPanel.Controls.Add(this.StartupLocationDescription);
            this.StartupLocationPanel.Controls.Add(this.StartupLocationContent);
            this.StartupLocationPanel.Location = new System.Drawing.Point(3, 579);
            this.StartupLocationPanel.Name = "StartupLocationPanel";
            this.StartupLocationPanel.Size = new System.Drawing.Size(840, 66);
            this.StartupLocationPanel.TabIndex = 11;
            // 
            // StartupLocationTitle
            // 
            this.StartupLocationTitle.AutoSize = true;
            this.StartupLocationTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartupLocationTitle.Location = new System.Drawing.Point(12, 12);
            this.StartupLocationTitle.Name = "StartupLocationTitle";
            this.StartupLocationTitle.Size = new System.Drawing.Size(144, 25);
            this.StartupLocationTitle.TabIndex = 3;
            this.StartupLocationTitle.Text = "StartupLocation";
            // 
            // StartupLocationDescription
            // 
            this.StartupLocationDescription.AutoSize = true;
            this.StartupLocationDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartupLocationDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartupLocationDescription.Location = new System.Drawing.Point(15, 35);
            this.StartupLocationDescription.Name = "StartupLocationDescription";
            this.StartupLocationDescription.Size = new System.Drawing.Size(236, 20);
            this.StartupLocationDescription.TabIndex = 4;
            this.StartupLocationDescription.Text = "The startup postion of the window";
            // 
            // StartupLocationContent
            // 
            this.StartupLocationContent.FormattingEnabled = true;
            this.StartupLocationContent.Location = new System.Drawing.Point(567, 22);
            this.StartupLocationContent.Name = "StartupLocationContent";
            this.StartupLocationContent.Size = new System.Drawing.Size(256, 23);
            this.StartupLocationContent.TabIndex = 7;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LeftPanel.Controls.Add(this.LeftDescription);
            this.LeftPanel.Controls.Add(this.LeftContent);
            this.LeftPanel.Controls.Add(this.LeftTitle);
            this.LeftPanel.Location = new System.Drawing.Point(3, 651);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(840, 66);
            this.LeftPanel.TabIndex = 12;
            // 
            // LeftDescription
            // 
            this.LeftDescription.AutoSize = true;
            this.LeftDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeftDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LeftDescription.Location = new System.Drawing.Point(15, 35);
            this.LeftDescription.Name = "LeftDescription";
            this.LeftDescription.Size = new System.Drawing.Size(216, 20);
            this.LeftDescription.TabIndex = 4;
            this.LeftDescription.Text = "The left position of the window";
            // 
            // LeftContent
            // 
            this.LeftContent.Location = new System.Drawing.Point(703, 22);
            this.LeftContent.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.LeftContent.Name = "LeftContent";
            this.LeftContent.Size = new System.Drawing.Size(120, 23);
            this.LeftContent.TabIndex = 2;
            // 
            // LeftTitle
            // 
            this.LeftTitle.AutoSize = true;
            this.LeftTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeftTitle.Location = new System.Drawing.Point(12, 12);
            this.LeftTitle.Name = "LeftTitle";
            this.LeftTitle.Size = new System.Drawing.Size(43, 25);
            this.LeftTitle.TabIndex = 3;
            this.LeftTitle.Text = "Left";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TopPanel.Controls.Add(this.RightDescription);
            this.TopPanel.Controls.Add(this.TopContent);
            this.TopPanel.Controls.Add(this.TopTitle);
            this.TopPanel.Location = new System.Drawing.Point(3, 723);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(840, 66);
            this.TopPanel.TabIndex = 13;
            // 
            // RightDescription
            // 
            this.RightDescription.AutoSize = true;
            this.RightDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RightDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RightDescription.Location = new System.Drawing.Point(15, 35);
            this.RightDescription.Name = "RightDescription";
            this.RightDescription.Size = new System.Drawing.Size(217, 20);
            this.RightDescription.TabIndex = 4;
            this.RightDescription.Text = "The top position of the window";
            // 
            // TopContent
            // 
            this.TopContent.Location = new System.Drawing.Point(703, 22);
            this.TopContent.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.TopContent.Name = "TopContent";
            this.TopContent.Size = new System.Drawing.Size(120, 23);
            this.TopContent.TabIndex = 2;
            // 
            // TopTitle
            // 
            this.TopTitle.AutoSize = true;
            this.TopTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopTitle.Location = new System.Drawing.Point(12, 12);
            this.TopTitle.Name = "TopTitle";
            this.TopTitle.Size = new System.Drawing.Size(42, 25);
            this.TopTitle.TabIndex = 3;
            this.TopTitle.Text = "Top";
            // 
            // ShowAsDialogpanel
            // 
            this.ShowAsDialogpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ShowAsDialogpanel.Controls.Add(this.ShowAsDialogContent);
            this.ShowAsDialogpanel.Controls.Add(this.ShowAsDialogDescription);
            this.ShowAsDialogpanel.Controls.Add(this.ShowAsDialogTitle);
            this.ShowAsDialogpanel.Location = new System.Drawing.Point(3, 795);
            this.ShowAsDialogpanel.Name = "ShowAsDialogpanel";
            this.ShowAsDialogpanel.Size = new System.Drawing.Size(840, 66);
            this.ShowAsDialogpanel.TabIndex = 14;
            // 
            // ShowAsDialogContent
            // 
            this.ShowAsDialogContent.AutoSize = true;
            this.ShowAsDialogContent.Location = new System.Drawing.Point(809, 28);
            this.ShowAsDialogContent.Name = "ShowAsDialogContent";
            this.ShowAsDialogContent.Size = new System.Drawing.Size(15, 14);
            this.ShowAsDialogContent.TabIndex = 5;
            this.ShowAsDialogContent.UseVisualStyleBackColor = true;
            // 
            // ShowAsDialogDescription
            // 
            this.ShowAsDialogDescription.AutoSize = true;
            this.ShowAsDialogDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowAsDialogDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowAsDialogDescription.Location = new System.Drawing.Point(15, 35);
            this.ShowAsDialogDescription.Name = "ShowAsDialogDescription";
            this.ShowAsDialogDescription.Size = new System.Drawing.Size(383, 20);
            this.ShowAsDialogDescription.TabIndex = 4;
            this.ShowAsDialogDescription.Text = "Wether to block the UI thread when showing the window";
            // 
            // ShowAsDialogTitle
            // 
            this.ShowAsDialogTitle.AutoSize = true;
            this.ShowAsDialogTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowAsDialogTitle.Location = new System.Drawing.Point(12, 12);
            this.ShowAsDialogTitle.Name = "ShowAsDialogTitle";
            this.ShowAsDialogTitle.Size = new System.Drawing.Size(133, 25);
            this.ShowAsDialogTitle.TabIndex = 3;
            this.ShowAsDialogTitle.Text = "ShowAsDialog";
            // 
            // TimeoutPanel
            // 
            this.TimeoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TimeoutPanel.Controls.Add(this.TimeoutContent);
            this.TimeoutPanel.Controls.Add(this.TimeoutDescription);
            this.TimeoutPanel.Controls.Add(this.TimeoutTitle);
            this.TimeoutPanel.Location = new System.Drawing.Point(3, 867);
            this.TimeoutPanel.Name = "TimeoutPanel";
            this.TimeoutPanel.Size = new System.Drawing.Size(840, 66);
            this.TimeoutPanel.TabIndex = 15;
            // 
            // TimeoutContent
            // 
            this.TimeoutContent.Location = new System.Drawing.Point(703, 22);
            this.TimeoutContent.Mask = "00:00:00";
            this.TimeoutContent.Name = "TimeoutContent";
            this.TimeoutContent.Size = new System.Drawing.Size(121, 23);
            this.TimeoutContent.TabIndex = 5;
            this.TimeoutContent.ValidatingType = typeof(System.DateTime);
            // 
            // TimeoutDescription
            // 
            this.TimeoutDescription.AutoSize = true;
            this.TimeoutDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeoutDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TimeoutDescription.Location = new System.Drawing.Point(15, 35);
            this.TimeoutDescription.Name = "TimeoutDescription";
            this.TimeoutDescription.Size = new System.Drawing.Size(275, 20);
            this.TimeoutDescription.TabIndex = 4;
            this.TimeoutDescription.Text = "The timespan when this action times out";
            // 
            // TimeoutTitle
            // 
            this.TimeoutTitle.AutoSize = true;
            this.TimeoutTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeoutTitle.Location = new System.Drawing.Point(12, 12);
            this.TimeoutTitle.Name = "TimeoutTitle";
            this.TimeoutTitle.Size = new System.Drawing.Size(81, 25);
            this.TimeoutTitle.TabIndex = 3;
            this.TimeoutTitle.Text = "Timeout";
            // 
            // ShowHandlerMessagesPanel
            // 
            this.ShowHandlerMessagesPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ShowHandlerMessagesPanel.Controls.Add(this.ShowHandlerMessagesContent);
            this.ShowHandlerMessagesPanel.Controls.Add(this.ShowHandlerMessagesDescription);
            this.ShowHandlerMessagesPanel.Controls.Add(this.ShowHandlerMessagesTitle);
            this.ShowHandlerMessagesPanel.Location = new System.Drawing.Point(3, 939);
            this.ShowHandlerMessagesPanel.Name = "ShowHandlerMessagesPanel";
            this.ShowHandlerMessagesPanel.Size = new System.Drawing.Size(840, 66);
            this.ShowHandlerMessagesPanel.TabIndex = 16;
            // 
            // ShowHandlerMessagesContent
            // 
            this.ShowHandlerMessagesContent.AutoSize = true;
            this.ShowHandlerMessagesContent.Location = new System.Drawing.Point(809, 28);
            this.ShowHandlerMessagesContent.Name = "ShowHandlerMessagesContent";
            this.ShowHandlerMessagesContent.Size = new System.Drawing.Size(15, 14);
            this.ShowHandlerMessagesContent.TabIndex = 5;
            this.ShowHandlerMessagesContent.UseVisualStyleBackColor = true;
            // 
            // ShowHandlerMessagesDescription
            // 
            this.ShowHandlerMessagesDescription.AutoSize = true;
            this.ShowHandlerMessagesDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowHandlerMessagesDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowHandlerMessagesDescription.Location = new System.Drawing.Point(15, 35);
            this.ShowHandlerMessagesDescription.Name = "ShowHandlerMessagesDescription";
            this.ShowHandlerMessagesDescription.Size = new System.Drawing.Size(383, 20);
            this.ShowHandlerMessagesDescription.TabIndex = 4;
            this.ShowHandlerMessagesDescription.Text = "Wether to block the UI thread when showing the window";
            // 
            // ShowHandlerMessagesTitle
            // 
            this.ShowHandlerMessagesTitle.AutoSize = true;
            this.ShowHandlerMessagesTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowHandlerMessagesTitle.Location = new System.Drawing.Point(12, 12);
            this.ShowHandlerMessagesTitle.Name = "ShowHandlerMessagesTitle";
            this.ShowHandlerMessagesTitle.Size = new System.Drawing.Size(207, 25);
            this.ShowHandlerMessagesTitle.TabIndex = 3;
            this.ShowHandlerMessagesTitle.Text = "ShowHandlerMessages";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentLayoutPanel);
            this.Controls.Add(this.DividerPanel);
            this.Controls.Add(this.SettingsLabel);
            this.DoubleBuffered = true;
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(884, 416);
            this.ContentLayoutPanel.ResumeLayout(false);
            this.HttpUrlPanel.ResumeLayout(false);
            this.HttpUrlPanel.PerformLayout();
            this.HttpPortPanel.ResumeLayout(false);
            this.HttpPortPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HttpPortContent)).EndInit();
            this.SiteKeyPanel.ResumeLayout(false);
            this.SiteKeyPanel.PerformLayout();
            this.LanguagePanel.ResumeLayout(false);
            this.LanguagePanel.PerformLayout();
            this.TokenRecievedHtmlPanel.ResumeLayout(false);
            this.TokenRecievedHtmlPanel.PerformLayout();
            this.TokenRecievedHookedHtmlPanel.ResumeLayout(false);
            this.TokenRecievedHookedHtmlPanel.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.IconPanel.ResumeLayout(false);
            this.IconPanel.PerformLayout();
            this.StartupLocationPanel.ResumeLayout(false);
            this.StartupLocationPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftContent)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopContent)).EndInit();
            this.ShowAsDialogpanel.ResumeLayout(false);
            this.ShowAsDialogpanel.PerformLayout();
            this.TimeoutPanel.ResumeLayout(false);
            this.TimeoutPanel.PerformLayout();
            this.ShowHandlerMessagesPanel.ResumeLayout(false);
            this.ShowHandlerMessagesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SettingsLabel;
        private Panel DividerPanel;
        private FlowLayoutPanel ContentLayoutPanel;
        private Panel HttpUrlPanel;
        private Label HttpUrlTitle;
        private Label HttpUrlDescription;
        private TextBox HttpUrlContent;
        private Panel HttpPortPanel;
        private Label HttpPortDescription;
        private Label HttpPortTitle;
        private NumericUpDown HttpPortContent;
        private Panel SiteKeyPanel;
        private Label SiteKeyDescription;
        private Label SiteKeyTitle;
        private TextBox SiteKeyContent;
        private Panel LanguagePanel;
        private Label LanguageDescription;
        private Label LanguageTitle;
        private TextBox LanguageContent;
        private Panel TokenRecievedHtmlPanel;
        private Label TokenRecievedHtmlDescription;
        private Label TokenRecievedHtmlTitle;
        private TextBox TokenRecievedHtmlContent;
        private Panel TokenRecievedHookedHtmlPanel;
        private Label TokenRecievedHookedHtmlDescription;
        private Label TokenRecievedHookedHtmlTitle;
        private TextBox TokenRecievedHookedHtmlContent;
        private Panel TitlePanel;
        private Label TitleTitle;
        private TextBox TitleContent;
        private Label TitleDescription;
        private Panel IconPanel;
        private Label IconTitle;
        private TextBox IconContent;
        private Label IconDescription;
        private Panel StartupLocationPanel;
        private Label StartupLocationTitle;
        private Label StartupLocationDescription;
        private ComboBox StartupLocationContent;
        private Panel LeftPanel;
        private Label LeftDescription;
        private NumericUpDown LeftContent;
        private Label LeftTitle;
        private Panel TopPanel;
        private Label RightDescription;
        private NumericUpDown TopContent;
        private Label TopTitle;
        private Panel ShowAsDialogpanel;
        private Label ShowAsDialogDescription;
        private Label ShowAsDialogTitle;
        private CheckBox ShowAsDialogContent;
        private Panel TimeoutPanel;
        private Label TimeoutDescription;
        private Label TimeoutTitle;
        private MaskedTextBox TimeoutContent;
        private Panel ShowHandlerMessagesPanel;
        private CheckBox ShowHandlerMessagesContent;
        private Label ShowHandlerMessagesDescription;
        private Label ShowHandlerMessagesTitle;
    }
}
