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
            IconBox = new PictureBox();
            DescriptionLabel = new Label();
            TitleLabel = new Label();
            StartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)IconBox).BeginInit();
            SuspendLayout();
            // 
            // IconBox
            // 
            IconBox.Image = Properties.Resources.Icon;
            IconBox.Location = new Point(0, 91);
            IconBox.Name = "IconBox";
            IconBox.Size = new Size(894, 60);
            IconBox.SizeMode = PictureBoxSizeMode.Zoom;
            IconBox.TabIndex = 0;
            IconBox.TabStop = false;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.ForeColor = SystemColors.ControlDarkDark;
            DescriptionLabel.Location = new Point(0, 201);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(894, 63);
            DescriptionLabel.TabIndex = 2;
            DescriptionLabel.Text = "This is an example application based on WinForms.\r\nThis is an open source library and is not affiliated with Google in any way.";
            DescriptionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // TitleLabel
            // 
            TitleLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            TitleLabel.Location = new Point(0, 154);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(894, 47);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Welcome to Google reCAPTCHA on Desktop!";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(369, 279);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(159, 56);
            StartButton.TabIndex = 3;
            StartButton.Text = "Lets get started!";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StartButton);
            Controls.Add(TitleLabel);
            Controls.Add(IconBox);
            Controls.Add(DescriptionLabel);
            DoubleBuffered = true;
            Name = "HomeControl";
            Size = new Size(894, 416);
            ((System.ComponentModel.ISupportInitialize)IconBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox IconBox;
        private Label TitleLabel;
        private Label DescriptionLabel;
        private Button StartButton;
    }
}
