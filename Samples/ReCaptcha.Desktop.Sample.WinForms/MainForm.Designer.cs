namespace ReCaptcha.Desktop.Sample.WinForms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            NavigationPanel = new Panel();
            LoggerButton = new Button();
            GitHubButton = new Button();
            SettingsButton = new Button();
            HomeButton = new Button();
            ContentPanel = new Panel();
            NavigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = Color.FromArgb(180, 212, 222);
            NavigationPanel.Controls.Add(LoggerButton);
            NavigationPanel.Controls.Add(GitHubButton);
            NavigationPanel.Controls.Add(SettingsButton);
            NavigationPanel.Controls.Add(HomeButton);
            NavigationPanel.Dock = DockStyle.Top;
            NavigationPanel.Location = new Point(0, 0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(890, 45);
            NavigationPanel.TabIndex = 0;
            // 
            // LoggerButton
            // 
            LoggerButton.AutoSize = true;
            LoggerButton.Dock = DockStyle.Right;
            LoggerButton.FlatAppearance.BorderSize = 0;
            LoggerButton.FlatStyle = FlatStyle.Flat;
            LoggerButton.Location = new Point(710, 0);
            LoggerButton.Name = "LoggerButton";
            LoggerButton.Size = new Size(90, 45);
            LoggerButton.TabIndex = 3;
            LoggerButton.Text = "Show Logger";
            LoggerButton.UseVisualStyleBackColor = true;
            LoggerButton.Click += LoggerButton_Click;
            // 
            // GitHubButton
            // 
            GitHubButton.AutoSize = true;
            GitHubButton.Dock = DockStyle.Right;
            GitHubButton.FlatAppearance.BorderSize = 0;
            GitHubButton.FlatStyle = FlatStyle.Flat;
            GitHubButton.Location = new Point(800, 0);
            GitHubButton.Name = "GitHubButton";
            GitHubButton.Size = new Size(90, 45);
            GitHubButton.TabIndex = 2;
            GitHubButton.Text = "GitHub";
            GitHubButton.UseVisualStyleBackColor = true;
            GitHubButton.Click += GitHubButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.AutoSize = true;
            SettingsButton.Dock = DockStyle.Left;
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Location = new Point(75, 0);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(75, 45);
            SettingsButton.TabIndex = 1;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.AutoSize = true;
            HomeButton.Dock = DockStyle.Left;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Location = new Point(0, 0);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(75, 45);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.AutoSize = true;
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(0, 45);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(890, 416);
            ContentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 461);
            Controls.Add(ContentPanel);
            Controls.Add(NavigationPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(600, 400);
            Name = "MainForm";
            Text = "ReCaptcha.Desktop - WinForms Sample";
            NavigationPanel.ResumeLayout(false);
            NavigationPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel NavigationPanel;
        private Button HomeButton;
        private Button LoggerButton;
        private Button GitHubButton;
        private Button SettingsButton;
        private Panel ContentPanel;
    }
}