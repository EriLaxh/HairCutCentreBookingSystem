
namespace Integrated_System_Project
{
    partial class Checkout
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
            this.Appointment = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Appointment
            // 
            this.Appointment.AllowDrop = true;
            this.Appointment.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointment.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Appointment.Location = new System.Drawing.Point(148, 101);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(360, 34);
            this.Appointment.TabIndex = 3;
            this.Appointment.Value = new System.DateTime(2022, 4, 15, 0, 0, 0, 0);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(245, 238);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(96, 41);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(45, 101);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 31);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(45, 162);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(83, 31);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time :";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(148, 162);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(360, 34);
            this.txtTime.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(51, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 41);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(442, 238);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(96, 41);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(148, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 34);
            this.txtName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 31);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name :";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(612, 319);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.Appointment);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Appointment;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}