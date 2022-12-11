using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3App
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm(string username, string passwordD)
        {
            InitializeComponent();

            txtName.Text = username + " " + passwordD; //pass to the screen welcome form
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            double idNum = Convert.ToDouble(txtId.Text);
            double loanFee = Convert.ToDouble(txtLoanFee.Text);
            double Months = Convert.ToDouble(txtMonths.Text);
            double IntRate = Convert.ToDouble(txtRate.Text);
            double totalLoan=0;
            txtOutput.Text = totalLoan.ToString();
            double perc = 5;
            if (loanType.Text == "Home")
            {
                perc = 10;
            }
            if (loanType.Text == "Personal")
            {
                perc = 5;
            }
            if (loanType.Text == "Vehicle")
            {
                perc = 15;
            }
            totalLoan = loanFee + (loanFee*IntRate/Months);
            txtOutput.Text = totalLoan.ToString();
        }

        private void loanTyoe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
