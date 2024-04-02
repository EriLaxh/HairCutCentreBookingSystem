
namespace Integrated_System_Project
{
    partial class Register
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkSPR = new System.Windows.Forms.CheckBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.chkConfirmSPR = new System.Windows.Forms.CheckBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.HPStartNo = new System.Windows.Forms.ListBox();
            this.lblHP = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Sylfaen", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(46, 29);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(157, 52);
            this.lblRegister.TabIndex = 1;
            this.lblRegister.Text = "Register";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(49, 101);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(137, 31);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(295, 100);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(323, 34);
            this.txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(49, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(132, 31);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(295, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(323, 34);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkSPR
            // 
            this.chkSPR.AutoSize = true;
            this.chkSPR.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSPR.Location = new System.Drawing.Point(295, 204);
            this.chkSPR.Name = "chkSPR";
            this.chkSPR.Size = new System.Drawing.Size(179, 30);
            this.chkSPR.TabIndex = 9;
            this.chkSPR.Text = "Show Password";
            this.chkSPR.UseVisualStyleBackColor = true;
            this.chkSPR.CheckedChanged += new System.EventHandler(this.chkSPR_CheckedChanged);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(49, 258);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(229, 31);
            this.lblCP.TabIndex = 10;
            this.lblCP.Text = "Confirm Password :";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(295, 257);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(323, 34);
            this.txtConfirm.TabIndex = 11;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // chkConfirmSPR
            // 
            this.chkConfirmSPR.AutoSize = true;
            this.chkConfirmSPR.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfirmSPR.Location = new System.Drawing.Point(295, 292);
            this.chkConfirmSPR.Name = "chkConfirmSPR";
            this.chkConfirmSPR.Size = new System.Drawing.Size(179, 30);
            this.chkConfirmSPR.TabIndex = 12;
            this.chkConfirmSPR.Text = "Show Password";
            this.chkConfirmSPR.UseVisualStyleBackColor = true;
            this.chkConfirmSPR.CheckedChanged += new System.EventHandler(this.chkConfirmSPR_CheckedChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(49, 346);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 31);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(295, 345);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 34);
            this.txtEmail.TabIndex = 14;
            // 
            // HPStartNo
            // 
            this.HPStartNo.AllowDrop = true;
            this.HPStartNo.CausesValidation = false;
            this.HPStartNo.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPStartNo.FormattingEnabled = true;
            this.HPStartNo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.HPStartNo.ItemHeight = 26;
            this.HPStartNo.Items.AddRange(new object[] {
            "Afghanistan(+93)",
            "Albania(+355)",
            "Algeria(+213)",
            "American Samoa(+684)",
            "Andorra(+376)",
            "Angola(+244)",
            "Anguilla(+809)",
            "Antigua(+268)",
            "Argentina(+54)",
            "Armenia(+374)",
            "Aruba(+297)",
            "Ascension Island(+247)",
            "Australia(+61)",
            "Australian External Territories(+672)",
            "Austria(+43)",
            "Azerbaijan(+994)",
            "Bahamas(+242)",
            "Bahrain(+973)",
            "Bangladesh(+880)",
            "Barbados(+246)",
            "Belarus(+375)",
            "Belgium(+32)",
            "Belize(+501)",
            "Benin(+229)",
            "Bermuda(+809)",
            "Bhutan(+975)",
            "Bolivia(+591)",
            "Bosnia and Hercegovina(+387)",
            "Botswana(+267)",
            "Brazil(+55)",
            "British V.I.(+284)",
            "British Virgin Islands(+284)",
            "Brunei Darussalm(+673)",
            "Bulgaria(+359)",
            "Burkina Faso(+226)",
            "Burundi(+257)",
            "Cambodia(+855)",
            "Cameroon(+237)",
            "Canada(+1)",
            "Cape Verdi(+238)",
            "CapeVerde Islands(+238)",
            "Caribbean Nations(+1)",
            "Cayman Islands(+345)",
            "Central African Republic(+236)",
            "Chad(+235)",
            "Chile(+56)",
            "China (People\'s Republic)(+86)",
            "China(+886)\",\"Colombia(+57)",
            "Comoros and Mayotte(+269)",
            "Congo(+242)",
            "Cook Islands(+682)",
            "Costa Rica(+506)",
            "Croatia(+385)",
            "Cuba(+53)",
            "Cyprus(+357)",
            "Czech Republic(+420)",
            "Denmark(+45)",
            "Diego Garcia(+246)",
            "Djibouti(+253)",
            "Dominca(+767)",
            "Dominican Republic(+809)",
            "Ecuador(+593)",
            "Egypt(+20)",
            "El Salvador(+503)",
            "Equatorial Guinea(+240)",
            "Eritrea(+291)",
            "Estonia(+372)",
            "Ethiopia(+251)",
            "Falkland Islands(+500)",
            "Faroe (Faeroe) Islands (Denmark)(+298)",
            "Fiji(+679)",
            "Finland(+358)",
            "France(+33)",
            "French Antilles(+596)",
            "French Guiana(+594)",
            "Gabon (Gabonese Republic)(+241)",
            "Gambia(+220)",
            "Georgia(+995)",
            "Germany(+49)",
            "Ghana(+233)",
            "Gibraltar(+350)",
            "Greece(+30)",
            "Greenland(+299)",
            "Grenada/Carricou(+473)",
            "Guam(+671)",
            "Guatemala(+502)",
            "Guinea(+224)",
            "Guinea(+245)",
            "Guyana(+592)",
            "Haiti(+509)",
            "Honduras(+504)",
            "Hong Kong(+852)",
            "Hungary(+36)",
            "Iceland(+354)",
            "India(+91)",
            "Indonesia(+62)",
            "Iran(+98)",
            "Iraq(+964)",
            "Ireland (Irish Republic; Eire)(+353)",
            "Israel(+972)",
            "Italy(+39)",
            "Ivory Coast (La Cote d\'Ivoire)(+225)",
            "Jamaica(+876)",
            "Japan(+81)",
            "Jordan(+962)",
            "Kazakhstan(+7)",
            "Kenya(+254)",
            "Khmer Republic (Cambodia/Kampuchea)(+855)",
            "Kiribati Republic (Gilbert Islands)(+686)",
            "Korea, People\'s Republic of (North Korea)(+850)",
            "Korea, Republic of (South Korea)(+82)",
            "Kuwait(+965)",
            "Kyrgyz Republic(+996)",
            "Laos(+856)",
            "Latvia(+371)",
            "Lebanon(+961)",
            "Lesotho(+266)",
            "Liberia(+231)",
            "Libya(+218)",
            "Liechtenstein(+423)",
            "Lithuania(+370)",
            "Luxembourg(+352)",
            "Macao(+853)",
            "Macedonia(+389)",
            "Madagascar(+261)",
            "Malawi(+265)",
            "Malaysia(+60)",
            "Maldives(+960)",
            "Mali(+223)",
            "Malta(+356)",
            "Marshall Islands(+692)",
            "Martinique (French Antilles)(+596)",
            "Mauritania(+222)\",\"Mauritius(+230)",
            "Mayolte(+269)\",\"Mexico(+52)",
            "Micronesia (F.S. of Polynesia)(+691)",
            "Moldova(+373)",
            "Monaco(+33)",
            "Mongolia(+976)",
            "Montserrat(+473)",
            "Morocco(+212)",
            "Mozambique(+258)",
            "Myanmar (former Burma)(+95)",
            "Namibia (former South(+264)",
            "Nauru(+674)\",\"Nepal(+977)",
            "Netherlands Antilles(+599)",
            "Netherlands(+31)",
            "Nevis(+869)",
            "New Caledonia(+687)",
            "New Zealand(+64)",
            "Nicaragua(+505)",
            "Niger(+227)",
            "Nigeria(+234)",
            "Niue(+683)",
            "North Korea(+850)",
            "North Mariana Islands (Saipan)(+670)",
            "Norway(+47)",
            "Oman(+968)",
            "Pakistan(+92)",
            "Palau(+680)",
            "Panama(+507)",
            "Papua New Guinea(+675)",
            "Paraguay(+595)",
            "Peru(+51)",
            "Philippines(+63)",
            "Poland(+48)",
            "Portugal (includes Azores)(+351)",
            "Puerto Rico(+1 787)",
            "Qatar(+974)",
            "Reunion (France)(+262)",
            "Romania(+40)",
            "Russia(+7)",
            "Rwanda (Rwandese Republic)(+250)",
            "Saipan(+670)",
            "San Marino(+378)",
            "Sao Tome and Principe(+239)",
            "Saudi Arabia(+966)",
            "Senegal(+221)",
            "Serbia and Montenegro(+381)",
            "Seychelles(+248)",
            "Sierra Leone(+232)",
            "Singapore(+65)",
            "Slovakia(+421)",
            "Slovenia(+386)",
            "Solomon Islands(+677)",
            "Somalia(+252)",
            "South Africa(+27)",
            "Spain(+34)",
            "Sri Lanka(+94)",
            "St. Helena(+290)",
            "St. Kitts/Nevis(+869)",
            "St. Pierre &(et) Miquelon (France)(+508)",
            "Sudan(+249)",
            "Suriname(+597)",
            "Swaziland(+268)",
            "Sweden(+46)",
            "Switzerland(+41)",
            "Syrian Arab Republic (Syria)(+963)",
            "Tahiti (French Polynesia)(+689)",
            "Taiwan(+886)",
            "Tajikistan(+7)",
            "Tanzania (includes Zanzibar)(+255)",
            "Thailand(+66)",
            "Togo (Togolese Republic)(+228)",
            "Tokelau(+690)",
            "Tonga(+676)",
            "Trinidad and Tobago(+1 868)",
            "Tunisia(+216)",
            "Turkey(+90)",
            "Turkmenistan(+993)",
            "Tuvalu (Ellice Islands)(+688)",
            "Uganda(+256)",
            "Ukraine(+380)",
            "United Arab Emirates(+971)",
            "United Kingdom(+44)",
            "Uruguay(+598)",
            "USA(+1)",
            "Uzbekistan(+7)",
            "Vanuatu (New Hebrides)(+678)",
            "Vatican City(+39)",
            "Venezuela(+58)",
            "Vietnam(+84)",
            "Virgin Islands(+1 340)",
            "Wallis and Futuna(+681)",
            "Western Samoa(+685)",
            "Yemen (People\'s Democratic Republic of)(+381)",
            "Yemen Arab Republic (North Yemen)(+967)",
            "Yugoslavia (discontinued)(+381)",
            "Zaire(+243)",
            "Zambia(+260)",
            "Zimbabwe(+263)"});
            this.HPStartNo.Location = new System.Drawing.Point(295, 402);
            this.HPStartNo.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.HPStartNo.MinimumSize = new System.Drawing.Size(100, 50);
            this.HPStartNo.Name = "HPStartNo";
            this.HPStartNo.ScrollAlwaysVisible = true;
            this.HPStartNo.Size = new System.Drawing.Size(323, 30);
            this.HPStartNo.TabIndex = 15;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(50, 436);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(192, 31);
            this.lblHP.TabIndex = 16;
            this.lblHP.Text = "Phone Number :";
            // 
            // txtHP
            // 
            this.txtHP.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHP.Location = new System.Drawing.Point(295, 435);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(323, 34);
            this.txtHP.TabIndex = 17;
            this.txtHP.TextChanged += new System.EventHandler(this.txtHP_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(241, 516);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 35);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(690, 563);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.HPStartNo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.chkConfirmSPR);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.chkSPR);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRegister);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkSPR;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.CheckBox chkConfirmSPR;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ListBox HPStartNo;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Button btnRegister;
    }
}