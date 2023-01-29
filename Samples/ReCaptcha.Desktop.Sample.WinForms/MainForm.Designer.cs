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
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.LoggerButton = new System.Windows.Forms.Button();
            this.GitHubButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(222)))));
            this.NavigationPanel.Controls.Add(this.LoggerButton);
            this.NavigationPanel.Controls.Add(this.GitHubButton);
            this.NavigationPanel.Controls.Add(this.SettingsButton);
            this.NavigationPanel.Controls.Add(this.HomeButton);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(884, 45);
            this.NavigationPanel.TabIndex = 0;
            // 
            // LoggerButton
            // 
            this.LoggerButton.AutoSize = true;
            this.LoggerButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoggerButton.FlatAppearance.BorderSize = 0;
            this.LoggerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoggerButton.Location = new System.Drawing.Point(704, 0);
            this.LoggerButton.Name = "LoggerButton";
            this.LoggerButton.Size = new System.Drawing.Size(90, 45);
            this.LoggerButton.TabIndex = 3;
            this.LoggerButton.Text = "Show Logger";
            this.LoggerButton.UseVisualStyleBackColor = true;
            this.LoggerButton.Click += new System.EventHandler(this.LoggerButton_Click);
            // 
            // GitHubButton
            // 
            this.GitHubButton.AutoSize = true;
            this.GitHubButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.GitHubButton.FlatAppearance.BorderSize = 0;
            this.GitHubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitHubButton.Location = new System.Drawing.Point(794, 0);
            this.GitHubButton.Name = "GitHubButton";
            this.GitHubButton.Size = new System.Drawing.Size(90, 45);
            this.GitHubButton.TabIndex = 2;
            this.GitHubButton.Text = "GitHub";
            this.GitHubButton.UseVisualStyleBackColor = true;
            this.GitHubButton.Click += new System.EventHandler(this.GitHubButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.AutoSize = true;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(75, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 45);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.AutoSize = true;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 45);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 45);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(884, 416);
            this.ContentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.NavigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "ReCaptcha.Desktop - WinForms Sample";
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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