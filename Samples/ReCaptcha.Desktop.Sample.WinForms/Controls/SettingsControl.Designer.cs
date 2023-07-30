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
            SettingsLabel = new Label();
            DividerPanel = new Panel();
            ContentLayoutPanel = new FlowLayoutPanel();
            SiteKeyPanel = new Panel();
            SiteKeyDescription = new Label();
            SiteKeyTitle = new Label();
            SiteKeyContent = new TextBox();
            panel1 = new Panel();
            HostNameContent = new TextBox();
            HostNameDescription = new Label();
            HostNameTitle = new Label();
            LanguagePanel = new Panel();
            LanguageDescription = new Label();
            LanguageTitle = new Label();
            LanguageContent = new TextBox();
            TokenRecievedHtmlPanel = new Panel();
            TokenRecievedHtmlDescription = new Label();
            TokenRecievedHtmlTitle = new Label();
            TokenRecievedHtmlContent = new TextBox();
            TokenRecievedHookedHtmlPanel = new Panel();
            TokenRecievedHookedHtmlTitle = new Label();
            TokenRecievedHookedHtmlContent = new TextBox();
            TokenRecievedHookedHtmlDescription = new Label();
            TitlePanel = new Panel();
            TitleTitle = new Label();
            TitleContent = new TextBox();
            TitleDescription = new Label();
            IconPanel = new Panel();
            IconTitle = new Label();
            IconContent = new TextBox();
            IconDescription = new Label();
            StartPositionPanel = new Panel();
            StartPositionTitle = new Label();
            StartPositionDescription = new Label();
            StartPositionContent = new ComboBox();
            LeftPanel = new Panel();
            LeftDescription = new Label();
            LeftContent = new NumericUpDown();
            LeftTitle = new Label();
            TopPanel = new Panel();
            RightDescription = new Label();
            TopContent = new NumericUpDown();
            TopTitle = new Label();
            ShowAsDialogpanel = new Panel();
            ShowAsDialogContent = new CheckBox();
            ShowAsDialogDescription = new Label();
            ShowAsDialogTitle = new Label();
            TimeoutPanel = new Panel();
            TimeoutContent = new MaskedTextBox();
            TimeoutDescription = new Label();
            TimeoutTitle = new Label();
            ShowHandlerMessagesPanel = new Panel();
            ShowHandlerMessagesContent = new CheckBox();
            ShowHandlerMessagesDescription = new Label();
            ShowHandlerMessagesTitle = new Label();
            ContentLayoutPanel.SuspendLayout();
            SiteKeyPanel.SuspendLayout();
            panel1.SuspendLayout();
            LanguagePanel.SuspendLayout();
            TokenRecievedHtmlPanel.SuspendLayout();
            TokenRecievedHookedHtmlPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            IconPanel.SuspendLayout();
            StartPositionPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LeftContent).BeginInit();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TopContent).BeginInit();
            ShowAsDialogpanel.SuspendLayout();
            TimeoutPanel.SuspendLayout();
            ShowHandlerMessagesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsLabel
            // 
            SettingsLabel.AutoSize = true;
            SettingsLabel.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsLabel.Location = new Point(12, 12);
            SettingsLabel.Name = "SettingsLabel";
            SettingsLabel.Size = new Size(108, 35);
            SettingsLabel.TabIndex = 0;
            SettingsLabel.Text = "Settings";
            // 
            // DividerPanel
            // 
            DividerPanel.BackColor = SystemColors.ActiveCaptionText;
            DividerPanel.Location = new Point(12, 52);
            DividerPanel.Name = "DividerPanel";
            DividerPanel.Size = new Size(860, 2);
            DividerPanel.TabIndex = 1;
            // 
            // ContentLayoutPanel
            // 
            ContentLayoutPanel.AutoScroll = true;
            ContentLayoutPanel.Controls.Add(SiteKeyPanel);
            ContentLayoutPanel.Controls.Add(panel1);
            ContentLayoutPanel.Controls.Add(LanguagePanel);
            ContentLayoutPanel.Controls.Add(TokenRecievedHtmlPanel);
            ContentLayoutPanel.Controls.Add(TokenRecievedHookedHtmlPanel);
            ContentLayoutPanel.Controls.Add(TitlePanel);
            ContentLayoutPanel.Controls.Add(IconPanel);
            ContentLayoutPanel.Controls.Add(StartPositionPanel);
            ContentLayoutPanel.Controls.Add(LeftPanel);
            ContentLayoutPanel.Controls.Add(TopPanel);
            ContentLayoutPanel.Controls.Add(ShowAsDialogpanel);
            ContentLayoutPanel.Controls.Add(TimeoutPanel);
            ContentLayoutPanel.Controls.Add(ShowHandlerMessagesPanel);
            ContentLayoutPanel.FlowDirection = FlowDirection.TopDown;
            ContentLayoutPanel.Location = new Point(12, 72);
            ContentLayoutPanel.Name = "ContentLayoutPanel";
            ContentLayoutPanel.Size = new Size(872, 344);
            ContentLayoutPanel.TabIndex = 2;
            ContentLayoutPanel.WrapContents = false;
            // 
            // SiteKeyPanel
            // 
            SiteKeyPanel.BackColor = SystemColors.ControlLight;
            SiteKeyPanel.Controls.Add(SiteKeyDescription);
            SiteKeyPanel.Controls.Add(SiteKeyTitle);
            SiteKeyPanel.Controls.Add(SiteKeyContent);
            SiteKeyPanel.Location = new Point(3, 3);
            SiteKeyPanel.Name = "SiteKeyPanel";
            SiteKeyPanel.Size = new Size(857, 66);
            SiteKeyPanel.TabIndex = 5;
            // 
            // SiteKeyDescription
            // 
            SiteKeyDescription.AutoSize = true;
            SiteKeyDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SiteKeyDescription.ForeColor = SystemColors.ControlDarkDark;
            SiteKeyDescription.Location = new Point(15, 35);
            SiteKeyDescription.Name = "SiteKeyDescription";
            SiteKeyDescription.Size = new Size(317, 20);
            SiteKeyDescription.TabIndex = 4;
            SiteKeyDescription.Text = "The SiteKey for the Google reCAPTCHA service";
            // 
            // SiteKeyTitle
            // 
            SiteKeyTitle.AutoSize = true;
            SiteKeyTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SiteKeyTitle.Location = new Point(12, 12);
            SiteKeyTitle.Name = "SiteKeyTitle";
            SiteKeyTitle.Size = new Size(73, 25);
            SiteKeyTitle.TabIndex = 3;
            SiteKeyTitle.Text = "SiteKey";
            // 
            // SiteKeyContent
            // 
            SiteKeyContent.Location = new Point(578, 22);
            SiteKeyContent.Name = "SiteKeyContent";
            SiteKeyContent.Size = new Size(256, 23);
            SiteKeyContent.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(HostNameContent);
            panel1.Controls.Add(HostNameDescription);
            panel1.Controls.Add(HostNameTitle);
            panel1.Location = new Point(3, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 66);
            panel1.TabIndex = 7;
            // 
            // HostNameContent
            // 
            HostNameContent.Location = new Point(634, 22);
            HostNameContent.Name = "HostNameContent";
            HostNameContent.PlaceholderText = "recaptcha.desktop";
            HostNameContent.Size = new Size(200, 23);
            HostNameContent.TabIndex = 6;
            // 
            // HostNameDescription
            // 
            HostNameDescription.AutoSize = true;
            HostNameDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            HostNameDescription.ForeColor = SystemColors.ControlDarkDark;
            HostNameDescription.Location = new Point(15, 35);
            HostNameDescription.Name = "HostNameDescription";
            HostNameDescription.Size = new Size(657, 20);
            HostNameDescription.TabIndex = 4;
            HostNameDescription.Text = "The name of the virtual host on which the reCAPTCHA is hosted. Should represent your application";
            // 
            // HostNameTitle
            // 
            HostNameTitle.AutoSize = true;
            HostNameTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            HostNameTitle.Location = new Point(12, 12);
            HostNameTitle.Name = "HostNameTitle";
            HostNameTitle.Size = new Size(100, 25);
            HostNameTitle.TabIndex = 3;
            HostNameTitle.Text = "HostName";
            // 
            // LanguagePanel
            // 
            LanguagePanel.BackColor = SystemColors.ControlLight;
            LanguagePanel.Controls.Add(LanguageDescription);
            LanguagePanel.Controls.Add(LanguageTitle);
            LanguagePanel.Controls.Add(LanguageContent);
            LanguagePanel.Location = new Point(3, 147);
            LanguagePanel.Name = "LanguagePanel";
            LanguagePanel.Size = new Size(857, 66);
            LanguagePanel.TabIndex = 6;
            // 
            // LanguageDescription
            // 
            LanguageDescription.AutoSize = true;
            LanguageDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LanguageDescription.ForeColor = SystemColors.ControlDarkDark;
            LanguageDescription.Location = new Point(15, 35);
            LanguageDescription.Name = "LanguageDescription";
            LanguageDescription.Size = new Size(330, 20);
            LanguageDescription.TabIndex = 4;
            LanguageDescription.Text = "The language for the Google reCAPTCHA service";
            // 
            // LanguageTitle
            // 
            LanguageTitle.AutoSize = true;
            LanguageTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LanguageTitle.Location = new Point(12, 12);
            LanguageTitle.Name = "LanguageTitle";
            LanguageTitle.Size = new Size(95, 25);
            LanguageTitle.TabIndex = 3;
            LanguageTitle.Text = "Language";
            // 
            // LanguageContent
            // 
            LanguageContent.Location = new Point(714, 22);
            LanguageContent.Name = "LanguageContent";
            LanguageContent.PlaceholderText = "en";
            LanguageContent.Size = new Size(120, 23);
            LanguageContent.TabIndex = 6;
            // 
            // TokenRecievedHtmlPanel
            // 
            TokenRecievedHtmlPanel.BackColor = SystemColors.ControlLight;
            TokenRecievedHtmlPanel.Controls.Add(TokenRecievedHtmlDescription);
            TokenRecievedHtmlPanel.Controls.Add(TokenRecievedHtmlTitle);
            TokenRecievedHtmlPanel.Controls.Add(TokenRecievedHtmlContent);
            TokenRecievedHtmlPanel.Location = new Point(3, 219);
            TokenRecievedHtmlPanel.Name = "TokenRecievedHtmlPanel";
            TokenRecievedHtmlPanel.Size = new Size(857, 66);
            TokenRecievedHtmlPanel.TabIndex = 7;
            // 
            // TokenRecievedHtmlDescription
            // 
            TokenRecievedHtmlDescription.AutoSize = true;
            TokenRecievedHtmlDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TokenRecievedHtmlDescription.ForeColor = SystemColors.ControlDarkDark;
            TokenRecievedHtmlDescription.Location = new Point(15, 35);
            TokenRecievedHtmlDescription.Name = "TokenRecievedHtmlDescription";
            TokenRecievedHtmlDescription.Size = new Size(465, 20);
            TokenRecievedHtmlDescription.TabIndex = 4;
            TokenRecievedHtmlDescription.Text = "The HTML which gets displayed after the user verifed the reCAPTCHA";
            // 
            // TokenRecievedHtmlTitle
            // 
            TokenRecievedHtmlTitle.AutoSize = true;
            TokenRecievedHtmlTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TokenRecievedHtmlTitle.Location = new Point(12, 12);
            TokenRecievedHtmlTitle.Name = "TokenRecievedHtmlTitle";
            TokenRecievedHtmlTitle.Size = new Size(175, 25);
            TokenRecievedHtmlTitle.TabIndex = 3;
            TokenRecievedHtmlTitle.Text = "TokenRecievedHtml";
            // 
            // TokenRecievedHtmlContent
            // 
            TokenRecievedHtmlContent.Location = new Point(578, 22);
            TokenRecievedHtmlContent.Name = "TokenRecievedHtmlContent";
            TokenRecievedHtmlContent.PlaceholderText = "Token recieved: %token%";
            TokenRecievedHtmlContent.Size = new Size(256, 23);
            TokenRecievedHtmlContent.TabIndex = 6;
            // 
            // TokenRecievedHookedHtmlPanel
            // 
            TokenRecievedHookedHtmlPanel.BackColor = SystemColors.ControlLight;
            TokenRecievedHookedHtmlPanel.Controls.Add(TokenRecievedHookedHtmlTitle);
            TokenRecievedHookedHtmlPanel.Controls.Add(TokenRecievedHookedHtmlContent);
            TokenRecievedHookedHtmlPanel.Controls.Add(TokenRecievedHookedHtmlDescription);
            TokenRecievedHookedHtmlPanel.Location = new Point(3, 291);
            TokenRecievedHookedHtmlPanel.Name = "TokenRecievedHookedHtmlPanel";
            TokenRecievedHookedHtmlPanel.Size = new Size(857, 66);
            TokenRecievedHookedHtmlPanel.TabIndex = 8;
            // 
            // TokenRecievedHookedHtmlTitle
            // 
            TokenRecievedHookedHtmlTitle.AutoSize = true;
            TokenRecievedHookedHtmlTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TokenRecievedHookedHtmlTitle.Location = new Point(12, 12);
            TokenRecievedHookedHtmlTitle.Name = "TokenRecievedHookedHtmlTitle";
            TokenRecievedHookedHtmlTitle.Size = new Size(240, 25);
            TokenRecievedHookedHtmlTitle.TabIndex = 3;
            TokenRecievedHookedHtmlTitle.Text = "TokenRecievedHookedHtml";
            // 
            // TokenRecievedHookedHtmlContent
            // 
            TokenRecievedHookedHtmlContent.Location = new Point(578, 22);
            TokenRecievedHookedHtmlContent.Name = "TokenRecievedHookedHtmlContent";
            TokenRecievedHookedHtmlContent.PlaceholderText = "Token recieved and sent to application.";
            TokenRecievedHookedHtmlContent.Size = new Size(256, 23);
            TokenRecievedHookedHtmlContent.TabIndex = 6;
            // 
            // TokenRecievedHookedHtmlDescription
            // 
            TokenRecievedHookedHtmlDescription.AutoSize = true;
            TokenRecievedHookedHtmlDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TokenRecievedHookedHtmlDescription.ForeColor = SystemColors.ControlDarkDark;
            TokenRecievedHookedHtmlDescription.Location = new Point(15, 35);
            TokenRecievedHookedHtmlDescription.Name = "TokenRecievedHookedHtmlDescription";
            TokenRecievedHookedHtmlDescription.Size = new Size(689, 20);
            TokenRecievedHookedHtmlDescription.TabIndex = 4;
            TokenRecievedHookedHtmlDescription.Text = "The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application";
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = SystemColors.ControlLight;
            TitlePanel.Controls.Add(TitleTitle);
            TitlePanel.Controls.Add(TitleContent);
            TitlePanel.Controls.Add(TitleDescription);
            TitlePanel.Location = new Point(3, 363);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(857, 66);
            TitlePanel.TabIndex = 9;
            // 
            // TitleTitle
            // 
            TitleTitle.AutoSize = true;
            TitleTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitleTitle.Location = new Point(12, 12);
            TitleTitle.Name = "TitleTitle";
            TitleTitle.Size = new Size(48, 25);
            TitleTitle.TabIndex = 3;
            TitleTitle.Text = "Title";
            // 
            // TitleContent
            // 
            TitleContent.Location = new Point(578, 22);
            TitleContent.Name = "TitleContent";
            TitleContent.PlaceholderText = "WinForms Sample - Google reCAPTCHA";
            TitleContent.Size = new Size(256, 23);
            TitleContent.TabIndex = 6;
            // 
            // TitleDescription
            // 
            TitleDescription.AutoSize = true;
            TitleDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitleDescription.ForeColor = SystemColors.ControlDarkDark;
            TitleDescription.Location = new Point(15, 35);
            TitleDescription.Name = "TitleDescription";
            TitleDescription.Size = new Size(142, 20);
            TitleDescription.TabIndex = 4;
            TitleDescription.Text = "The title of the form";
            // 
            // IconPanel
            // 
            IconPanel.BackColor = SystemColors.ControlLight;
            IconPanel.Controls.Add(IconTitle);
            IconPanel.Controls.Add(IconContent);
            IconPanel.Controls.Add(IconDescription);
            IconPanel.Location = new Point(3, 435);
            IconPanel.Name = "IconPanel";
            IconPanel.Size = new Size(857, 66);
            IconPanel.TabIndex = 10;
            // 
            // IconTitle
            // 
            IconTitle.AutoSize = true;
            IconTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            IconTitle.Location = new Point(12, 12);
            IconTitle.Name = "IconTitle";
            IconTitle.Size = new Size(48, 25);
            IconTitle.TabIndex = 3;
            IconTitle.Text = "Icon";
            // 
            // IconContent
            // 
            IconContent.Location = new Point(578, 22);
            IconContent.Name = "IconContent";
            IconContent.PlaceholderText = "Icon.ico";
            IconContent.Size = new Size(256, 23);
            IconContent.TabIndex = 6;
            // 
            // IconDescription
            // 
            IconDescription.AutoSize = true;
            IconDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IconDescription.ForeColor = SystemColors.ControlDarkDark;
            IconDescription.Location = new Point(15, 35);
            IconDescription.Name = "IconDescription";
            IconDescription.Size = new Size(144, 20);
            IconDescription.TabIndex = 4;
            IconDescription.Text = "The icon of the form";
            // 
            // StartPositionPanel
            // 
            StartPositionPanel.BackColor = SystemColors.ControlLight;
            StartPositionPanel.Controls.Add(StartPositionTitle);
            StartPositionPanel.Controls.Add(StartPositionDescription);
            StartPositionPanel.Controls.Add(StartPositionContent);
            StartPositionPanel.Location = new Point(3, 507);
            StartPositionPanel.Name = "StartPositionPanel";
            StartPositionPanel.Size = new Size(857, 66);
            StartPositionPanel.TabIndex = 11;
            // 
            // StartPositionTitle
            // 
            StartPositionTitle.AutoSize = true;
            StartPositionTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartPositionTitle.Location = new Point(12, 12);
            StartPositionTitle.Name = "StartPositionTitle";
            StartPositionTitle.Size = new Size(117, 25);
            StartPositionTitle.TabIndex = 3;
            StartPositionTitle.Text = "StartPosition";
            // 
            // StartPositionDescription
            // 
            StartPositionDescription.AutoSize = true;
            StartPositionDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartPositionDescription.ForeColor = SystemColors.ControlDarkDark;
            StartPositionDescription.Location = new Point(15, 35);
            StartPositionDescription.Name = "StartPositionDescription";
            StartPositionDescription.Size = new Size(203, 20);
            StartPositionDescription.TabIndex = 4;
            StartPositionDescription.Text = "The start position of the form";
            // 
            // StartPositionContent
            // 
            StartPositionContent.FormattingEnabled = true;
            StartPositionContent.Location = new Point(578, 22);
            StartPositionContent.Name = "StartPositionContent";
            StartPositionContent.Size = new Size(256, 23);
            StartPositionContent.TabIndex = 7;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = SystemColors.ControlLight;
            LeftPanel.Controls.Add(LeftDescription);
            LeftPanel.Controls.Add(LeftContent);
            LeftPanel.Controls.Add(LeftTitle);
            LeftPanel.Location = new Point(3, 579);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(857, 66);
            LeftPanel.TabIndex = 12;
            // 
            // LeftDescription
            // 
            LeftDescription.AutoSize = true;
            LeftDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LeftDescription.ForeColor = SystemColors.ControlDarkDark;
            LeftDescription.Location = new Point(15, 35);
            LeftDescription.Name = "LeftDescription";
            LeftDescription.Size = new Size(196, 20);
            LeftDescription.TabIndex = 4;
            LeftDescription.Text = "The left position of the form";
            // 
            // LeftContent
            // 
            LeftContent.Location = new Point(714, 22);
            LeftContent.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            LeftContent.Name = "LeftContent";
            LeftContent.Size = new Size(120, 23);
            LeftContent.TabIndex = 2;
            // 
            // LeftTitle
            // 
            LeftTitle.AutoSize = true;
            LeftTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LeftTitle.Location = new Point(12, 12);
            LeftTitle.Name = "LeftTitle";
            LeftTitle.Size = new Size(43, 25);
            LeftTitle.TabIndex = 3;
            LeftTitle.Text = "Left";
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.ControlLight;
            TopPanel.Controls.Add(RightDescription);
            TopPanel.Controls.Add(TopContent);
            TopPanel.Controls.Add(TopTitle);
            TopPanel.Location = new Point(3, 651);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(857, 66);
            TopPanel.TabIndex = 13;
            // 
            // RightDescription
            // 
            RightDescription.AutoSize = true;
            RightDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RightDescription.ForeColor = SystemColors.ControlDarkDark;
            RightDescription.Location = new Point(15, 35);
            RightDescription.Name = "RightDescription";
            RightDescription.Size = new Size(197, 20);
            RightDescription.TabIndex = 4;
            RightDescription.Text = "The top position of the form";
            // 
            // TopContent
            // 
            TopContent.Location = new Point(714, 22);
            TopContent.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            TopContent.Name = "TopContent";
            TopContent.Size = new Size(120, 23);
            TopContent.TabIndex = 2;
            // 
            // TopTitle
            // 
            TopTitle.AutoSize = true;
            TopTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TopTitle.Location = new Point(12, 12);
            TopTitle.Name = "TopTitle";
            TopTitle.Size = new Size(42, 25);
            TopTitle.TabIndex = 3;
            TopTitle.Text = "Top";
            // 
            // ShowAsDialogpanel
            // 
            ShowAsDialogpanel.BackColor = SystemColors.ControlLight;
            ShowAsDialogpanel.Controls.Add(ShowAsDialogContent);
            ShowAsDialogpanel.Controls.Add(ShowAsDialogDescription);
            ShowAsDialogpanel.Controls.Add(ShowAsDialogTitle);
            ShowAsDialogpanel.Location = new Point(3, 723);
            ShowAsDialogpanel.Name = "ShowAsDialogpanel";
            ShowAsDialogpanel.Size = new Size(857, 66);
            ShowAsDialogpanel.TabIndex = 14;
            // 
            // ShowAsDialogContent
            // 
            ShowAsDialogContent.AutoSize = true;
            ShowAsDialogContent.Location = new Point(820, 28);
            ShowAsDialogContent.Name = "ShowAsDialogContent";
            ShowAsDialogContent.Size = new Size(15, 14);
            ShowAsDialogContent.TabIndex = 5;
            ShowAsDialogContent.UseVisualStyleBackColor = true;
            // 
            // ShowAsDialogDescription
            // 
            ShowAsDialogDescription.AutoSize = true;
            ShowAsDialogDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ShowAsDialogDescription.ForeColor = SystemColors.ControlDarkDark;
            ShowAsDialogDescription.Location = new Point(15, 35);
            ShowAsDialogDescription.Name = "ShowAsDialogDescription";
            ShowAsDialogDescription.Size = new Size(363, 20);
            ShowAsDialogDescription.TabIndex = 4;
            ShowAsDialogDescription.Text = "Wether to block the UI thread when showing the form";
            // 
            // ShowAsDialogTitle
            // 
            ShowAsDialogTitle.AutoSize = true;
            ShowAsDialogTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ShowAsDialogTitle.Location = new Point(12, 12);
            ShowAsDialogTitle.Name = "ShowAsDialogTitle";
            ShowAsDialogTitle.Size = new Size(133, 25);
            ShowAsDialogTitle.TabIndex = 3;
            ShowAsDialogTitle.Text = "ShowAsDialog";
            // 
            // TimeoutPanel
            // 
            TimeoutPanel.BackColor = SystemColors.ControlLight;
            TimeoutPanel.Controls.Add(TimeoutContent);
            TimeoutPanel.Controls.Add(TimeoutDescription);
            TimeoutPanel.Controls.Add(TimeoutTitle);
            TimeoutPanel.Location = new Point(3, 795);
            TimeoutPanel.Name = "TimeoutPanel";
            TimeoutPanel.Size = new Size(857, 66);
            TimeoutPanel.TabIndex = 15;
            // 
            // TimeoutContent
            // 
            TimeoutContent.Location = new Point(714, 22);
            TimeoutContent.Mask = "00:00:00";
            TimeoutContent.Name = "TimeoutContent";
            TimeoutContent.Size = new Size(121, 23);
            TimeoutContent.TabIndex = 5;
            TimeoutContent.ValidatingType = typeof(DateTime);
            // 
            // TimeoutDescription
            // 
            TimeoutDescription.AutoSize = true;
            TimeoutDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TimeoutDescription.ForeColor = SystemColors.ControlDarkDark;
            TimeoutDescription.Location = new Point(15, 35);
            TimeoutDescription.Name = "TimeoutDescription";
            TimeoutDescription.Size = new Size(275, 20);
            TimeoutDescription.TabIndex = 4;
            TimeoutDescription.Text = "The timespan when this action times out";
            // 
            // TimeoutTitle
            // 
            TimeoutTitle.AutoSize = true;
            TimeoutTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TimeoutTitle.Location = new Point(12, 12);
            TimeoutTitle.Name = "TimeoutTitle";
            TimeoutTitle.Size = new Size(81, 25);
            TimeoutTitle.TabIndex = 3;
            TimeoutTitle.Text = "Timeout";
            // 
            // ShowHandlerMessagesPanel
            // 
            ShowHandlerMessagesPanel.BackColor = SystemColors.ControlLight;
            ShowHandlerMessagesPanel.Controls.Add(ShowHandlerMessagesContent);
            ShowHandlerMessagesPanel.Controls.Add(ShowHandlerMessagesDescription);
            ShowHandlerMessagesPanel.Controls.Add(ShowHandlerMessagesTitle);
            ShowHandlerMessagesPanel.Location = new Point(3, 867);
            ShowHandlerMessagesPanel.Name = "ShowHandlerMessagesPanel";
            ShowHandlerMessagesPanel.Size = new Size(857, 66);
            ShowHandlerMessagesPanel.TabIndex = 16;
            // 
            // ShowHandlerMessagesContent
            // 
            ShowHandlerMessagesContent.AutoSize = true;
            ShowHandlerMessagesContent.Location = new Point(820, 28);
            ShowHandlerMessagesContent.Name = "ShowHandlerMessagesContent";
            ShowHandlerMessagesContent.Size = new Size(15, 14);
            ShowHandlerMessagesContent.TabIndex = 5;
            ShowHandlerMessagesContent.UseVisualStyleBackColor = true;
            // 
            // ShowHandlerMessagesDescription
            // 
            ShowHandlerMessagesDescription.AutoSize = true;
            ShowHandlerMessagesDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ShowHandlerMessagesDescription.ForeColor = SystemColors.ControlDarkDark;
            ShowHandlerMessagesDescription.Location = new Point(15, 35);
            ShowHandlerMessagesDescription.Name = "ShowHandlerMessagesDescription";
            ShowHandlerMessagesDescription.Size = new Size(363, 20);
            ShowHandlerMessagesDescription.TabIndex = 4;
            ShowHandlerMessagesDescription.Text = "Wether to block the UI thread when showing the form";
            // 
            // ShowHandlerMessagesTitle
            // 
            ShowHandlerMessagesTitle.AutoSize = true;
            ShowHandlerMessagesTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ShowHandlerMessagesTitle.Location = new Point(12, 12);
            ShowHandlerMessagesTitle.Name = "ShowHandlerMessagesTitle";
            ShowHandlerMessagesTitle.Size = new Size(207, 25);
            ShowHandlerMessagesTitle.TabIndex = 3;
            ShowHandlerMessagesTitle.Text = "ShowHandlerMessages";
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentLayoutPanel);
            Controls.Add(DividerPanel);
            Controls.Add(SettingsLabel);
            DoubleBuffered = true;
            Name = "SettingsControl";
            Size = new Size(894, 416);
            ContentLayoutPanel.ResumeLayout(false);
            SiteKeyPanel.ResumeLayout(false);
            SiteKeyPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            LanguagePanel.ResumeLayout(false);
            LanguagePanel.PerformLayout();
            TokenRecievedHtmlPanel.ResumeLayout(false);
            TokenRecievedHtmlPanel.PerformLayout();
            TokenRecievedHookedHtmlPanel.ResumeLayout(false);
            TokenRecievedHookedHtmlPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            IconPanel.ResumeLayout(false);
            IconPanel.PerformLayout();
            StartPositionPanel.ResumeLayout(false);
            StartPositionPanel.PerformLayout();
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LeftContent).EndInit();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TopContent).EndInit();
            ShowAsDialogpanel.ResumeLayout(false);
            ShowAsDialogpanel.PerformLayout();
            TimeoutPanel.ResumeLayout(false);
            TimeoutPanel.PerformLayout();
            ShowHandlerMessagesPanel.ResumeLayout(false);
            ShowHandlerMessagesPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SettingsLabel;
        private Panel DividerPanel;
        private FlowLayoutPanel ContentLayoutPanel;
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
        private Panel StartPositionPanel;
        private Label StartPositionTitle;
        private Label StartPositionDescription;
        private ComboBox StartPositionContent;
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
        private Panel panel1;
        private Label HostNameDescription;
        private Label HostNameTitle;
        private TextBox HostNameContent;
    }
}
