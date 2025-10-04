namespace LoanAmortization
{
    partial class payoffForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loanLabel = new Label();
            rateLabel = new Label();
            paymentLabel = new Label();
            Schedule = new DataGridView();
            okButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Schedule).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 24);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Loan Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 51);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 1;
            label2.Text = "Annual Interest Rate (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 79);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Monthly Payment";
            // 
            // loanLabel
            // 
            loanLabel.AutoSize = true;
            loanLabel.Location = new Point(223, 24);
            loanLabel.Name = "loanLabel";
            loanLabel.Size = new Size(34, 15);
            loanLabel.TabIndex = 5;
            loanLabel.Text = "$0.00";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new Point(223, 51);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(38, 15);
            rateLabel.TabIndex = 4;
            rateLabel.Text = "0.00%";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new Point(223, 79);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(34, 15);
            paymentLabel.TabIndex = 3;
            paymentLabel.Text = "$0.00";
            // 
            // Schedule
            // 
            Schedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Schedule.Location = new Point(41, 122);
            Schedule.Name = "Schedule";
            Schedule.Size = new Size(646, 230);
            Schedule.TabIndex = 6;
            // 
            // okButton
            // 
            okButton.Location = new Point(275, 358);
            okButton.Name = "okButton";
            okButton.Size = new Size(204, 35);
            okButton.TabIndex = 7;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // payoffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 419);
            Controls.Add(okButton);
            Controls.Add(Schedule);
            Controls.Add(loanLabel);
            Controls.Add(rateLabel);
            Controls.Add(paymentLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "payoffForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Loan  Amortization Schedule";
            ((System.ComponentModel.ISupportInitialize)Schedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label loanLabel;
        private Label rateLabel;
        private Label paymentLabel;
        private DataGridView Schedule;
        private Button okButton;
    }
}