namespace PayrollSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxEName.Focus();
            labelGrossAmount.Visible = false;
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEName.Text) || String.IsNullOrEmpty(textBoxHoursWorked.Text) || String.IsNullOrEmpty(textBoxRate.Text))
            {
                MessageBox.Show("Text boxes cannot be empty.");
                return;
            }
            else
            {
                if (int.TryParse(textBoxHoursWorked.Text, out int HoursWorked) && double.TryParse(textBoxRate.Text, out double PayRate))
                {
                    double GrossPay = HoursWorked * PayRate;
                    labelGrossAmount.Visible = true;
                    labelGrossAmount.Text = $"${GrossPay.ToString():.2f}";
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
            textBoxEName.Clear();
            textBoxHoursWorked.Clear();
            textBoxRate.Clear();
            textBoxEName.Focus();
            labelGrossAmount.Text = "";
            labelGrossAmount.Visible = false;
        }
    }
}
