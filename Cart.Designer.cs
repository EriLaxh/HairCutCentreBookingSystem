
namespace Integrated_System_Project
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCart = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPS = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lbl1item = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Sylfaen", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(681, 5);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(95, 52);
            this.lblCart.TabIndex = 10;
            this.lblCart.Text = "Cart";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(226, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 35);
            this.btnLogout.TabIndex = 57;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(453, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 35);
            this.btnBack.TabIndex = 58;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPS
            // 
            this.lblPS.AutoSize = true;
            this.lblPS.Font = new System.Drawing.Font("Sylfaen", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPS.Location = new System.Drawing.Point(60, 74);
            this.lblPS.Name = "lblPS";
            this.lblPS.Size = new System.Drawing.Size(235, 35);
            this.lblPS.TabIndex = 59;
            this.lblPS.Text = "Product / Services";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(968, 22);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(140, 35);
            this.btnCheckout.TabIndex = 60;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Sylfaen", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(522, 74);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(113, 35);
            this.lblAmount.TabIndex = 61;
            this.lblAmount.Text = "Amount";
            // 
            // lbl1item
            // 
            this.lbl1item.AutoSize = true;
            this.lbl1item.Font = new System.Drawing.Font("Sylfaen", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1item.Location = new System.Drawing.Point(725, 74);
            this.lbl1item.Name = "lbl1item";
            this.lbl1item.Size = new System.Drawing.Size(328, 35);
            this.lbl1item.TabIndex = 62;
            this.lbl1item.Text = "Price Per Product/Service";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Sylfaen", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1108, 74);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(151, 35);
            this.lblTotal.TabIndex = 63;
            this.lblTotal.Text = "Total (RM)";
            // 
            // Cart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1269, 530);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbl1item);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblPS);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblCart);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPS;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lbl1item;
        private System.Windows.Forms.Label lblTotal;
    }
}