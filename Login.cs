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

namespace Integrated_System_Project
{
    public partial class Login : Form
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-0F5U871\\SQLEXPRESS;Initial Catalog=ISPHaircutCenter;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void chkSPL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSPL.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [tblAccount] where Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "'", sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Success!");
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            sqlCon.Close();
        }
    }
}
