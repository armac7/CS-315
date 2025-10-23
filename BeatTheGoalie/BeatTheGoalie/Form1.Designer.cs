namespace BeatTheGoalie
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            goalLabel = new Label();
            saveLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            scoreLabel = new Label();
            shotsLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 250;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // goalLabel
            // 
            goalLabel.AutoSize = true;
            goalLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            goalLabel.Location = new Point(578, 67);
            goalLabel.Name = "goalLabel";
            goalLabel.Size = new Size(76, 28);
            goalLabel.TabIndex = 0;
            goalLabel.Text = "Goal!!!";
            goalLabel.Visible = false;
            // 
            // saveLabel
            // 
            saveLabel.AutoSize = true;
            saveLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            saveLabel.Location = new Point(647, 67);
            saveLabel.Name = "saveLabel";
            saveLabel.Size = new Size(77, 28);
            saveLabel.TabIndex = 1;
            saveLabel.Text = "Save!!!";
            saveLabel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 2;
            label3.Text = "Score";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(12, 45);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 3;
            label4.Text = "Shots";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 15F);
            scoreLabel.Location = new Point(89, 14);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(23, 28);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "0";
            // 
            // shotsLabel
            // 
            shotsLabel.AutoSize = true;
            shotsLabel.Font = new Font("Segoe UI", 15F);
            shotsLabel.Location = new Point(89, 45);
            shotsLabel.Name = "shotsLabel";
            shotsLabel.Size = new Size(23, 28);
            shotsLabel.TabIndex = 5;
            shotsLabel.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(scoreLabel);
            panel1.Controls.Add(shotsLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(592, 316);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 89);
            panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(saveLabel);
            Controls.Add(goalLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Paint += MainForm_Paint;
            MouseMove += MainForm_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label goalLabel;
        private Label saveLabel;
        private Label label3;
        private Label label4;
        private Label scoreLabel;
        private Label shotsLabel;
        private Panel panel1;
    }
}
