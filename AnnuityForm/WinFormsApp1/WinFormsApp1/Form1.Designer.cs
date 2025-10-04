namespace WinFormsApp1
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
            label4 = new Label();
            amountIn = new TextBox();
            depoIn = new TextBox();
            interestIn = new TextBox();
            lifeIn = new TextBox();
            showButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Amount of Period Deposit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 68);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Deposits Per Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 115);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 2;
            label3.Text = "Annual Interest Rate (%)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 167);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Life of Annuity";
            // 
            // amountIn
            // 
            amountIn.Location = new Point(166, 16);
            amountIn.Name = "amountIn";
            amountIn.Size = new Size(100, 23);
            amountIn.TabIndex = 4;
            // 
            // depoIn
            // 
            depoIn.Location = new Point(166, 65);
            depoIn.Name = "depoIn";
            depoIn.Size = new Size(100, 23);
            depoIn.TabIndex = 5;
            // 
            // interestIn
            // 
            interestIn.Location = new Point(166, 112);
            interestIn.Name = "interestIn";
            interestIn.Size = new Size(100, 23);
            interestIn.TabIndex = 6;
            // 
            // lifeIn
            // 
            lifeIn.Location = new Point(166, 164);
            lifeIn.Name = "lifeIn";
            lifeIn.Size = new Size(100, 23);
            lifeIn.TabIndex = 7;
            // 
            // showButton
            // 
            showButton.Location = new Point(15, 220);
            showButton.Name = "showButton";
            showButton.Size = new Size(119, 50);
            showButton.TabIndex = 8;
            showButton.Text = "Show Table";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(147, 220);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(119, 50);
            quitButton.TabIndex = 9;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 282);
            Controls.Add(quitButton);
            Controls.Add(showButton);
            Controls.Add(lifeIn);
            Controls.Add(interestIn);
            Controls.Add(depoIn);
            Controls.Add(amountIn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Annuity Planning Tool";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox amountIn;
        private TextBox depoIn;
        private TextBox interestIn;
        private TextBox lifeIn;
        private Button showButton;
        private Button quitButton;
    }
}
