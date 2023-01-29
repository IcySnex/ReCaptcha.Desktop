namespace ReCaptcha.Desktop.Sample.WinForms.Controls
{
    partial class CaptchaControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchaControl));
            this.CaptchaLabel = new System.Windows.Forms.Label();
            this.DividerPanel = new System.Windows.Forms.Panel();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.TokenBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CaptchaLabel
            // 
            this.CaptchaLabel.AutoSize = true;
            this.CaptchaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaptchaLabel.Location = new System.Drawing.Point(12, 12);
            this.CaptchaLabel.Name = "CaptchaLabel";
            this.CaptchaLabel.Size = new System.Drawing.Size(199, 35);
            this.CaptchaLabel.TabIndex = 0;
            this.CaptchaLabel.Text = "Lets get started!";
            // 
            // DividerPanel
            // 
            this.DividerPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DividerPanel.Location = new System.Drawing.Point(12, 52);
            this.DividerPanel.Name = "DividerPanel";
            this.DividerPanel.Size = new System.Drawing.Size(860, 2);
            this.DividerPanel.TabIndex = 1;
            // 
            // ContentLabel
            // 
            this.ContentLabel.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContentLabel.Location = new System.Drawing.Point(12, 65);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(860, 253);
            this.ContentLabel.TabIndex = 2;
            this.ContentLabel.Text = resources.GetString("ContentLabel.Text");
            // 
            // VerifyButton
            // 
            this.VerifyButton.Location = new System.Drawing.Point(12, 326);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(296, 74);
            this.VerifyButton.TabIndex = 3;
            this.VerifyButton.Text = "I\'m not a robot";
            this.VerifyButton.UseVisualStyleBackColor = true;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // TokenBox
            // 
            this.TokenBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TokenBox.Location = new System.Drawing.Point(321, 326);
            this.TokenBox.Multiline = true;
            this.TokenBox.Name = "TokenBox";
            this.TokenBox.ReadOnly = true;
            this.TokenBox.Size = new System.Drawing.Size(551, 74);
            this.TokenBox.TabIndex = 4;
            this.TokenBox.Text = "Press \"I\'m not a robot\"!";
            // 
            // CaptchaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TokenBox);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.DividerPanel);
            this.Controls.Add(this.CaptchaLabel);
            this.Name = "CaptchaControl";
            this.Size = new System.Drawing.Size(884, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CaptchaLabel;
        private Panel DividerPanel;
        private Label ContentLabel;
        private Button VerifyButton;
        private TextBox TokenBox;
    }
}
