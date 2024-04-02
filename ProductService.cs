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
    public partial class ProductService : Form
    {

        public ProductService()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out");
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        public static decimal product1 = 0;
        public static decimal product2 = 0;
        public static decimal product3 = 0;
        public static decimal product4 = 0;
        public static decimal service1 = 0;
        public static decimal service2 = 0;
        public static decimal service3 = 0;
        public static decimal service4 = 0;

        private void btnCart_Click(object sender, EventArgs e)
       {
            if (Np1.Value == 0 && Np2.Value == 0 && Np3.Value == 0 && Np4.Value == 0 
                && Ns1.Value == 0 && Ns2.Value == 0 && Ns3.Value == 0 && Ns4.Value == 0)
            {
                MessageBox.Show("No Products or Services Selected. Please Try Again");
                return;
            }
            else
            {
                MessageBox.Show("Adding to Cart");
                product1 = Decimal.ToInt32(Np1.Value);
                product2 = Decimal.ToInt32(Np2.Value);
                product3 = Decimal.ToInt32(Np3.Value);
                product4 = Decimal.ToInt32(Np4.Value);
                service1 = Decimal.ToInt32(Ns1.Value);
                service2 = Decimal.ToInt32(Ns2.Value);
                service3 = Decimal.ToInt32(Ns3.Value);
                service4 = Decimal.ToInt32(Ns4.Value);
                Cart cart = new Cart();
                cart.Show();
                this.Hide();
            }
        }
    }
}
