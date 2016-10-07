using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016002503_Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnCalcInterest_Click_Click(object sender, EventArgs e)
        {
            // Had trouble figuring out how to do this with the loan stuff under its own class, also didnt understand the use of the "create loan" button. Because of this i created this program without the loan class or the create loan button.
            // This isnt perfect, but hopefully it is good enough :)

            //IMPORTANT NOTE: This loan calculator assumes the loan is annual.
            DateTime startDate, endDate;
            startDate = startDateCLD.SelectionStart;
            endDate = endDateCLD.SelectionStart;

            string firstName;

            firstName = txtFirstName.Text;

            string lastName;

            lastName = txtLastName.Text;

            string loanText;

            loanText = txtLoanAmt.Text;
            double loanAmount = Double.Parse(loanText);

            string intrateText;

            intrateText = txtInterestRate.Text;
            double interestRate = Double.Parse(intrateText) / 100;


            double interest;

            double dateDifference;

            double dateCalc;

            double totalInterest;

            ///////////////////////////////////////////////

            interest = interestRate * loanAmount;

            dateCalc = 12 * (startDate.Year - endDate.Year) + (startDate.Month - endDate.Month);

            dateDifference = dateCalc - (dateCalc * 2);

            if (dateDifference >= 11)
                totalInterest = interest * 2;
            else
                totalInterest = interest;
                

            ///////////////////////////////////////////////

            txtSolutionBox.Text += "First Name: " + firstName + "\r\n";

            txtSolutionBox.Text += "Last Name: " + lastName + "\r\n";

            txtSolutionBox.Text += "Loan Amount: " + loanAmount + "\r\n";

            txtSolutionBox.Text += "Interest per year: " + interest.ToString() + "\r\n";

            txtSolutionBox.Text += "Total Interest: " + totalInterest.ToString() + "\r\n";

            txtSolutionBox.Text += "Start Date: " + startDate + "\r\n";

            txtSolutionBox.Text += "End Date: " + endDate + "\r\n";

            txtSolutionBox.Text += "Number of months: " + dateDifference + "\r\n";







        }

        public void startDateCLD_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        public void endDateCLD_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        public void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void txtLastName_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void txtSolutionBox_TextChanged(object sender, EventArgs e)
        {

        }        
    }    
}
