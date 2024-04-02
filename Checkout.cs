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
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Integrated_System_Project
{
    public partial class Checkout : Form
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-0F5U871\\SQLEXPRESS;Initial Catalog=ISPHaircutCenter;Integrated Security=True");

        public Checkout()
        {
            InitializeComponent();
        }

        public static decimal p1 = ProductService.product1;
        public static decimal p2 = ProductService.product2;
        public static decimal p3 = ProductService.product3;
        public static decimal p4 = ProductService.product4;
        public static decimal s1 = ProductService.service1;
        public static decimal s2 = ProductService.service2;
        public static decimal s3 = ProductService.service3;
        public static decimal s4 = ProductService.service4;

        private void btnBook_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmdInsert = new SqlCommand
            ("INSERT INTO [tblAppointment] (Name,Date,Time,Item,Total) values (@name,@date,@time, @item, @total)", sqlCon);//one shot line of command
            cmdInsert.Parameters.AddWithValue("@name", txtName.Text);
            cmdInsert.Parameters.AddWithValue("@date", Appointment.Text);
            cmdInsert.Parameters.AddWithValue("@time", txtTime.Text);
            if (p1 != 0)
            {
                if (p2 != 0)
                {
                    if (p3 != 0)
                    {
                        if (p4 != 0)
                        {
                            if (s1 != 0)
                            {
                                if (s2!=0)
                                {
                                    if (s3!=0)
                                    {
                                        if (s4!=0)
                                        {
                                            cmdInsert.Parameters.AddWithValue
                                            ("@item", ProductService.product1 + " BioRenew Hydrate Cocunut Milk Shampoo and Conditioner\n "
                                            + ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n "
                                            + ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                                            + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                            + ProductService.service1 + "Cutting\n"
                                            + ProductService.service2 + "Colouring\n"
                                            + ProductService.service3 + "Treatment\n" +
                                            ProductService.service4 +"Styling");
                                        }
                                        else
                                        {
                                            cmdInsert.Parameters.AddWithValue
                                            ("@item", ProductService.product1 + " BioRenew Hydrate Cocunut Milk Shampoo and Conditioner\n "
                                            + ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n "
                                            + ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                                            + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                            + ProductService.service1 + "Cutting\n"
                                            + ProductService.service2 + "Colouring\n"
                                            + ProductService.service3 + "Treatment");
                                        }
                                    }
                                    else
                                    {
                                        cmdInsert.Parameters.AddWithValue
                                    ("@item", ProductService.product1 + " BioRenew Hydrate Cocunut Milk Shampoo and Conditioner\n "
                                    + ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n "
                                    + ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                                    + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                    + ProductService.service1 + "Cutting\n"
                                    + ProductService.service2 + "Colouring");
                                    }

                                }
                                else
                                {
                                    cmdInsert.Parameters.AddWithValue
                                    ("@item", ProductService.product1 + " BioRenew Hydrate Cocunut Milk Shampoo and Conditioner\n "
                                    + ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n "
                                    + ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                                     + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                    + ProductService.service1 + "Cutting");
                                }
                            }
                            else
                            {
                                cmdInsert.Parameters.AddWithValue
                               ("@item", ProductService.product1 + " BioRenew Hydrate Cocunut Milk Shampoo and Conditioner\n "
                               + ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n "
                               + ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                               + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray");
                            }
                        }
                        else
                        {
                            cmdInsert.Parameters.AddWithValue
                            ("@item", ProductService.product1 + " BioRenew Hydrate Cocunut Milk Shampoo and Conditioner\n"
                            + ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n"
                            + ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream");
                        }
                    }
                    else
                    {
                        cmdInsert.Parameters.AddWithValue
                        ("@item", ProductService.product1 + " BioRenew Hydrate Cocunut Milk Shampoo and Conditioner\n"
                        + ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner");
                    }
                }
                else
                {
                    cmdInsert.Parameters.AddWithValue("@item", ProductService.product1 + " BioRenew Hydrate Cocunut Milk Shampoo and Conditioner");
                }
            }
            else if (p2 != 0)
            {
                if (p3 != 0)
                {
                    if (p4 != 0)
                    {
                        if (s1 != 0)
                        {
                            if (s2 != 0)
                            {
                                if (s3 != 0)
                                {
                                    if (s4 != 0)
                                    {
                                        cmdInsert.Parameters.AddWithValue
                                        ("@item", ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n "
                                        + ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                                        + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                        + ProductService.service1 + "Cutting\n"
                                        + ProductService.service2 + "Colouring\n"
                                        + ProductService.service3 + "Treatment\n" +
                                        ProductService.service4 + "Styling");
                                    }
                                    else
                                    {
                                        cmdInsert.Parameters.AddWithValue
                                        ("@item", ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n "
                                        + ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                                        + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                        + ProductService.service1 + "Cutting\n"
                                        + ProductService.service2 + "Colouring\n"
                                        + ProductService.service3 + "Treatment");
                                    }
                                }
                                else
                                {
                                    cmdInsert.Parameters.AddWithValue
                                ("@item", ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n "
                                + ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                                + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                + ProductService.service1 + "Cutting\n"
                                + ProductService.service2 + "Colouring");
                                }

                            }
                            else
                            {
                                cmdInsert.Parameters.AddWithValue
                                ("@item", ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n "
                                + ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                                 + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                + ProductService.service1 + "Cutting");
                            }
                        }
                        else
                        {
                            cmdInsert.Parameters.AddWithValue
                           ("@item", ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n "
                           + ProductService.product3 + " Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                           + ProductService.product4 + " Inforcer Brush Proof Anti-Breakage Detangling Spray");
                        }
                    }
                    else
                    {
                        cmdInsert.Parameters.AddWithValue
                        ("@item", ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner\n"
                        + ProductService.product3 + " Fructis Style Smooth Blow Dry Anti-Frizz Cream");
                    }
                }
                else
                {
                    cmdInsert.Parameters.AddWithValue
                    ("@item", ProductService.product2 + " Moisture Co-Wash Whipped Cleansing Conditioner");
                }
            }
            else if (p3 != 0)
            {
                if (p4 != 0)
                {
                    if (s1 != 0)
                    {
                        if (s2 != 0)
                        {
                            if (s3 != 0)
                            {
                                if (s4 != 0)
                                {
                                    cmdInsert.Parameters.AddWithValue
                                    ("@item", ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                                    + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                    + ProductService.service1 + "Cutting\n"
                                    + ProductService.service2 + "Colouring\n"
                                    + ProductService.service3 + "Treatment\n" +
                                    ProductService.service4 + "Styling");
                                }
                                else
                                {
                                    cmdInsert.Parameters.AddWithValue
                                    ("@item", ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                                    + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                    + ProductService.service1 + "Cutting\n"
                                    + ProductService.service2 + "Colouring\n"
                                    + ProductService.service3 + "Treatment");
                                }
                            }
                            else
                            {
                                cmdInsert.Parameters.AddWithValue
                            ("@item", ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                            + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                            + ProductService.service1 + "Cutting\n"
                            + ProductService.service2 + "Colouring");
                            }

                        }
                        else
                        {
                            cmdInsert.Parameters.AddWithValue
                            ("@item", ProductService.product3 + "Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                             + ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                            + ProductService.service1 + "Cutting");
                        }
                    }
                    else
                    {
                        cmdInsert.Parameters.AddWithValue
                       ("@item", ProductService.product3 + " Fructis Style Smooth Blow Dry Anti-Frizz Cream\n"
                       + ProductService.product4 + " Inforcer Brush Proof Anti-Breakage Detangling Spray");
                    }
                }
                else
                {
                    cmdInsert.Parameters.AddWithValue
                    ("@item",ProductService.product3 + " Fructis Style Smooth Blow Dry Anti-Frizz Cream");
                }
            }
            else if (p4 != 0)
            {
                if (s1 != 0)
                {
                    if (s2 != 0)
                    {
                        if (s3 != 0)
                        {
                            if (s4 != 0)
                            {
                                cmdInsert.Parameters.AddWithValue
                                ("@item", ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                + ProductService.service1 + "Cutting\n"
                                + ProductService.service2 + "Colouring\n"
                                + ProductService.service3 + "Treatment\n" +
                                ProductService.service4 + "Styling");
                            }
                            else
                            {
                                cmdInsert.Parameters.AddWithValue
                                ("@item", ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                                + ProductService.service1 + "Cutting\n"
                                + ProductService.service2 + "Colouring\n"
                                + ProductService.service3 + "Treatment");
                            }
                        }
                        else
                        {
                            cmdInsert.Parameters.AddWithValue
                        ("@item", ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                        + ProductService.service1 + "Cutting\n"
                        + ProductService.service2 + "Colouring");
                        }

                    }
                    else
                    {
                        cmdInsert.Parameters.AddWithValue
                        ("@item", ProductService.product4 + "Inforcer Brush Proof Anti-Breakage Detangling Spray\n"
                        + ProductService.service1 + "Cutting");
                    }
                }
                else
                {
                    cmdInsert.Parameters.AddWithValue
                   ("@item", ProductService.product4 + " Inforcer Brush Proof Anti-Breakage Detangling Spray");
                }
            }
            else if (s1 != 0)
            {
                if (s2 != 0)
                {
                    if (s3 != 0)
                    {
                        if (s4 != 0)
                        {
                            cmdInsert.Parameters.AddWithValue
                            ("@item", ProductService.service1 + "Cutting\n"
                            + ProductService.service2 + "Colouring\n"
                            + ProductService.service3 + "Treatment\n" +
                            ProductService.service4 + "Styling");
                        }
                        else
                        {
                            cmdInsert.Parameters.AddWithValue
                            ("@item", ProductService.service1 + "Cutting\n"
                            + ProductService.service2 + "Colouring\n"
                            + ProductService.service3 + "Treatment");
                        }
                    }
                    else
                    {
                        cmdInsert.Parameters.AddWithValue
                    ("@item", ProductService.service1 + "Cutting\n"
                    + ProductService.service2 + "Colouring");
                    }

                }
                else
                {
                    cmdInsert.Parameters.AddWithValue
                    ("@item", ProductService.service1 + "Cutting");
                }
            }
            else if (s2 != 0)
            {
                if (s3 != 0)
                {
                    if (s4 != 0)
                    {
                        cmdInsert.Parameters.AddWithValue
                        ("@item", ProductService.service2 + "Colouring\n"
                        + ProductService.service3 + "Treatment\n" +
                        ProductService.service4 + "Styling");
                    }
                    else
                    {
                        cmdInsert.Parameters.AddWithValue
                        ("@item", ProductService.service2 + "Colouring\n"
                        + ProductService.service3 + "Treatment");
                    }
                }
                else
                {
                    cmdInsert.Parameters.AddWithValue
                ("@item", ProductService.service2 + "Colouring");
                }

            }
            else if (s3 != 0)
            {
                if (s4 != 0)
                {
                    cmdInsert.Parameters.AddWithValue
                    ("@item", ProductService.service3 + "Treatment\n" +
                    ProductService.service4 + "Styling");
                }
                else
                {
                    cmdInsert.Parameters.AddWithValue
                    ("@item", ProductService.service3 + "Treatment");
                }
            }
            else if (s4 != 0)
            {
                cmdInsert.Parameters.AddWithValue
                ("@item", ProductService.service4 + "Styling");
            }
            cmdInsert.Parameters.AddWithValue("@total", Cart.finaltotal);
            cmdInsert.ExecuteNonQuery();//to execute the sql command for insert and update
            sqlCon.Close();
            MessageBox.Show("Booking Successful");
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("How Much Will You Pay ", "Input", "", 0, 0));
            if (input<Cart.finaltotal)
            {
                MessageBox.Show("Amount You Paid Is Less Than The Total Price Of All The Products Or Services You Bought.\nPlease enter again");
                return;
            }
            else
            {
                sqlCon.Open();
                SqlCommand cmdInsert = new SqlCommand
                ("INSERT INTO [tblAppointment] (Status, Change) values (@status,@change)", sqlCon);//one shot line of command
                cmdInsert.Parameters.AddWithValue("@status", "PAID");
                cmdInsert.Parameters.AddWithValue("@change", input - Cart.finaltotal);
                sqlCon.Close();
                MessageBox.Show("Here is your change: " + Convert.ToString(input-Cart.finaltotal));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
