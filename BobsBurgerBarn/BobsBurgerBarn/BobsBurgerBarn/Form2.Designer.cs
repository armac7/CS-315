namespace BobsBurgerBarn
{
    partial class OrderForm
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
            burgerLabel = new Label();
            friesLabel = new Label();
            drinksLabel = new Label();
            burgerIn = new TextBox();
            friesIn = new TextBox();
            drinksIn = new TextBox();
            okButton = new Button();
            SuspendLayout();
            // 
            // burgerLabel
            // 
            burgerLabel.AutoSize = true;
            burgerLabel.Location = new Point(33, 20);
            burgerLabel.Name = "burgerLabel";
            burgerLabel.Size = new Size(73, 15);
            burgerLabel.TabIndex = 0;
            burgerLabel.Text = "Hamburgers";
            // 
            // friesLabel
            // 
            friesLabel.AutoSize = true;
            friesLabel.Location = new Point(33, 53);
            friesLabel.Name = "friesLabel";
            friesLabel.Size = new Size(70, 15);
            friesLabel.TabIndex = 1;
            friesLabel.Text = "French Fries";
            // 
            // drinksLabel
            // 
            drinksLabel.AutoSize = true;
            drinksLabel.Location = new Point(33, 91);
            drinksLabel.Name = "drinksLabel";
            drinksLabel.Size = new Size(40, 15);
            drinksLabel.TabIndex = 2;
            drinksLabel.Text = "Drinks";
            // 
            // burgerIn
            // 
            burgerIn.Location = new Point(112, 12);
            burgerIn.Name = "burgerIn";
            burgerIn.Size = new Size(100, 23);
            burgerIn.TabIndex = 3;
            // 
            // friesIn
            // 
            friesIn.Location = new Point(112, 50);
            friesIn.Name = "friesIn";
            friesIn.Size = new Size(100, 23);
            friesIn.TabIndex = 4;
            // 
            // drinksIn
            // 
            drinksIn.Location = new Point(112, 88);
            drinksIn.Name = "drinksIn";
            drinksIn.Size = new Size(100, 23);
            drinksIn.TabIndex = 5;
            // 
            // okButton
            // 
            okButton.Location = new Point(68, 123);
            okButton.Name = "okButton";
            okButton.Size = new Size(102, 40);
            okButton.TabIndex = 6;
            okButton.Text = "Order OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 175);
            Controls.Add(okButton);
            Controls.Add(drinksIn);
            Controls.Add(friesIn);
            Controls.Add(burgerIn);
            Controls.Add(drinksLabel);
            Controls.Add(friesLabel);
            Controls.Add(burgerLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Enter Order Info";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label burgerLabel;
        private Label friesLabel;
        private Label drinksLabel;
        private TextBox burgerIn;
        private TextBox friesIn;
        private TextBox drinksIn;
        private Button okButton;
    }
}