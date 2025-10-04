using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobsBurgerBarn
{
    public partial class OrderForm : Form
    {
        private const double HAMBURGER_COST = 1.59;
        private const double FRIES_COST = .89;
        private const double DRINK_COST = .99;
        private SummaryForm summaryForm;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int burgers, fries, drinks;

            if (string.IsNullOrEmpty(burgerIn.Text)) burgers = 0;
            else if (!int.TryParse(burgerIn.Text, out burgers))
            { 
                MessageBox.Show("Please enter a valid number for total hamburgers.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(friesIn.Text)) fries = 0;
            else if (!int.TryParse(friesIn.Text,out fries))
            {
                MessageBox.Show("Please enter a valid number for total fries.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(drinksIn.Text)) drinks = 0;
            else if (!int.TryParse(drinksIn.Text,out drinks))
            {
                MessageBox.Show("Please enter a valid number for total drinks.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double cost = (burgers * HAMBURGER_COST) + (fries * FRIES_COST) + (drinks * DRINK_COST);
            summaryForm.UpdateOrderCount();
            summaryForm.UpdateTotalCost(cost);

            MessageBox.Show($"Total for this order: {cost:C2}.", "Order Summary",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        public void callForm(SummaryForm summaryForm) 
        {
            this.summaryForm = summaryForm; 
            this.ShowDialog();
        }
    }
}
