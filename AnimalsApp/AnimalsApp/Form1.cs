namespace AnimalsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDragon_Click(object sender, EventArgs e)
        {
            AnimalLabel.Text = "Dragon";
        }

        private void buttonUnicorn_Click(object sender, EventArgs e)
        {
            AnimalLabel.Text = "Unicorn";
        }

        private void buttonWerewolf_Click(object sender, EventArgs e)
        {
            AnimalLabel.Text = "Werewolf";
        }

        private void buttonCentaur_Click(object sender, EventArgs e)
        {
            AnimalLabel.Text = "Centaur";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AnimalLabel_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
