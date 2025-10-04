namespace BobsBurgerBarn
{
    public partial class MainForm : Form
    {
        private int orderCount = 0;
        private double totalCost = 0;
        private double smallestOrder = 100000;
        private double largestOrder = 0;
        private SummaryForm summaryForm = new SummaryForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            
            OrderForm orderForm = new OrderForm();

            orderForm.callForm(summaryForm);
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            summaryForm.ShowDialog() ;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            summaryForm.ShowDialog();
            Application.Exit();
        }
    }
}
