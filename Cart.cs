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
    public partial class Cart : Form
    {
        public Cart()
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
        public static double finaltotal 
        = Convert.ToDouble
          (
           (67 * ProductService.product1) + (85 * ProductService.product2) + (34 * ProductService.product3) + (84 * ProductService.product4)
           + (50 * ProductService.service1) + (350 * ProductService.service2) + (550 * ProductService.service3) + (50 * ProductService.service4)
          );

        private void Cart_Load(object sender, EventArgs e)
        {
            //1st label
            if (p1!=0)
            {
                //adding label name
                Label lblItem1 = new Label
                {
                    Text = "BioRenew Hydrate Cocunut Milk Shampoo and Conditioner",
                    Location = new Point(60, 119),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount1 = new Label
                {
                    Text = Convert.ToString(ProductService.product1),
                    Location = new Point(548, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem1 = new Label
                {
                    Text = "RM 67.00",
                    Location = new Point(819, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal1 = new Label
                {
                    Text = Convert.ToString(67 * ProductService.product1),
                    Location = new Point(1146, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem1);
                this.Controls.Add(lblAmount1);
                this.Controls.Add(lblPricePerItem1);
                this.Controls.Add(lblTotal1);

                p1 = 0;
            }
            else if (p2 != 0)
            {
                //adding label name
                Label lblItem1 = new Label
                {
                    Text = "Moisture Co-Wash Whipped Cleansing Conditioner",
                    Location = new Point(60, 119),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount1 = new Label
                {
                    Text = Convert.ToString(ProductService.product2),
                    Location = new Point(548, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem1 = new Label
                {
                    Text = "RM 85.00",
                    Location = new Point(819, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal1 = new Label
                {
                    Text = Convert.ToString(85 * ProductService.product2),
                    Location = new Point(1146, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem1);
                this.Controls.Add(lblAmount1);
                this.Controls.Add(lblPricePerItem1);
                this.Controls.Add(lblTotal1);

                p2 = 0;
            }
            else if (p3 != 0)
            {
                //adding label name
                Label lblItem1 = new Label
                {
                    Text = "Fructis Style Smooth Blow Dry Anti-Frizz Cream",
                    Location = new Point(60, 119),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount1 = new Label
                {
                    Text = Convert.ToString(ProductService.product3),
                    Location = new Point(548, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem1 = new Label
                {
                    Text = "RM 34.00",
                    Location = new Point(819, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal1 = new Label
                {
                    Text = Convert.ToString(34 * ProductService.product3),
                    Location = new Point(1146, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem1);
                this.Controls.Add(lblAmount1);
                this.Controls.Add(lblPricePerItem1);
                this.Controls.Add(lblTotal1);

                p3 = 0;
            }
            else if (p4 != 0)
            {
                //adding label name
                Label lblItem1 = new Label
                {
                    Text = "Inforcer Brush Proof Anti-Breakage Detangling Spray",
                    Location = new Point(60, 119),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount1 = new Label
                {
                    Text = Convert.ToString(ProductService.product4),
                    Location = new Point(548, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem1 = new Label
                {
                    Text = "RM 84.00",
                    Location = new Point(819, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal1 = new Label
                {
                    Text = Convert.ToString(84 * ProductService.product4),
                    Location = new Point(1146, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem1);
                this.Controls.Add(lblAmount1);
                this.Controls.Add(lblPricePerItem1);
                this.Controls.Add(lblTotal1);

                p4 = 0;
            }
            else if (s1 != 0)
            {
                //adding label name
                Label lblItem1 = new Label
                {
                    Text = "Hair Cut",
                    Location = new Point(60, 119),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount1 = new Label
                {
                    Text = Convert.ToString(ProductService.service1),
                    Location = new Point(548, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem1 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal1 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service1),
                    Location = new Point(1146, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem1);
                this.Controls.Add(lblAmount1);
                this.Controls.Add(lblPricePerItem1);
                this.Controls.Add(lblTotal1);

                s1 = 0;
            }
            else if (s2 != 0)
            {
                //adding label name
                Label lblItem1 = new Label
                {
                    Text = "Colouring",
                    Location = new Point(60, 119),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount1 = new Label
                {
                    Text = Convert.ToString(ProductService.service2),
                    Location = new Point(548, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem1 = new Label
                {
                    Text = "RM350.00",
                    Location = new Point(819, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal1 = new Label
                {
                    Text = Convert.ToString(350 * ProductService.service2),
                    Location = new Point(1146, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem1);
                this.Controls.Add(lblAmount1);
                this.Controls.Add(lblPricePerItem1);
                this.Controls.Add(lblTotal1);

                s2 = 0;
            }
            else if (s3 != 0)
            {
                //adding label name
                Label lblItem1 = new Label
                {
                    Text = "Treatment",
                    Location = new Point(60, 119),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount1 = new Label
                {
                    Text = Convert.ToString(ProductService.service3),
                    Location = new Point(548, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem1 = new Label
                {
                    Text = "RM550.00",
                    Location = new Point(819, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal1 = new Label
                {
                    Text = Convert.ToString(550 * ProductService.service3),
                    Location = new Point(1146, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem1);
                this.Controls.Add(lblAmount1);
                this.Controls.Add(lblPricePerItem1);
                this.Controls.Add(lblTotal1);

                s3 = 0;
            }
            else if (s4 != 0)
            {
                //adding label name
                Label lblItem1 = new Label
                {
                    Text = "Styling",
                    Location = new Point(60, 119),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount1 = new Label
                {
                    Text = Convert.ToString(ProductService.service4),
                    Location = new Point(548, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem1 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal1 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service4),
                    Location = new Point(1146, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem1);
                this.Controls.Add(lblAmount1);
                this.Controls.Add(lblPricePerItem1);
                this.Controls.Add(lblTotal1);

                s4 = 0;
            }

            //2nd label
            if (p2 != 0)
            {
                //adding label name
                Label lblItem2 = new Label
                {
                    Text = "Moisture Co-Wash Whipped Cleansing Conditioner",
                    Location = new Point(60, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount2 = new Label
                {
                    Text = Convert.ToString(ProductService.product2),
                    Location = new Point(548, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem2 = new Label
                {
                    Text = "RM 85.00",
                    Location = new Point(819, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal2 = new Label
                {
                    Text = Convert.ToString(85 * ProductService.product2),
                    Location = new Point(1146, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem2);
                this.Controls.Add(lblAmount2);
                this.Controls.Add(lblPricePerItem2);
                this.Controls.Add(lblTotal2);

                p2 = 0;
            }
            else if (p3 != 0)
            {
                //adding label name
                Label lblItem2 = new Label
                {
                    Text = "Fructis Style Smooth Blow Dry Anti-Frizz Cream",
                    Location = new Point(60, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount2 = new Label
                {
                    Text = Convert.ToString(ProductService.product3),
                    Location = new Point(548, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem2 = new Label
                {
                    Text = "RM 34.00",
                    Location = new Point(819, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal2 = new Label
                {
                    Text = Convert.ToString(34 * ProductService.product3),
                    Location = new Point(1146, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem2);
                this.Controls.Add(lblAmount2);
                this.Controls.Add(lblPricePerItem2);
                this.Controls.Add(lblTotal2);

                p3 = 0;
            }
            else if (p4 != 0)
            {
                //adding label name
                Label lblItem2 = new Label
                {
                    Text = "Inforcer Brush Proof Anti-Breakage Detangling Spray",
                    Location = new Point(60, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount2 = new Label
                {
                    Text = Convert.ToString(ProductService.product4),
                    Location = new Point(548, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem2 = new Label
                {
                    Text = "RM 84.00",
                    Location = new Point(819, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal2 = new Label
                {
                    Text = Convert.ToString(84 * ProductService.product4),
                    Location = new Point(1146, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem2);
                this.Controls.Add(lblAmount2);
                this.Controls.Add(lblPricePerItem2);
                this.Controls.Add(lblTotal2);

                p4 = 0;
            }
            else if (s1 != 0)
            {
                //adding label name
                Label lblItem2 = new Label
                {
                    Text = "Hair Cut",
                    Location = new Point(60, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount2 = new Label
                {
                    Text = Convert.ToString(ProductService.service1),
                    Location = new Point(548, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem2 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal2 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service1),
                    Location = new Point(1146, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem2);
                this.Controls.Add(lblAmount2);
                this.Controls.Add(lblPricePerItem2);
                this.Controls.Add(lblTotal2);

                s1 = 0;
            }
            else if (s2 != 0)
            {
                //adding label name
                Label lblItem2 = new Label
                {
                    Text = "Colouring",
                    Location = new Point(60, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount2 = new Label
                {
                    Text = Convert.ToString(ProductService.service2),
                    Location = new Point(548, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem2 = new Label
                {
                    Text = "RM350.00",
                    Location = new Point(819, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal2 = new Label
                {
                    Text = Convert.ToString(350 * ProductService.service2),
                    Location = new Point(1146, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem2);
                this.Controls.Add(lblAmount2);
                this.Controls.Add(lblPricePerItem2);
                this.Controls.Add(lblTotal2);

                s2 = 0;
            }
            else if (s3 != 0)
            {
                //adding label name
                Label lblItem2 = new Label
                {
                    Text = "Treatment",
                    Location = new Point(60, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount2 = new Label
                {
                    Text = Convert.ToString(ProductService.service3),
                    Location = new Point(548, 122),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem2 = new Label
                {
                    Text = "RM550.00",
                    Location = new Point(819, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal2 = new Label
                {
                    Text = Convert.ToString(550 * ProductService.service3),
                    Location = new Point(1146, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem2);
                this.Controls.Add(lblAmount2);
                this.Controls.Add(lblPricePerItem2);
                this.Controls.Add(lblTotal2);

                s3 = 0;
            }
            else if (s4 != 0)
            {
                //adding label name
                Label lblItem2 = new Label
                {
                    Text = "Styling",
                    Location = new Point(60, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount2 = new Label
                {
                    Text = Convert.ToString(ProductService.service4),
                    Location = new Point(548, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem2 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal2 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service4),
                    Location = new Point(1146, 149),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem2);
                this.Controls.Add(lblAmount2);
                this.Controls.Add(lblPricePerItem2);
                this.Controls.Add(lblTotal2);

                s4 = 0;
            }

            //3rd label
            if (p3 != 0)
            {
                //adding label name
                Label lblItem3 = new Label
                {
                    Text = "Fructis Style Smooth Blow Dry Anti-Frizz Cream",
                    Location = new Point(60, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount3 = new Label
                {
                    Text = Convert.ToString(ProductService.product3),
                    Location = new Point(548, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem3 = new Label
                {
                    Text = "RM 34.00",
                    Location = new Point(819, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal3 = new Label
                {
                    Text = Convert.ToString(34 * ProductService.product3),
                    Location = new Point(1146, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem3);
                this.Controls.Add(lblAmount3);
                this.Controls.Add(lblPricePerItem3);
                this.Controls.Add(lblTotal3);

                p3 = 0;
            }
            else if (p4 != 0)
            {
                //adding label name
                Label lblItem3 = new Label
                {
                    Text = "Inforcer Brush Proof Anti-Breakage Detangling Spray",
                    Location = new Point(60, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount3 = new Label
                {
                    Text = Convert.ToString(ProductService.product4),
                    Location = new Point(548, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem3 = new Label
                {
                    Text = "RM 84.00",
                    Location = new Point(819, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal3 = new Label
                {
                    Text = Convert.ToString(84 * ProductService.product4),
                    Location = new Point(1146, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem3);
                this.Controls.Add(lblAmount3);
                this.Controls.Add(lblPricePerItem3);
                this.Controls.Add(lblTotal3);

                p4 = 0;
            }
            else if (s1 != 0)
            {
                //adding label name
                Label lblItem3 = new Label
                {
                    Text = "Hair Cut",
                    Location = new Point(60, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount3 = new Label
                {
                    Text = Convert.ToString(ProductService.service1),
                    Location = new Point(548, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem3 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal3 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service1),
                    Location = new Point(1146, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem3);
                this.Controls.Add(lblAmount3);
                this.Controls.Add(lblPricePerItem3);
                this.Controls.Add(lblTotal3);

                s1 = 0;
            }
            else if (s2 != 0)
            {
                //adding label name
                Label lblItem3 = new Label
                {
                    Text = "Colouring",
                    Location = new Point(60, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount3 = new Label
                {
                    Text = Convert.ToString(ProductService.service2),
                    Location = new Point(548, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem3 = new Label
                {
                    Text = "RM350.00",
                    Location = new Point(819, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal3 = new Label
                {
                    Text = Convert.ToString(350 * ProductService.service2),
                    Location = new Point(1146, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem3);
                this.Controls.Add(lblAmount3);
                this.Controls.Add(lblPricePerItem3);
                this.Controls.Add(lblTotal3);

                s2 = 0;
            }
            else if (s3 != 0)
            {
                //adding label name
                Label lblItem3 = new Label
                {
                    Text = "Treatment",
                    Location = new Point(60, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount3 = new Label
                {
                    Text = Convert.ToString(ProductService.service3),
                    Location = new Point(548, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem3 = new Label
                {
                    Text = "RM550.00",
                    Location = new Point(819, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal3 = new Label
                {
                    Text = Convert.ToString(550 * ProductService.service3),
                    Location = new Point(1146, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem3);
                this.Controls.Add(lblAmount3);
                this.Controls.Add(lblPricePerItem3);
                this.Controls.Add(lblTotal3);

                s3 = 0;
            }
            else if (s4 != 0)
            {
                //adding label name
                Label lblItem3 = new Label
                {
                    Text = "Styling",
                    Location = new Point(60, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount3 = new Label
                {
                    Text = Convert.ToString(ProductService.service4),
                    Location = new Point(548, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem3 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal3 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service4),
                    Location = new Point(1146, 180),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem3);
                this.Controls.Add(lblAmount3);
                this.Controls.Add(lblPricePerItem3);
                this.Controls.Add(lblTotal3);

                s4 = 0;
            }

            //4th label
            if (p4 != 0)
            {
                //adding label name
                Label lblItem4 = new Label
                {
                    Text = "Inforcer Brush Proof Anti-Breakage Detangling Spray",
                    Location = new Point(60, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount4 = new Label
                {
                    Text = Convert.ToString(ProductService.product4),
                    Location = new Point(548, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem4 = new Label
                {
                    Text = "RM 84.00",
                    Location = new Point(819, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal4 = new Label
                {
                    Text = Convert.ToString(84 * ProductService.product4),
                    Location = new Point(1146, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem4);
                this.Controls.Add(lblAmount4);
                this.Controls.Add(lblPricePerItem4);
                this.Controls.Add(lblTotal4);

                p4 = 0;
            }
            else if (s1 != 0)
            {
                //adding label name
                Label lblItem4 = new Label
                {
                    Text = "Hair Cut",
                    Location = new Point(60, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount4 = new Label
                {
                    Text = Convert.ToString(ProductService.service1),
                    Location = new Point(548, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem4 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal4 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service1),
                    Location = new Point(1146, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem4);
                this.Controls.Add(lblAmount4);
                this.Controls.Add(lblPricePerItem4);
                this.Controls.Add(lblTotal4);

                s1 = 0;
            }
            else if (s2 != 0)
            {
                //adding label name
                Label lblItem4 = new Label
                {
                    Text = "Colouring",
                    Location = new Point(60, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount4 = new Label
                {
                    Text = Convert.ToString(ProductService.service2),
                    Location = new Point(548, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem4 = new Label
                {
                    Text = "RM350.00",
                    Location = new Point(819, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal4 = new Label
                {
                    Text = Convert.ToString(350 * ProductService.service2),
                    Location = new Point(1146, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem4);
                this.Controls.Add(lblAmount4);
                this.Controls.Add(lblPricePerItem4);
                this.Controls.Add(lblTotal4);

                s2 = 0;
            }
            else if (s3 != 0)
            {
                //adding label name
                Label lblItem4 = new Label
                {
                    Text = "Treatment",
                    Location = new Point(60, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount4 = new Label
                {
                    Text = Convert.ToString(ProductService.service3),
                    Location = new Point(548, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem4 = new Label
                {
                    Text = "RM550.00",
                    Location = new Point(819, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal4 = new Label
                {
                    Text = Convert.ToString(550 * ProductService.service3),
                    Location = new Point(1146, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem4);
                this.Controls.Add(lblAmount4);
                this.Controls.Add(lblPricePerItem4);
                this.Controls.Add(lblTotal4);

                s3 = 0;
            }
            else if (s4 != 0)
            {
                //adding label name
                Label lblItem4 = new Label
                {
                    Text = "Styling",
                    Location = new Point(60, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount4 = new Label
                {
                    Text = Convert.ToString(ProductService.service4),
                    Location = new Point(548, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem4 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal4 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service4),
                    Location = new Point(1146, 211),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem4);
                this.Controls.Add(lblAmount4);
                this.Controls.Add(lblPricePerItem4);
                this.Controls.Add(lblTotal4);

                s4 = 0;
            }

            //6th label
            if (s1 != 0)
            {
                //adding label name
                Label lblItem5 = new Label
                {
                    Text = "Hair Cut",
                    Location = new Point(60, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount5 = new Label
                {
                    Text = Convert.ToString(ProductService.service1),
                    Location = new Point(548, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem5 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal5 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service1),
                    Location = new Point(1146, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem5);
                this.Controls.Add(lblAmount5);
                this.Controls.Add(lblPricePerItem5);
                this.Controls.Add(lblTotal5);

                s1 = 0;
            }
            else if (s2 != 0)
            {
                //adding label name
                Label lblItem5 = new Label
                {
                    Text = "Colouring",
                    Location = new Point(60, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount5 = new Label
                {
                    Text = Convert.ToString(ProductService.service2),
                    Location = new Point(548, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem5 = new Label
                {
                    Text = "RM350.00",
                    Location = new Point(819, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal5 = new Label
                {
                    Text = Convert.ToString(350 * ProductService.service2),
                    Location = new Point(1146, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem5);
                this.Controls.Add(lblAmount5);
                this.Controls.Add(lblPricePerItem5);
                this.Controls.Add(lblTotal5);

                s2 = 0;
            }
            else if (s3 != 0)
            {
                //adding label name
                Label lblItem5 = new Label
                {
                    Text = "Treatment",
                    Location = new Point(60, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount5 = new Label
                {
                    Text = Convert.ToString(ProductService.service3),
                    Location = new Point(548, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem5 = new Label
                {
                    Text = "RM550.00",
                    Location = new Point(819, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal5 = new Label
                {
                    Text = Convert.ToString(550 * ProductService.service3),
                    Location = new Point(1146, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem5);
                this.Controls.Add(lblAmount5);
                this.Controls.Add(lblPricePerItem5);
                this.Controls.Add(lblTotal5);

                s3 = 0;
            }
            else if (s4 != 0)
            {
                //adding label name
                Label lblItem5 = new Label
                {
                    Text = "Styling",
                    Location = new Point(60, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount5 = new Label
                {
                    Text = Convert.ToString(ProductService.service4),
                    Location = new Point(548, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem5 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal5 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service4),
                    Location = new Point(1146, 242),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem5);
                this.Controls.Add(lblAmount5);
                this.Controls.Add(lblPricePerItem5);
                this.Controls.Add(lblTotal5);

                s4 = 0;
            }

            //6th label
            if (s2 != 0)
            {
                //adding label name
                Label lblItem6 = new Label
                {
                    Text = "Colouring",
                    Location = new Point(60, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount6 = new Label
                {
                    Text = Convert.ToString(ProductService.service2),
                    Location = new Point(548, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem6 = new Label
                {
                    Text = "RM350.00",
                    Location = new Point(819, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal6 = new Label
                {
                    Text = Convert.ToString(350 * ProductService.service2),
                    Location = new Point(1146, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem6);
                this.Controls.Add(lblAmount6);
                this.Controls.Add(lblPricePerItem6);
                this.Controls.Add(lblTotal6);

                s2 = 0;
            }
            else if (s3 != 0)
            {
                //adding label name
                Label lblItem6 = new Label
                {
                    Text = "Treatment",
                    Location = new Point(60, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount6 = new Label
                {
                    Text = Convert.ToString(ProductService.service3),
                    Location = new Point(548, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem6 = new Label
                {
                    Text = "RM550.00",
                    Location = new Point(819, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal6 = new Label
                {
                    Text = Convert.ToString(550 * ProductService.service3),
                    Location = new Point(1146, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem6);
                this.Controls.Add(lblAmount6);
                this.Controls.Add(lblPricePerItem6);
                this.Controls.Add(lblTotal6);

                s3 = 0;
            }
            else if (s4 != 0)
            {
                //adding label name
                Label lblItem6 = new Label
                {
                    Text = "Styling",
                    Location = new Point(60, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount6 = new Label
                {
                    Text = Convert.ToString(ProductService.service4),
                    Location = new Point(548, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem6 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal6 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service4),
                    Location = new Point(1146, 273),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem6);
                this.Controls.Add(lblAmount6);
                this.Controls.Add(lblPricePerItem6);
                this.Controls.Add(lblTotal6);

                s4 = 0;
            }

            //7th label
            if (s3 != 0)
            {
                //adding label name
                Label lblItem7 = new Label
                {
                    Text = "Treatment",
                    Location = new Point(60, 304),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount7 = new Label
                {
                    Text = Convert.ToString(ProductService.service3),
                    Location = new Point(548, 304),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem7 = new Label
                {
                    Text = "RM550.00",
                    Location = new Point(819, 304),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal7 = new Label
                {
                    Text = Convert.ToString(550 * ProductService.service3),
                    Location = new Point(1146, 304),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem7);
                this.Controls.Add(lblAmount7);
                this.Controls.Add(lblPricePerItem7);
                this.Controls.Add(lblTotal7);

                s3 = 0;
            }
            else if (s4 != 0)
            {
                //adding label name
                Label lblItem7 = new Label
                {
                    Text = "Styling",
                    Location = new Point(60, 304),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount7 = new Label
                {
                    Text = Convert.ToString(ProductService.service4),
                    Location = new Point(548, 304),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem7 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 304),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal7 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service4),
                    Location = new Point(1146, 304),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem7);
                this.Controls.Add(lblAmount7);
                this.Controls.Add(lblPricePerItem7);
                this.Controls.Add(lblTotal7);

                s4 = 0;
            }

            //8th label
            if (s4 != 0)
            {
                //adding label name
                Label lblItem8 = new Label
                {
                    Text = "Styling",
                    Location = new Point(60, 335),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add label amount
                Label lblAmount8 = new Label
                {
                    Text = Convert.ToString(ProductService.service4),
                    Location = new Point(548, 335),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //add price per item
                Label lblPricePerItem8 = new Label
                {
                    Text = "RM50.00",
                    Location = new Point(819, 335),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                //total
                Label lblTotal8 = new Label
                {
                    Text = Convert.ToString(50 * ProductService.service4),
                    Location = new Point(1146, 335),
                    AutoSize = true,
                    Font = new Font("Sylfaen", 12),
                    ForeColor = Color.Black
                };

                // Adding this control to the form
                this.Controls.Add(lblItem8);
                this.Controls.Add(lblAmount8);
                this.Controls.Add(lblPricePerItem8);
                this.Controls.Add(lblTotal8);

                s4 = 0;
            }

            //Final Total Price
            Label lblSum = new Label
            {
                Text = "Final Total Price: " ,
                Location = new Point(1000, 377),
                AutoSize = true,
                Font = new Font("Sylfaen", 12),
                ForeColor = Color.Black
            };
            Label lblPrice = new Label
            {
                Text = Convert.ToString(finaltotal),
                Location = new Point(1146, 377),
                AutoSize = true,
                Font = new Font("Sylfaen", 12),
                ForeColor = Color.Black
            };
            this.Controls.Add(lblSum);
            this.Controls.Add(lblPrice);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out");
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProductService ps = new ProductService();
            ps.Show();
            this.Hide();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout book = new Checkout();
            book.Show();
        }
    }
}
