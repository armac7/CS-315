namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        TableForm tableForm;

        public MainForm()
        {
            InitializeComponent();
            tableForm = new TableForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int depositsPerYear = 0, numberOfYears = 0;
            double depositAmount = 0, annualRate = 0;

            if (string.IsNullOrEmpty(amountIn.Text) || string.IsNullOrEmpty(depoIn.Text) || string.IsNullOrEmpty(interestIn.Text) || string.IsNullOrEmpty(lifeIn.Text)) 
            {
                MessageBox.Show("ERROR: Boxes cannot be null.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(amountIn.Text, out depositAmount))
            {
                MessageBox.Show("Please input a proper value for the amount.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(depoIn.Text, out depositsPerYear))
            {
                MessageBox.Show("Please input a proper value for the deposits per year.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(interestIn.Text, out annualRate))
            {
                MessageBox.Show("Please input a proper value for the annual rate (don't include the % sign).", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(lifeIn.Text, out numberOfYears)) 
            {
                MessageBox.Show("Please input a proper value for the number of years.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tableForm.Tabulate(depositAmount, depositsPerYear, annualRate, numberOfYears);

            amountIn.Clear(); amountIn.Focus();
            depoIn.Clear();
            interestIn.Clear();
            lifeIn.Clear();
            
        }
    }
}
