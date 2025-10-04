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
    public partial class SummaryForm : Form
    {
        private int orderCount = 0;
        private double totalCost = 0;
        private double smallestOrder = 12345;
        private double largestOrder = 0;
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //placedLabel.Text = $"{orderCount}";
            //totalLabel.Text = $"{totalCost:C2}";
            //if (!(smallestOrder == 12345)) { smallestLabel.Text = $"{smallestOrder:C2}"; }
            //else smallestLabel.Text = $"$0.00";
            //largestLabel.Text = $"{largestOrder:C2}";
        }

        public void UpdateOrderCount()
        {
            orderCount++;
            placedLabel.Text = $"{orderCount}";
        }
        public void UpdateTotalCost(double cost)
        {
            totalCost += cost;
            totalLabel.Text = $"{totalCost:C2}";
            UpdateSmallestOrder(cost);
            UpdateLargestOrder(cost);
        }
        public void UpdateSmallestOrder(double order)
        {
            if (order < smallestOrder) setSmallestOrder(order);
            //MessageBox.Show($"In smallest order: {order}, {smallestOrder}");
            if (!(order == 10000)) smallestLabel.Text = $"{smallestOrder:C2}";
        }
        public void UpdateLargestOrder(double order)
        {
            if (order > largestOrder) setLargestOrder(order);
            largestLabel.Text = $"{largestOrder:C2}";
        }

        private void setOrderCount(int count) { orderCount = count; }
        private void setTotalCost(double cost) { totalCost = cost; }
        private void setSmallestOrder(double order) { smallestOrder = order; }
        private void setLargestOrder(double order) { largestOrder = order; }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
