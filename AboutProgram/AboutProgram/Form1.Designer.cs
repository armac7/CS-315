namespace AboutProgram
{
    partial class AboutForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonClose = new Button();
            labelClass = new Label();
            labelInfo = new Label();
            labelCopyright = new Label();
            picture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(500, 525);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(125, 60);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Location = new Point(485, 265);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(140, 21);
            labelClass.TabIndex = 1;
            labelClass.Text = "C# Lab #1 - Part 1";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(400, 365);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(322, 21);
            labelInfo.TabIndex = 2;
            labelInfo.Text = "Programmed by William Ryan McDonald";
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Location = new Point(460, 465);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(191, 21);
            labelCopyright.TabIndex = 3;
            labelCopyright.Text = "Copyright (c) 8/26/2025";
            // 
            // picture
            // 
            picture.ImageLocation = "C:\\Users\\wmcdonald\\Downloads\\zWs6eE.jpg";
            picture.Location = new Point(150, 50);
            picture.Name = "picture";
            picture.Size = new Size(850, 211);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 4;
            picture.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1144, 631);
            Controls.Add(picture);
            Controls.Add(labelCopyright);
            Controls.Add(labelInfo);
            Controls.Add(labelClass);
            Controls.Add(buttonClose);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label labelClass;
        private Label labelInfo;
        private Label labelCopyright;
        private PictureBox picture;
    }
}
