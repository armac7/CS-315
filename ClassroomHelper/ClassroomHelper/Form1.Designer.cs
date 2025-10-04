namespace ClassroomHelper
{
    partial class Form1
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
            nameLabel = new Label();
            exam1Label = new Label();
            exam3Label = new Label();
            exam2Label = new Label();
            nameIn = new TextBox();
            exam1In = new TextBox();
            exam3In = new TextBox();
            exam2In = new TextBox();
            okButton = new Button();
            doneButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(21, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(83, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Student Name";
            // 
            // exam1Label
            // 
            exam1Label.AutoSize = true;
            exam1Label.Location = new Point(21, 53);
            exam1Label.Name = "exam1Label";
            exam1Label.Size = new Size(45, 15);
            exam1Label.TabIndex = 1;
            exam1Label.Text = "Exam 1";
            // 
            // exam3Label
            // 
            exam3Label.AutoSize = true;
            exam3Label.Location = new Point(21, 129);
            exam3Label.Name = "exam3Label";
            exam3Label.Size = new Size(45, 15);
            exam3Label.TabIndex = 3;
            exam3Label.Text = "Exam 3";
            // 
            // exam2Label
            // 
            exam2Label.AutoSize = true;
            exam2Label.Location = new Point(21, 91);
            exam2Label.Name = "exam2Label";
            exam2Label.Size = new Size(45, 15);
            exam2Label.TabIndex = 2;
            exam2Label.Text = "Exam 2";
            // 
            // nameIn
            // 
            nameIn.Location = new Point(162, 15);
            nameIn.Name = "nameIn";
            nameIn.Size = new Size(215, 23);
            nameIn.TabIndex = 4;
            // 
            // exam1In
            // 
            exam1In.Location = new Point(162, 53);
            exam1In.Name = "exam1In";
            exam1In.Size = new Size(75, 23);
            exam1In.TabIndex = 5;
            // 
            // exam3In
            // 
            exam3In.Location = new Point(162, 126);
            exam3In.Name = "exam3In";
            exam3In.Size = new Size(75, 23);
            exam3In.TabIndex = 7;
            // 
            // exam2In
            // 
            exam2In.Location = new Point(162, 88);
            exam2In.Name = "exam2In";
            exam2In.Size = new Size(75, 23);
            exam2In.TabIndex = 6;
            // 
            // okButton
            // 
            okButton.Location = new Point(45, 166);
            okButton.Name = "okButton";
            okButton.Size = new Size(136, 34);
            okButton.TabIndex = 8;
            okButton.Text = "Student OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // doneButton
            // 
            doneButton.Location = new Point(214, 166);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(136, 34);
            doneButton.TabIndex = 9;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 225);
            Controls.Add(doneButton);
            Controls.Add(okButton);
            Controls.Add(exam3In);
            Controls.Add(exam2In);
            Controls.Add(exam1In);
            Controls.Add(nameIn);
            Controls.Add(exam3Label);
            Controls.Add(exam2Label);
            Controls.Add(exam1Label);
            Controls.Add(nameLabel);
            Name = "Form1";
            Text = "Classroom Helper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label exam1Label;
        private Label exam3Label;
        private Label exam2Label;
        private TextBox nameIn;
        private TextBox exam1In;
        private TextBox exam3In;
        private TextBox exam2In;
        private Button okButton;
        private Button doneButton;
    }
}
