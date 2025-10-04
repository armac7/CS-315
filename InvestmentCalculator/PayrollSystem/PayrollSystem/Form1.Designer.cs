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
            labelPrincipal = new Label();
            labelRate = new Label();
            labelYears = new Label();
            labelGrossing = new Label();
            labelValue = new Label();
            textBoxPrincipal = new TextBox();
            textBoxRate = new TextBox();
            textBoxYears = new TextBox();
            buttonCompute = new Button();
            buttonNext = new Button();
            buttonDone = new Button();
            SuspendLayout();
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Location = new Point(90, 77);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(53, 15);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Principal";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Location = new Point(90, 106);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(30, 15);
            labelRate.TabIndex = 1;
            labelRate.Text = "Rate";
            // 
            // labelYears
            // 
            labelYears.AutoSize = true;
            labelYears.Location = new Point(90, 135);
            labelYears.Name = "labelYears";
            labelYears.Size = new Size(34, 15);
            labelYears.TabIndex = 2;
            labelYears.Text = "Years";
            // 
            // labelGrossing
            // 
            labelGrossing.AutoSize = true;
            labelGrossing.Location = new Point(90, 181);
            labelGrossing.Name = "labelGrossing";
            labelGrossing.Size = new Size(75, 15);
            labelGrossing.TabIndex = 3;
            labelGrossing.Text = "Future Value:";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(201, 181);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(35, 15);
            labelValue.TabIndex = 4;
            labelValue.Text = "Value";
            // 
            // textBoxPrincipal
            // 
            textBoxPrincipal.Location = new Point(201, 74);
            textBoxPrincipal.Name = "textBoxPrincipal";
            textBoxPrincipal.Size = new Size(178, 23);
            textBoxPrincipal.TabIndex = 5;
            // 
            // textBoxRate
            // 
            textBoxRate.Location = new Point(201, 103);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.Size = new Size(178, 23);
            textBoxRate.TabIndex = 6;
            // 
            // textBoxYears
            // 
            textBoxYears.Location = new Point(201, 132);
            textBoxYears.Name = "textBoxYears";
            textBoxYears.Size = new Size(178, 23);
            textBoxYears.TabIndex = 7;
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
            buttonNext.Size = new Size(110, 23);
            buttonNext.TabIndex = 9;
            buttonNext.Text = "Next Investment";
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
            Controls.Add(textBoxYears);
            Controls.Add(textBoxRate);
            Controls.Add(textBoxPrincipal);
            Controls.Add(labelValue);
            Controls.Add(labelGrossing);
            Controls.Add(labelYears);
            Controls.Add(labelRate);
            Controls.Add(labelPrincipal);
            Name = "Form1";
            Text = "Investment Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrincipal;
        private Label labelRate;
        private Label labelYears;
        private Label labelGrossing;
        private Label labelValue;
        private TextBox textBoxPrincipal;
        private TextBox textBoxRate;
        private TextBox textBoxYears;
        private Button buttonCompute;
        private Button buttonNext;
        private Button buttonDone;
    }
}
