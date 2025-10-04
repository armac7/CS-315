namespace PayrollSystem
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
            labelEName = new Label();
            labelRate = new Label();
            labelHoursWorked = new Label();
            labelGrossing = new Label();
            labelGrossAmount = new Label();
            textBoxEName = new TextBox();
            textBoxRate = new TextBox();
            textBoxHoursWorked = new TextBox();
            buttonCompute = new Button();
            buttonNext = new Button();
            buttonDone = new Button();
            SuspendLayout();
            // 
            // labelEName
            // 
            labelEName.AutoSize = true;
            labelEName.Location = new Point(90, 58);
            labelEName.Name = "labelEName";
            labelEName.Size = new Size(94, 15);
            labelEName.TabIndex = 0;
            labelEName.Text = "Employee Name";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Location = new Point(88, 92);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(69, 15);
            labelRate.TabIndex = 1;
            labelRate.Text = "Hourly Rate";
            // 
            // labelHoursWorked
            // 
            labelHoursWorked.AutoSize = true;
            labelHoursWorked.Location = new Point(90, 130);
            labelHoursWorked.Name = "labelHoursWorked";
            labelHoursWorked.Size = new Size(83, 15);
            labelHoursWorked.TabIndex = 2;
            labelHoursWorked.Text = "Hours Worked";
            // 
            // labelGrossing
            // 
            labelGrossing.AutoSize = true;
            labelGrossing.Location = new Point(90, 181);
            labelGrossing.Name = "labelGrossing";
            labelGrossing.Size = new Size(61, 15);
            labelGrossing.TabIndex = 3;
            labelGrossing.Text = "Gross Pay:";
            // 
            // labelGrossAmount
            // 
            labelGrossAmount.AutoSize = true;
            labelGrossAmount.Location = new Point(201, 181);
            labelGrossAmount.Name = "labelGrossAmount";
            labelGrossAmount.Size = new Size(83, 15);
            labelGrossAmount.TabIndex = 4;
            labelGrossAmount.Text = "Gross Amount";
            // 
            // textBoxEName
            // 
            textBoxEName.Location = new Point(201, 55);
            textBoxEName.Name = "textBoxEName";
            textBoxEName.Size = new Size(178, 23);
            textBoxEName.TabIndex = 5;
            // 
            // textBoxRate
            // 
            textBoxRate.Location = new Point(201, 92);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.Size = new Size(178, 23);
            textBoxRate.TabIndex = 6;
            // 
            // textBoxHoursWorked
            // 
            textBoxHoursWorked.Location = new Point(201, 127);
            textBoxHoursWorked.Name = "textBoxHoursWorked";
            textBoxHoursWorked.Size = new Size(178, 23);
            textBoxHoursWorked.TabIndex = 7;
            // 
            // buttonCompute
            // 
            buttonCompute.Location = new Point(88, 230);
            buttonCompute.Name = "buttonCompute";
            buttonCompute.Size = new Size(75, 23);
            buttonCompute.TabIndex = 8;
            buttonCompute.Text = "Compute";
            buttonCompute.UseVisualStyleBackColor = true;
            buttonCompute.Click += buttonCompute_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(201, 230);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(100, 23);
            buttonNext.TabIndex = 9;
            buttonNext.Text = "Next Employee";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(337, 230);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 23);
            buttonDone.TabIndex = 10;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 305);
            Controls.Add(buttonDone);
            Controls.Add(buttonNext);
            Controls.Add(buttonCompute);
            Controls.Add(textBoxHoursWorked);
            Controls.Add(textBoxRate);
            Controls.Add(textBoxEName);
            Controls.Add(labelGrossAmount);
            Controls.Add(labelGrossing);
            Controls.Add(labelHoursWorked);
            Controls.Add(labelRate);
            Controls.Add(labelEName);
            Name = "Form1";
            Text = "Payroll System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEName;
        private Label labelRate;
        private Label labelHoursWorked;
        private Label labelGrossing;
        private Label labelGrossAmount;
        private TextBox textBoxEName;
        private TextBox textBoxRate;
        private TextBox textBoxHoursWorked;
        private Button buttonCompute;
        private Button buttonNext;
        private Button buttonDone;
    }
}
