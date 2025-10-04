namespace FantasyFootballStatsCalc
{
    partial class FFStatsCalc
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
            teamNameLabel = new Label();
            playerNumLabel = new Label();
            playerNameLabel = new Label();
            rushYardsLabel = new Label();
            recieveYardsLabel = new Label();
            touchDownLabel = new Label();
            teamNameText = new TextBox();
            nameBox = new TextBox();
            rushingText = new TextBox();
            recievingText = new TextBox();
            touchdownsText = new TextBox();
            computeButton = new Button();
            exitButton = new Button();
            TEAM_NAME = new Label();
            SuspendLayout();
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new Point(77, 78);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(113, 15);
            teamNameLabel.TabIndex = 0;
            teamNameLabel.Text = "Fantasy Team Name";
            // 
            // playerNumLabel
            // 
            playerNumLabel.AutoSize = true;
            playerNumLabel.Location = new Point(77, 125);
            playerNumLabel.Name = "playerNumLabel";
            playerNumLabel.Size = new Size(55, 15);
            playerNumLabel.TabIndex = 1;
            playerNumLabel.Text = "Player #1";
            // 
            // playerNameLabel
            // 
            playerNameLabel.AutoSize = true;
            playerNameLabel.Location = new Point(77, 169);
            playerNameLabel.Name = "playerNameLabel";
            playerNameLabel.Size = new Size(74, 15);
            playerNameLabel.TabIndex = 2;
            playerNameLabel.Text = "Player Name";
            // 
            // rushYardsLabel
            // 
            rushYardsLabel.AutoSize = true;
            rushYardsLabel.Location = new Point(77, 212);
            rushYardsLabel.Name = "rushYardsLabel";
            rushYardsLabel.Size = new Size(81, 15);
            rushYardsLabel.TabIndex = 3;
            rushYardsLabel.Text = "Rushing Yards";
            // 
            // recieveYardsLabel
            // 
            recieveYardsLabel.AutoSize = true;
            recieveYardsLabel.Location = new Point(77, 247);
            recieveYardsLabel.Name = "recieveYardsLabel";
            recieveYardsLabel.Size = new Size(89, 15);
            recieveYardsLabel.TabIndex = 4;
            recieveYardsLabel.Text = "Recieving Yards";
            // 
            // touchDownLabel
            // 
            touchDownLabel.AutoSize = true;
            touchDownLabel.Location = new Point(77, 287);
            touchDownLabel.Name = "touchDownLabel";
            touchDownLabel.Size = new Size(74, 15);
            touchDownLabel.TabIndex = 5;
            touchDownLabel.Text = "Touchdowns";
            // 
            // teamNameText
            // 
            teamNameText.Location = new Point(222, 75);
            teamNameText.Name = "teamNameText";
            teamNameText.Size = new Size(223, 23);
            teamNameText.TabIndex = 6;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(222, 166);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(134, 23);
            nameBox.TabIndex = 7;
            // 
            // rushingText
            // 
            rushingText.Location = new Point(222, 209);
            rushingText.Name = "rushingText";
            rushingText.Size = new Size(61, 23);
            rushingText.TabIndex = 8;
            // 
            // recievingText
            // 
            recievingText.Location = new Point(222, 244);
            recievingText.Name = "recievingText";
            recievingText.Size = new Size(61, 23);
            recievingText.TabIndex = 9;
            // 
            // touchdownsText
            // 
            touchdownsText.Location = new Point(222, 284);
            touchdownsText.Name = "touchdownsText";
            touchdownsText.Size = new Size(61, 23);
            touchdownsText.TabIndex = 10;
            // 
            // computeButton
            // 
            computeButton.Location = new Point(77, 330);
            computeButton.Name = "computeButton";
            computeButton.Size = new Size(90, 60);
            computeButton.TabIndex = 11;
            computeButton.Text = "Compute Player Stats";
            computeButton.UseVisualStyleBackColor = true;
            computeButton.Click += computeButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(222, 330);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(90, 60);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // TEAM_NAME
            // 
            TEAM_NAME.AutoSize = true;
            TEAM_NAME.Location = new Point(225, 80);
            TEAM_NAME.Name = "TEAM_NAME";
            TEAM_NAME.Size = new Size(70, 15);
            TEAM_NAME.TabIndex = 13;
            TEAM_NAME.Text = "Team Name";
            TEAM_NAME.Visible = false;
            // 
            // FFStatsCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(TEAM_NAME);
            Controls.Add(exitButton);
            Controls.Add(computeButton);
            Controls.Add(touchdownsText);
            Controls.Add(recievingText);
            Controls.Add(rushingText);
            Controls.Add(nameBox);
            Controls.Add(teamNameText);
            Controls.Add(touchDownLabel);
            Controls.Add(recieveYardsLabel);
            Controls.Add(rushYardsLabel);
            Controls.Add(playerNameLabel);
            Controls.Add(playerNumLabel);
            Controls.Add(teamNameLabel);
            Name = "FFStatsCalc";
            Text = "Fantasty Football Stats Calculator";
            Load += FFStatsCalc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label teamNameLabel;
        private Label playerNumLabel;
        private Label playerNameLabel;
        private Label rushYardsLabel;
        private Label recieveYardsLabel;
        private Label touchDownLabel;
        private TextBox teamNameText;
        private TextBox nameBox;
        private TextBox rushingText;
        private TextBox recievingText;
        private TextBox touchdownsText;
        private Button computeButton;
        private Button exitButton;
        private Label TEAM_NAME;
    }
}
