using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanAmortization
{
    public partial class payoffForm : Form
    {
        public payoffForm()
        {
            InitializeComponent();
            CreateTable();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Schedule.Rows.Clear();
            Close();
        }

        public void Amortize(double loanAmt, double intRate, double payment) 
        {
            loanLabel.Text = $"{loanAmt:C2}";
            rateLabel.Text = $"{(intRate / 100):P2}";
            paymentLabel.Text = $"{payment:C2}";

            int month = 1;
            double monthlyRate = intRate / 1200;
            double startBal = loanAmt, endBal = 0;
            double interest = 0;
            double principal = 0;

            FillTable(loanAmt, intRate, payment, month, monthlyRate, startBal, endBal, interest, principal);

            this.ShowDialog();
        }

        private void CreateTable()
        {
            Schedule.ColumnCount = 6;
            Schedule.Columns[0].Name = "Months";
            Schedule.Columns[1].Name = "Start Balance";
            Schedule.Columns[2].Name = "Payment";
            Schedule.Columns[3].Name = "Interest";
            Schedule.Columns[4].Name = "Principal";
            Schedule.Columns[5].Name = "End Balance";
        }

        private void FillTable(double loanAmt, double intRate, double payment, 
            int month, 
            double monthlyRate, 
            double startBal, 
            double endBal, 
            double interest, 
            double principal) 
        {
            while (startBal > 0)
            {
                interest = monthlyRate * startBal;
                principal = payment - interest;
                endBal = startBal - principal;

                if (endBal < 0)
                {
                    principal = startBal;
                    payment = interest + startBal;
                    endBal = 0;
                }

                string[] Row = {String.Format("{0,5}", month),
                String.Format("{0,7:C2}", startBal),
                String.Format("{0,7:C2}", payment),
                String.Format("{0,7:C2}", interest),
                String.Format("{0,7:C2}", principal),
                String.Format("{0,7:C2}", endBal)};

                Schedule.Rows.Add(Row);
                month++;
                startBal = endBal;
            }
        }
    }
}
