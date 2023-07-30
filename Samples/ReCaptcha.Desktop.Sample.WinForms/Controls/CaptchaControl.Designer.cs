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
            CaptchaLabel = new Label();
            DividerPanel = new Panel();
            ContentLabel = new Label();
            VerifyButton = new Button();
            TokenBox = new TextBox();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // CaptchaLabel
            // 
            CaptchaLabel.AutoSize = true;
            CaptchaLabel.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            CaptchaLabel.Location = new Point(12, 12);
            CaptchaLabel.Name = "CaptchaLabel";
            CaptchaLabel.Size = new Size(199, 35);
            CaptchaLabel.TabIndex = 0;
            CaptchaLabel.Text = "Lets get started!";
            // 
            // DividerPanel
            // 
            DividerPanel.BackColor = SystemColors.ActiveCaptionText;
            DividerPanel.Location = new Point(12, 52);
            DividerPanel.Name = "DividerPanel";
            DividerPanel.Size = new Size(860, 2);
            DividerPanel.TabIndex = 1;
            // 
            // ContentLabel
            // 
            ContentLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            ContentLabel.Location = new Point(12, 65);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new Size(878, 253);
            ContentLabel.TabIndex = 2;
            ContentLabel.Text = resources.GetString("ContentLabel.Text");
            // 
            // VerifyButton
            // 
            VerifyButton.Location = new Point(12, 326);
            VerifyButton.Name = "VerifyButton";
            VerifyButton.Size = new Size(238, 74);
            VerifyButton.TabIndex = 3;
            VerifyButton.Text = "I'm not a robot";
            VerifyButton.UseVisualStyleBackColor = true;
            VerifyButton.Click += VerifyButton_Click;
            // 
            // TokenBox
            // 
            TokenBox.BackColor = SystemColors.ControlLightLight;
            TokenBox.Location = new Point(319, 326);
            TokenBox.Multiline = true;
            TokenBox.Name = "TokenBox";
            TokenBox.ReadOnly = true;
            TokenBox.ScrollBars = ScrollBars.Both;
            TokenBox.Size = new Size(559, 74);
            TokenBox.TabIndex = 4;
            TokenBox.Text = "Press \"I'm not a robot\"!";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(250, 326);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(58, 74);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Reset";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CaptchaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CancelButton);
            Controls.Add(TokenBox);
            Controls.Add(VerifyButton);
            Controls.Add(ContentLabel);
            Controls.Add(DividerPanel);
            Controls.Add(CaptchaLabel);
            Name = "CaptchaControl";
            Size = new Size(893, 416);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CaptchaLabel;
        private Panel DividerPanel;
        private Label ContentLabel;
        private Button VerifyButton;
        private TextBox TokenBox;
        private Button CancelButton;
    }
}
