namespace Paint
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
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            brushToolStripMenuItem = new ToolStripMenuItem();
            penToolStripMenuItem = new ToolStripMenuItem();
            shapeToolStripMenuItem = new ToolStripMenuItem();
            lineToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            ellipseToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, colorToolStripMenuItem, shapeToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(43, 20);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { brushToolStripMenuItem, penToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(48, 20);
            colorToolStripMenuItem.Text = "Color";
            // 
            // brushToolStripMenuItem
            // 
            brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            brushToolStripMenuItem.Size = new Size(104, 22);
            brushToolStripMenuItem.Text = "Brush";
            brushToolStripMenuItem.Click += brushToolStripMenuItem_Click;
            // 
            // penToolStripMenuItem
            // 
            penToolStripMenuItem.Name = "penToolStripMenuItem";
            penToolStripMenuItem.Size = new Size(104, 22);
            penToolStripMenuItem.Text = "Pen";
            penToolStripMenuItem.Click += penToolStripMenuItem_Click;
            // 
            // shapeToolStripMenuItem
            // 
            shapeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lineToolStripMenuItem, rectangleToolStripMenuItem, ellipseToolStripMenuItem });
            shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            shapeToolStripMenuItem.Size = new Size(51, 20);
            shapeToolStripMenuItem.Text = "Shape";
            // 
            // lineToolStripMenuItem
            // 
            lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            lineToolStripMenuItem.Size = new Size(126, 22);
            lineToolStripMenuItem.Text = "Line";
            lineToolStripMenuItem.Click += lineToolStripMenuItem_Click;
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(126, 22);
            rectangleToolStripMenuItem.Text = "Rectangle";
            rectangleToolStripMenuItem.Click += rectangleToolStripMenuItem_Click;
            // 
            // ellipseToolStripMenuItem
            // 
            ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            ellipseToolStripMenuItem.Size = new Size(126, 22);
            ellipseToolStripMenuItem.Text = "Ellipse";
            ellipseToolStripMenuItem.Click += ellipseToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Paint Shop Amateur";
            WindowState = FormWindowState.Maximized;
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem brushToolStripMenuItem;
        private ToolStripMenuItem penToolStripMenuItem;
        private ToolStripMenuItem shapeToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem lineToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem ellipseToolStripMenuItem;
        private ColorDialog colorDialog1;
    }
}
