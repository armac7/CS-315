namespace LoanAmortization
{
    public partial class MainForm : Form
    {
        payoffForm payoffForm;
        public MainForm()
        {
            InitializeComponent();
            payoffForm = new payoffForm();
        }

        private void amortizeButton_Click(object sender, EventArgs e)
        {
            double loanAmt = 0, intRate = 0, payment = 0;

            if (!inputExists()) { return; }
            else if (!validInput(ref loanAmt, ref intRate, ref payment)) { return; }
            else if (!validPayment(loanAmt, intRate, payment)) { return; }

            payoffForm.Amortize(loanAmt, intRate, payment);

            loanIn.Focus();
            loanIn.Clear();
            rateIn.Clear();
            paymentIn.Clear();
        }

        private bool inputExists()
        {
            string result = "Please input the ";
            bool empty = false;
            if (String.IsNullOrEmpty(loanIn.Text))
            {
                result += "initial balance";
                empty = true;
            }
            if (String.IsNullOrEmpty(rateIn.Text))
            {
                if (empty == true) result += ", ";
                result += "annual interest rate";
                if (!empty) empty = true;
            }
            if (String.IsNullOrEmpty(paymentIn.Text))
            {
                if (empty == true) result += ", and ";
                result += "monthly payment";
                if (!empty) empty = true;
            }

            if (empty == true)
            {
                result += ".";
                MessageBox.Show(result, "Invalid Input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return !empty;
        }

        private bool validInput(ref double loanAmt, ref double intRate, ref double payment)
        {
            //MessageBox.Show($"In validInput({loanAmt}, {intRate}, {payment})");
            bool valid = false;
            bool invalid = false;
            string result = "Please make sure that ";
            if (!double.TryParse(loanIn.Text, out loanAmt))
            {
                result += "initial balance";
                invalid = true;
            }
            if (!double.TryParse(rateIn.Text, out intRate))
            {
                if (invalid == true) result += ", ";
                result += "interest rate";
                if (invalid != true) invalid = true;
            }
            if (!double.TryParse(paymentIn.Text, out payment))
            {
                if (invalid == true) result += ", and ";
                result += "monthly payment";
                if (invalid != true) invalid = true;
            }
            result += " are numeric.";
            
            if (!invalid) valid = true;
            else if (!valid)
            {
                MessageBox.Show(result, "Invalid Input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valid;
        }

        private bool validPayment(double loanAmt, double intRate, double payment) 
        {
            //MessageBox.Show($"In validPayment({loanAmt}, {intRate}, {payment})");
            bool valid = false;
            if (((loanAmt * intRate) / 1200) > payment)
                MessageBox.Show("Monthly payment is too small.", "Invalid Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else valid = true;
            return valid;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
