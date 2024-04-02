using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Integrated_System_Project
{
    public partial class Register : Form
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-0F5U871\\SQLEXPRESS;Initial Catalog=ISPHaircutCenter;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtHP.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtHP.Text = txtHP.Text.Remove(txtHP.Text.Length - 1);
            }
        }

        private void chkSPR_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSPR.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void chkConfirmSPR_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfirmSPR.Checked)
            {
                txtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirm.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(txtEmail.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email!");
            }
            else if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a username");
                return; // return because we don't want to run normal code of buton click
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter password");
                return; // return because we don't want to run normal code of buton click
            }
            else if (txtPassword.Text.Trim() != txtConfirm.Text.Trim())
            {
                MessageBox.Show("Password does not match");
                return; // return because we don't want to run normal code of buton click
            }
            else
            {
                sqlCon.Open();
                SqlCommand cmdInsert = new SqlCommand
                ("INSERT INTO [tblAccount] (Username, Password, Email, Country, HP) values (@user,@password, @email, @country, @hp)", sqlCon);//one shot line of command
                cmdInsert.Parameters.AddWithValue("@user", txtUsername.Text);
                cmdInsert.Parameters.AddWithValue("@password", txtPassword.Text);
                cmdInsert.Parameters.AddWithValue("@email", txtEmail.Text);
                cmdInsert.Parameters.AddWithValue("@country", HPStartNo.Text);
                cmdInsert.Parameters.AddWithValue("@HP", txtHP.Text);
                cmdInsert.ExecuteNonQuery();//to execute the sql command for insert and update
                sqlCon.Close();
                MessageBox.Show("Registration Complete");
                Login log = new Login();
                log.Show();
                this.Close();
            }
        }
    }
}
