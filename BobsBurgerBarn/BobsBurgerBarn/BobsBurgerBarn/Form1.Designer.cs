namespace BobsBurgerBarn
{
    partial class MainForm
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
            newButton = new Button();
            summaryButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // newButton
            // 
            newButton.Location = new Point(45, 20);
            newButton.Name = "newButton";
            newButton.Size = new Size(150, 40);
            newButton.TabIndex = 0;
            newButton.Text = "New Order";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // summaryButton
            // 
            summaryButton.Location = new Point(45, 80);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(150, 40);
            summaryButton.TabIndex = 1;
            summaryButton.Text = "Summary";
            summaryButton.UseVisualStyleBackColor = true;
            summaryButton.Click += summaryButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(45, 140);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(150, 40);
            closeButton.TabIndex = 2;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(closeButton);
            Controls.Add(summaryButton);
            Controls.Add(newButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bob's Burger Barn";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button newButton;
        private Button summaryButton;
        private Button closeButton;
    }
}
