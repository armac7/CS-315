using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Tabulate(double depositAmount, int depositsPerYear, double annualRate, int numberOfYears) 
        {
            double anuityValue = 0, periodicRate = 0, annualDeposit = 0, annualInterest = 0, startValue = 0, periodicInterest = 0;
            int year = 0, period = 0; 

            Amount.Text = String.Format("{0, 7:C2}", depositAmount);
            Per_Year.Text = "" + depositsPerYear;
            Interest_Rate.Text = String.Format("{0, 6:P3}", annualRate);

            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].Name = "Year";
            dataGridView1.Columns[1].Name = "Start Balance";
            dataGridView1.Columns[2].Name = "Total Deposit";
            dataGridView1.Columns[3].Name = "Total Interest";
            dataGridView1.Columns[4].Name = "Ending Balance";

            anuityValue = 0;
            periodicRate = annualRate / 100 / depositsPerYear;

            for (year = 1; year <= numberOfYears; year++) 
            {
                annualDeposit = 0;
                annualInterest = 0;
                startValue = anuityValue;

                for (period = 1; period <= depositsPerYear; period++)
                {
                    periodicInterest = anuityValue * periodicRate;
                    annualInterest += periodicInterest;
                    annualDeposit += depositAmount;
                    anuityValue += periodicInterest + depositAmount;
                }

                string[] tableRow = { $"{year}",
                    String.Format("{0, 7:C2}", startValue),
                    String.Format("{0, 7:C2}", annualDeposit),
                    String.Format("{0, 7:C2}", annualInterest),
                    String.Format("{0, 7:C2}", anuityValue)};

                dataGridView1.Rows.Add(tableRow);
            }

            this.ShowDialog();
        }
    }
}
