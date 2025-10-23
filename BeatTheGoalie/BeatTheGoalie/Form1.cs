using static System.Windows.Forms.LinkLabel;

namespace BeatTheGoalie
{
    public partial class MainForm : Form
    {
        Rink rink;
        GoalStick gs;
        Puck p;
        bool started = false;
        int goalCount = 0, shotCount = 0;
        Random random;
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g;
            timer1.Enabled = false;
            saveLabel.Left = this.Width - saveLabel.Width - 10;
            goalLabel.Left = this.Width - goalLabel.Width - 10;

            panel1.Left = this.Width - panel1.Width - 10;
            panel1.Top = this.Height - panel1.Height - 40;

            using (g = this.CreateGraphics())
            {
                rink = new Rink(g, this.Width, this.Height, out gs);
            }

            started = true;
            timer2.Enabled = true;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g;
            if (started) // make sure the rink has been initialized
            {
                using (g = this.CreateGraphics())
                    gs.Move(g, e.Y);
                Refresh();
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            if (started)
            {
                using (g = this.CreateGraphics())
                {
                    rink.Draw(g);
                    gs.Draw(g);
                    // make sure there is a puck to be drawn
                    if (p != null)
                        p.Draw(g);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Graphics g;
            timer2.Enabled = false;
            goalLabel.Visible = false;
            saveLabel.Visible = false;

            using (g = this.CreateGraphics())
            {
                p = new Puck(g, this, this.Width, this.Height, rink, random);
                p.Draw(g);
            }

            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            p.Move();
            Refresh();
        }

        public void UpdateScoreboard(int xPosn, int yPosn, int puckRadius)
        {
            timer3.Enabled = false;
            shotCount++;
            shotsLabel.Text = shotCount.ToString();
            if (gs.Scored(xPosn, yPosn, puckRadius))
            {
                goalCount++;
                goalLabel.Visible = true;
                scoreLabel.Text = goalCount.ToString();
            }
            else
            {
                saveLabel.Visible = true;
            }

            timer2.Enabled = true;
        }
    }
}
