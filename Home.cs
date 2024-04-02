using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_System_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out");
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnPS_Click(object sender, EventArgs e)
        {
            ProductService ps = new ProductService();
            ps.Show();
            this.Hide();
        }
    }
}
