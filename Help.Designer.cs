
namespace Integrated_System_Project
{
    partial class Help
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
            this.btnFP = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFP
            // 
            this.btnFP.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFP.Location = new System.Drawing.Point(33, 28);
            this.btnFP.Name = "btnFP";
            this.btnFP.Size = new System.Drawing.Size(225, 43);
            this.btnFP.TabIndex = 7;
            this.btnFP.Text = "Forgot Password";
            this.btnFP.UseVisualStyleBackColor = true;
            this.btnFP.Click += new System.EventHandler(this.btnFP_Click);
            // 
            // btnContact
            // 
            this.btnContact.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.Location = new System.Drawing.Point(33, 84);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(126, 35);
            this.btnContact.TabIndex = 8;
            this.btnContact.Text = "Contact Us";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnFAQ
            // 
            this.btnFAQ.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAQ.Location = new System.Drawing.Point(33, 141);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(73, 35);
            this.btnFAQ.TabIndex = 9;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.UseVisualStyleBackColor = true;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(281, 209);
            this.Controls.Add(this.btnFAQ);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnFP);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFP;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnFAQ;
    }
}