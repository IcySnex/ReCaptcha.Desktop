namespace ReCaptcha.Desktop.Sample.WinForms.Controls
{
    partial class HomeControl
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
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IconBox
            // 
            this.IconBox.Image = global::ReCaptcha.Desktop.Sample.WinForms.Properties.Resources.Icon;
            this.IconBox.Location = new System.Drawing.Point(0, 91);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(884, 60);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconBox.TabIndex = 0;
            this.IconBox.TabStop = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriptionLabel.Location = new System.Drawing.Point(0, 201);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(884, 63);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "This is an example application based on WinForms.\r\nThis is an open source library" +
    " and is not affiliated with Google in any way.";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(0, 154);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(884, 47);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Welcome to Google reCAPTCHA on Desktop!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(363, 279);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(159, 56);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Lets get started!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.IconBox);
            this.Controls.Add(this.DescriptionLabel);
            this.DoubleBuffered = true;
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(884, 416);
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox IconBox;
        private Label TitleLabel;
        private Label DescriptionLabel;
        private Button StartButton;
    }
}
