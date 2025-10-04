namespace FantasyFootballStatsCalc
{
    public partial class FFStatsCalc : Form
    {
        private double _team_points;
        private int _player_num;
        Dictionary<string, double> _team_stats = new Dictionary<string, double>();
        private string _highest_points_name;
        private double _highest_points_stat;

        public FFStatsCalc()
        {
            _player_num = 1;
            _team_points = 0;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Close App?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                calcWinner();
                MessageBox.Show($"{_highest_points_name} wins with {_highest_points_stat:F2} points!", "THE WINNER!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            // if the first player, then solidify team name
            if (_player_num == 1) 
            { 
                TEAM_NAME.Text = teamNameText.Text;
                teamNameText.Visible = false;
                teamNameText.Enabled = false;
                TEAM_NAME.Visible = true;
            }

            // calculates points for player, shows it to the user, adds it to team points, increments player number
            double points = (Double.Parse(rushingText.Text) * 0.25) + (Double.Parse(recievingText.Text) * 0.35) + (Double.Parse(touchdownsText.Text) * 3.5);
            MessageBox.Show($"{nameBox.Text} earned {points:F2} points.", $"Player #{_player_num} Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _team_points += points;
            _player_num++;

            // clears boxes and refocuses at the player name
            nameBox.Focus();
            nameBox.Clear();
            rushingText.Clear();
            recievingText.Clear();
            touchdownsText.Clear();
            playerNumLabel.Text = $"Player #{_player_num}";

            // if 3 players have been implemented, reset.
            if (_player_num == 4) 
            {
                // team stats
                MessageBox.Show($"{TEAM_NAME.Text} earned {_team_points:F2} points.", "TEAM STATS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // add to dictionary
                _team_stats.Add(TEAM_NAME.Text, _team_points);

                // reset tools
                TEAM_NAME.Text = "Team Name";
                TEAM_NAME.Visible = false;
                teamNameText.Clear();
                teamNameText.Visible = true;
                teamNameText.Enabled = true;
                teamNameText.Focus();
                playerNumLabel.Text = "Player #1";

                // reset variables
                _team_points = 0;
                _player_num = 1;

            }
        }

        private void calcWinner() 
        {
            string winner = "";
            double highest = 0;
            foreach (var team in _team_stats) 
            { 
                if (team.Value >  highest) { highest = team.Value; winner = team.Key; }
            }

            _highest_points_name = winner;
            _highest_points_stat = highest;
        }

        private void FFStatsCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
