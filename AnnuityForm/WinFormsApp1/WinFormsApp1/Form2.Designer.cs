namespace WinFormsApp1
{
    partial class TableForm
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
            Amount = new Label();
            Per_Year = new Label();
            Interest_Rate = new Label();
            dataGridView1 = new DataGridView();
            OkButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(152, 28);
            label1.Name = "label1";
            label1.Size = new Size(222, 21);
            label1.TabIndex = 0;
            label1.Text = "Amount of Periodic Deposit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(152, 63);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 1;
            label2.Text = "Deposits Per Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(152, 101);
            label3.Name = "label3";
            label3.Size = new Size(195, 21);
            label3.TabIndex = 2;
            label3.Text = "Annual Interest Rate (%)";
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Font = new Font("Segoe UI", 12F);
            Amount.Location = new Point(419, 28);
            Amount.Name = "Amount";
            Amount.Size = new Size(49, 21);
            Amount.TabIndex = 3;
            Amount.Text = "$0.00";
            // 
            // Per_Year
            // 
            Per_Year.AutoSize = true;
            Per_Year.Font = new Font("Segoe UI", 12F);
            Per_Year.Location = new Point(449, 63);
            Per_Year.Name = "Per_Year";
            Per_Year.Size = new Size(19, 21);
            Per_Year.TabIndex = 4;
            Per_Year.Text = "0";
            // 
            // Interest_Rate
            // 
            Interest_Rate.AutoSize = true;
            Interest_Rate.Font = new Font("Segoe UI", 12F);
            Interest_Rate.Location = new Point(406, 101);
            Interest_Rate.Name = "Interest_Rate";
            Interest_Rate.Size = new Size(62, 21);
            Interest_Rate.TabIndex = 5;
            Interest_Rate.Text = "0.000%";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(543, 165);
            dataGridView1.TabIndex = 6;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(218, 341);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(204, 35);
            OkButton.TabIndex = 7;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 394);
            Controls.Add(OkButton);
            Controls.Add(dataGridView1);
            Controls.Add(Interest_Rate);
            Controls.Add(Per_Year);
            Controls.Add(Amount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TableForm";
            Text = "Value of Annuity";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label Amount;
        private Label Per_Year;
        private Label Interest_Rate;
        private DataGridView dataGridView1;
        private Button OkButton;
    }
}