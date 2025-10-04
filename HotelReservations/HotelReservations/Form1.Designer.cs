namespace HotelReservations
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
            nameLabel = new Label();
            checkInLabel = new Label();
            numNightsLabel = new Label();
            numRoomsLabel = new Label();
            nameIn = new TextBox();
            checkinIn = new TextBox();
            numNightsIn = new TextBox();
            numRoomsIn = new TextBox();
            roomPanel = new Panel();
            label6 = new Label();
            SUKING = new RadioButton();
            SU2Q = new RadioButton();
            STKING = new RadioButton();
            ST2Q = new RadioButton();
            label5 = new Label();
            reserveButton = new Button();
            summaryButton = new Button();
            roomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(55, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(94, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Customer Name";
            // 
            // checkInLabel
            // 
            checkInLabel.AutoSize = true;
            checkInLabel.Location = new Point(55, 74);
            checkInLabel.Name = "checkInLabel";
            checkInLabel.Size = new Size(82, 15);
            checkInLabel.TabIndex = 1;
            checkInLabel.Text = "Check-In Date";
            // 
            // numNightsLabel
            // 
            numNightsLabel.AutoSize = true;
            numNightsLabel.Location = new Point(278, 74);
            numNightsLabel.Name = "numNightsLabel";
            numNightsLabel.Size = new Size(66, 15);
            numNightsLabel.TabIndex = 2;
            numNightsLabel.Text = "# of Nights";
            // 
            // numRoomsLabel
            // 
            numRoomsLabel.AutoSize = true;
            numRoomsLabel.Location = new Point(55, 103);
            numRoomsLabel.Name = "numRoomsLabel";
            numRoomsLabel.Size = new Size(68, 15);
            numRoomsLabel.TabIndex = 3;
            numRoomsLabel.Text = "# of Rooms";
            // 
            // nameIn
            // 
            nameIn.Location = new Point(155, 37);
            nameIn.Name = "nameIn";
            nameIn.Size = new Size(295, 23);
            nameIn.TabIndex = 4;
            // 
            // checkinIn
            // 
            checkinIn.Location = new Point(155, 66);
            checkinIn.Name = "checkinIn";
            checkinIn.Size = new Size(100, 23);
            checkinIn.TabIndex = 5;
            // 
            // numNightsIn
            // 
            numNightsIn.Location = new Point(350, 66);
            numNightsIn.Name = "numNightsIn";
            numNightsIn.Size = new Size(100, 23);
            numNightsIn.TabIndex = 6;
            // 
            // numRoomsIn
            // 
            numRoomsIn.Location = new Point(155, 95);
            numRoomsIn.Name = "numRoomsIn";
            numRoomsIn.Size = new Size(100, 23);
            numRoomsIn.TabIndex = 7;
            // 
            // roomPanel
            // 
            roomPanel.Controls.Add(label6);
            roomPanel.Controls.Add(SUKING);
            roomPanel.Controls.Add(SU2Q);
            roomPanel.Controls.Add(STKING);
            roomPanel.Controls.Add(ST2Q);
            roomPanel.Controls.Add(label5);
            roomPanel.Location = new Point(55, 136);
            roomPanel.Name = "roomPanel";
            roomPanel.Size = new Size(395, 100);
            roomPanel.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 11);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 5;
            label6.Text = "Suite";
            // 
            // SUKING
            // 
            SUKING.AutoSize = true;
            SUKING.Location = new Point(224, 66);
            SUKING.Name = "SUKING";
            SUKING.Size = new Size(49, 19);
            SUKING.TabIndex = 4;
            SUKING.TabStop = true;
            SUKING.Text = "King";
            SUKING.UseVisualStyleBackColor = true;
            // 
            // SU2Q
            // 
            SU2Q.AutoSize = true;
            SU2Q.Location = new Point(223, 32);
            SU2Q.Name = "SU2Q";
            SU2Q.Size = new Size(89, 19);
            SU2Q.TabIndex = 3;
            SU2Q.TabStop = true;
            SU2Q.Text = "Two Queens";
            SU2Q.UseVisualStyleBackColor = true;
            // 
            // STKING
            // 
            STKING.AutoSize = true;
            STKING.Location = new Point(14, 66);
            STKING.Name = "STKING";
            STKING.Size = new Size(49, 19);
            STKING.TabIndex = 2;
            STKING.TabStop = true;
            STKING.Text = "King";
            STKING.UseVisualStyleBackColor = true;
            // 
            // ST2Q
            // 
            ST2Q.AutoSize = true;
            ST2Q.Location = new Point(14, 32);
            ST2Q.Name = "ST2Q";
            ST2Q.Size = new Size(89, 19);
            ST2Q.TabIndex = 1;
            ST2Q.TabStop = true;
            ST2Q.Text = "Two Queens";
            ST2Q.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 11);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 0;
            label5.Text = "Standard";
            // 
            // reserveButton
            // 
            reserveButton.Location = new Point(155, 261);
            reserveButton.Name = "reserveButton";
            reserveButton.Size = new Size(210, 43);
            reserveButton.TabIndex = 9;
            reserveButton.Text = "Make Reservation";
            reserveButton.UseVisualStyleBackColor = true;
            reserveButton.Click += reserveButton_Click;
            // 
            // summaryButton
            // 
            summaryButton.Location = new Point(155, 310);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(210, 43);
            summaryButton.TabIndex = 10;
            summaryButton.Text = "Daily Summary";
            summaryButton.UseVisualStyleBackColor = true;
            summaryButton.Click += summaryButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 368);
            Controls.Add(summaryButton);
            Controls.Add(reserveButton);
            Controls.Add(roomPanel);
            Controls.Add(numRoomsIn);
            Controls.Add(numNightsIn);
            Controls.Add(checkinIn);
            Controls.Add(nameIn);
            Controls.Add(numRoomsLabel);
            Controls.Add(numNightsLabel);
            Controls.Add(checkInLabel);
            Controls.Add(nameLabel);
            Name = "Form1";
            Text = "Bob's Hotels & Suites";
            roomPanel.ResumeLayout(false);
            roomPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label checkInLabel;
        private Label numNightsLabel;
        private Label numRoomsLabel;
        private TextBox nameIn;
        private TextBox checkinIn;
        private TextBox numNightsIn;
        private TextBox numRoomsIn;
        private Panel roomPanel;
        private Label label6;
        private RadioButton SUKING;
        private RadioButton SU2Q;
        private RadioButton STKING;
        private RadioButton ST2Q;
        private Label label5;
        private Button reserveButton;
        private Button summaryButton;
    }
}
