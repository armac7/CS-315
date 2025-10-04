namespace BobsBurgerBarn
{
    partial class SummaryForm
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
            label4 = new Label();
            largestLabel = new Label();
            smallestLabel = new Label();
            totalLabel = new Label();
            placedLabel = new Label();
            okButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of Orders:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 64);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 1;
            label2.Text = "Dollar Value of All Orders:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 134);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 3;
            label3.Text = "Largest Order Placed: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 97);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 2;
            label4.Text = "Smallest Order Placed: ";
            // 
            // largestLabel
            // 
            largestLabel.AutoSize = true;
            largestLabel.Location = new Point(187, 134);
            largestLabel.Name = "largestLabel";
            largestLabel.Size = new Size(34, 15);
            largestLabel.TabIndex = 7;
            largestLabel.Text = "$0.00";
            // 
            // smallestLabel
            // 
            smallestLabel.AutoSize = true;
            smallestLabel.Location = new Point(187, 97);
            smallestLabel.Name = "smallestLabel";
            smallestLabel.Size = new Size(34, 15);
            smallestLabel.TabIndex = 6;
            smallestLabel.Text = "$0.00";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(187, 64);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(34, 15);
            totalLabel.TabIndex = 5;
            totalLabel.Text = "$0.00";
            // 
            // placedLabel
            // 
            placedLabel.AutoSize = true;
            placedLabel.Location = new Point(187, 27);
            placedLabel.Name = "placedLabel";
            placedLabel.Size = new Size(13, 15);
            placedLabel.TabIndex = 4;
            placedLabel.Text = "0";
            // 
            // okButton
            // 
            okButton.Location = new Point(74, 165);
            okButton.Name = "okButton";
            okButton.Size = new Size(114, 38);
            okButton.TabIndex = 8;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 225);
            Controls.Add(okButton);
            Controls.Add(largestLabel);
            Controls.Add(smallestLabel);
            Controls.Add(totalLabel);
            Controls.Add(placedLabel);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SummaryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Daily Summary";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label largestLabel;
        private Label smallestLabel;
        private Label totalLabel;
        private Label placedLabel;
        private Button okButton;
    }
}