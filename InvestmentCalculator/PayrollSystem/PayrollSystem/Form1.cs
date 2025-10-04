namespace PayrollSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxPrincipal.Focus();
            labelValue.Visible = false;
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPrincipal.Text) || String.IsNullOrEmpty(textBoxYears.Text) || String.IsNullOrEmpty(textBoxRate.Text))
            {
                MessageBox.Show("Text boxes cannot be empty.");
                return;
            }
            else
            {
                if (double.TryParse(textBoxYears.Text, out double Years) && double.TryParse(textBoxRate.Text, out double Rate) && double.TryParse(textBoxPrincipal.Text, out double Principal))
                {
                    double FutureValue = Principal * Math.Pow((1 + (Rate / 100)), Years); // P*(1 + r/100)^n
                    labelValue.Visible = true;
                    labelValue.Text = $"${FutureValue:F2}";
                }
                else
                {
                    MessageBox.Show("Invalid Input. Hours Worked and Hourly Rate must be numeric.");
                }

                buttonNext.Focus();
            }

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            textBoxPrincipal.Clear();
            textBoxYears.Clear();
            textBoxRate.Clear();
            textBoxPrincipal.Focus();
            labelValue.Text = "";
            labelValue.Visible = false;
        }
    }
}
