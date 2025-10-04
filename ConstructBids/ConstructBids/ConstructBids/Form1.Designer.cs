namespace ConstructBids
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
            labelID = new Label();
            labelStep = new Label();
            labelStepNum = new Label();
            labelDesc = new Label();
            labelCrewSize = new Label();
            labelHoursNeeded = new Label();
            textID = new TextBox();
            textDesc = new TextBox();
            textCrewSize = new TextBox();
            textHoursNeeded = new TextBox();
            buttonNext = new Button();
            buttonNew = new Button();
            buttonExit = new Button();
            PROJ_ID = new Label();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(85, 45);
            labelID.Name = "labelID";
            labelID.Size = new Size(58, 15);
            labelID.TabIndex = 0;
            labelID.Text = "Project ID";
            // 
            // labelStep
            // 
            labelStep.AutoSize = true;
            labelStep.Location = new Point(85, 90);
            labelStep.Name = "labelStep";
            labelStep.Size = new Size(77, 15);
            labelStep.TabIndex = 1;
            labelStep.Text = "Project Step#";
            // 
            // labelStepNum
            // 
            labelStepNum.AutoSize = true;
            labelStepNum.Location = new Point(178, 91);
            labelStepNum.Name = "labelStepNum";
            labelStepNum.Size = new Size(13, 15);
            labelStepNum.TabIndex = 2;
            labelStepNum.Text = "1";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Location = new Point(85, 135);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(67, 15);
            labelDesc.TabIndex = 3;
            labelDesc.Text = "Description";
            // 
            // labelCrewSize
            // 
            labelCrewSize.AutoSize = true;
            labelCrewSize.Location = new Point(85, 180);
            labelCrewSize.Name = "labelCrewSize";
            labelCrewSize.Size = new Size(57, 15);
            labelCrewSize.TabIndex = 4;
            labelCrewSize.Text = "Crew Size";
            // 
            // labelHoursNeeded
            // 
            labelHoursNeeded.AutoSize = true;
            labelHoursNeeded.Location = new Point(85, 225);
            labelHoursNeeded.Name = "labelHoursNeeded";
            labelHoursNeeded.Size = new Size(83, 15);
            labelHoursNeeded.TabIndex = 5;
            labelHoursNeeded.Text = "Hours Needed";
            // 
            // textID
            // 
            textID.Location = new Point(178, 42);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 6;
            // 
            // textDesc
            // 
            textDesc.Location = new Point(178, 132);
            textDesc.Name = "textDesc";
            textDesc.Size = new Size(284, 23);
            textDesc.TabIndex = 7;
            // 
            // textCrewSize
            // 
            textCrewSize.Location = new Point(178, 180);
            textCrewSize.Name = "textCrewSize";
            textCrewSize.Size = new Size(46, 23);
            textCrewSize.TabIndex = 8;
            // 
            // textHoursNeeded
            // 
            textHoursNeeded.Location = new Point(178, 222);
            textHoursNeeded.Name = "textHoursNeeded";
            textHoursNeeded.Size = new Size(46, 23);
            textHoursNeeded.TabIndex = 9;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(160, 290);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(194, 23);
            buttonNext.TabIndex = 10;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(160, 330);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(194, 23);
            buttonNew.TabIndex = 11;
            buttonNew.Text = "New Project";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(160, 370);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(194, 23);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // PROJ_ID
            // 
            PROJ_ID.AutoSize = true;
            PROJ_ID.Location = new Point(178, 45);
            PROJ_ID.Name = "PROJ_ID";
            PROJ_ID.Size = new Size(18, 15);
            PROJ_ID.TabIndex = 13;
            PROJ_ID.Text = "ID";
            PROJ_ID.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(534, 436);
            Controls.Add(PROJ_ID);
            Controls.Add(buttonExit);
            Controls.Add(buttonNew);
            Controls.Add(buttonNext);
            Controls.Add(textHoursNeeded);
            Controls.Add(textCrewSize);
            Controls.Add(textDesc);
            Controls.Add(textID);
            Controls.Add(labelHoursNeeded);
            Controls.Add(labelCrewSize);
            Controls.Add(labelDesc);
            Controls.Add(labelStepNum);
            Controls.Add(labelStep);
            Controls.Add(labelID);
            Name = "MainForm";
            Text = "Bob's Construction Bid";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private Label labelStep;
        private Label labelStepNum;
        private Label labelDesc;
        private Label labelCrewSize;
        private Label labelHoursNeeded;
        private TextBox textID;
        private TextBox textDesc;
        private TextBox textCrewSize;
        private TextBox textHoursNeeded;
        private Button buttonNext;
        private Button buttonNew;
        private Button buttonExit;
        private Label PROJ_ID;
    }
}
