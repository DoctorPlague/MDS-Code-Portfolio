using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016002503_Lab_2
{
    public partial class Form1 : Form
    {        
        DateTime Date = DateTime.Today;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime Birthdate = calendar.SelectionStart;
            
        }

        public void calc_button_Click(object sender, EventArgs e)
        {
            DateTime Birthdate = calendar.SelectionStart;

            int age = (int)((DateTime.Now - Birthdate).TotalDays);
            
            daysTextBox.Text = age.ToString();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
