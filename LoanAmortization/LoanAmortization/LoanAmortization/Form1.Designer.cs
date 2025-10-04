namespace LoanAmortization
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loanIn = new TextBox();
            rateIn = new TextBox();
            paymentIn = new TextBox();
            amortizeButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Initial Balance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 48);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 1;
            label2.Text = "Annual Interest Rate (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 77);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Monthly Payment";
            // 
            // loanIn
            // 
            loanIn.Location = new Point(188, 16);
            loanIn.Name = "loanIn";
            loanIn.Size = new Size(100, 23);
            loanIn.TabIndex = 3;
            // 
            // rateIn
            // 
            rateIn.Location = new Point(188, 45);
            rateIn.Name = "rateIn";
            rateIn.Size = new Size(100, 23);
            rateIn.TabIndex = 4;
            // 
            // paymentIn
            // 
            paymentIn.Location = new Point(188, 74);
            paymentIn.Name = "paymentIn";
            paymentIn.Size = new Size(100, 23);
            paymentIn.TabIndex = 5;
            // 
            // amortizeButton
            // 
            amortizeButton.Location = new Point(53, 118);
            amortizeButton.Name = "amortizeButton";
            amortizeButton.Size = new Size(83, 39);
            amortizeButton.TabIndex = 6;
            amortizeButton.Text = "Amortize";
            amortizeButton.UseVisualStyleBackColor = true;
            amortizeButton.Click += amortizeButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(167, 118);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(80, 39);
            quitButton.TabIndex = 7;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 177);
            Controls.Add(quitButton);
            Controls.Add(amortizeButton);
            Controls.Add(paymentIn);
            Controls.Add(rateIn);
            Controls.Add(loanIn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Loan Amortization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox loanIn;
        private TextBox rateIn;
        private TextBox paymentIn;
        private Button amortizeButton;
        private Button quitButton;
    }
}
