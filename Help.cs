using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Integrated_System_Project
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btnFP_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Your Email: ", "Input", "", 0, 0);
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(input.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email!");
            }
            else
            {
                string message = "Your email is " + input;
                string title = "Email Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
                else if (result == DialogResult.Yes)
                {
                    MessageBox.Show("A Password Reset Link Has Been Sent To Your Email");
                    this.Close();
                }
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Number : +604-1234567" +
                "\nEmail : abcdefg@gmail.com" +
                "\nAddress : 123,taman abc,jalan cde,11890 bayan lepas, penang");
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Our Operating Hour : 24/7(Closed on Public Holiday)" +
                "\nIf I Have Questions Who Should I Contact : +604-1234567" +
                "\nAre Animals or Pets Allowed Inside : Only Service Animals Are Allowed Inside" +
                "\nWhere Do I Park My Vehicle(s) : We Have A Carpark For Our Customers");
        }
    }
}
