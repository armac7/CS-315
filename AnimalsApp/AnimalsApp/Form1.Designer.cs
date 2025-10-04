namespace AnimalsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonDragon = new Button();
            buttonWerewolf = new Button();
            buttonUnicorn = new Button();
            buttonCentaur = new Button();
            AnimalLabel = new Label();
            SuspendLayout();
            // 
            // buttonDragon
            // 
            buttonDragon.BackgroundImage = (Image)resources.GetObject("buttonDragon.BackgroundImage");
            buttonDragon.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDragon.Location = new Point(88, 70);
            buttonDragon.Name = "buttonDragon";
            buttonDragon.Size = new Size(300, 300);
            buttonDragon.TabIndex = 0;
            buttonDragon.UseVisualStyleBackColor = true;
            buttonDragon.Click += buttonDragon_Click;
            // 
            // buttonWerewolf
            // 
            buttonWerewolf.BackgroundImage = (Image)resources.GetObject("buttonWerewolf.BackgroundImage");
            buttonWerewolf.BackgroundImageLayout = ImageLayout.Stretch;
            buttonWerewolf.Location = new Point(799, 70);
            buttonWerewolf.Name = "buttonWerewolf";
            buttonWerewolf.Size = new Size(300, 300);
            buttonWerewolf.TabIndex = 1;
            buttonWerewolf.UseVisualStyleBackColor = true;
            buttonWerewolf.Click += buttonWerewolf_Click;
            // 
            // buttonUnicorn
            // 
            buttonUnicorn.BackgroundImage = (Image)resources.GetObject("buttonUnicorn.BackgroundImage");
            buttonUnicorn.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUnicorn.Location = new Point(88, 656);
            buttonUnicorn.Name = "buttonUnicorn";
            buttonUnicorn.Size = new Size(300, 300);
            buttonUnicorn.TabIndex = 2;
            buttonUnicorn.UseVisualStyleBackColor = true;
            buttonUnicorn.Click += buttonUnicorn_Click;
            // 
            // buttonCentaur
            // 
            buttonCentaur.BackgroundImage = (Image)resources.GetObject("buttonCentaur.BackgroundImage");
            buttonCentaur.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCentaur.Location = new Point(799, 656);
            buttonCentaur.Name = "buttonCentaur";
            buttonCentaur.Size = new Size(300, 300);
            buttonCentaur.TabIndex = 3;
            buttonCentaur.UseVisualStyleBackColor = true;
            buttonCentaur.Click += buttonCentaur_Click;
            // 
            // AnimalLabel
            // 
            AnimalLabel.AutoSize = true;
            AnimalLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnimalLabel.ForeColor = Color.Blue;
            AnimalLabel.Location = new Point(467, 455);
            AnimalLabel.Name = "AnimalLabel";
            AnimalLabel.Size = new Size(0, 56);
            AnimalLabel.TabIndex = 4;
            AnimalLabel.DoubleClick += AnimalLabel_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 1061);
            Controls.Add(AnimalLabel);
            Controls.Add(buttonCentaur);
            Controls.Add(buttonUnicorn);
            Controls.Add(buttonWerewolf);
            Controls.Add(buttonDragon);
            Name = "Form1";
            Text = "Mystical Animals";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDragon;
        private Button buttonWerewolf;
        private Button buttonUnicorn;
        private Button buttonCentaur;
        private Label AnimalLabel;
    }
}
