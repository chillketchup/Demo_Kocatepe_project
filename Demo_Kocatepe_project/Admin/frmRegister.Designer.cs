namespace Demo_Kocatepe_project.Admin
{
    partial class frmRegister
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
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.üyeadi = new System.Windows.Forms.Label();
            this.txtMemberSurname = new System.Windows.Forms.TextBox();
            this.soyadi = new System.Windows.Forms.Label();
            this.dogumtarihi = new System.Windows.Forms.Label();
            this.txtMailAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordAgain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProfilePic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(120, 39);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(184, 23);
            this.txtMemberName.TabIndex = 5;
            // 
            // üyeadi
            // 
            this.üyeadi.AutoSize = true;
            this.üyeadi.Location = new System.Drawing.Point(48, 39);
            this.üyeadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.üyeadi.Name = "üyeadi";
            this.üyeadi.Size = new System.Drawing.Size(52, 15);
            this.üyeadi.TabIndex = 4;
            this.üyeadi.Text = "Üye Adı:";
            // 
            // txtMemberSurname
            // 
            this.txtMemberSurname.Location = new System.Drawing.Point(120, 84);
            this.txtMemberSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMemberSurname.Name = "txtMemberSurname";
            this.txtMemberSurname.Size = new System.Drawing.Size(184, 23);
            this.txtMemberSurname.TabIndex = 7;
            // 
            // soyadi
            // 
            this.soyadi.AutoSize = true;
            this.soyadi.Location = new System.Drawing.Point(54, 84);
            this.soyadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(47, 15);
            this.soyadi.TabIndex = 6;
            this.soyadi.Text = "Soyadı:";
            this.soyadi.Click += new System.EventHandler(this.txtMemberSurname_Click);
            // 
            // dogumtarihi
            // 
            this.dogumtarihi.AutoSize = true;
            this.dogumtarihi.Location = new System.Drawing.Point(18, 129);
            this.dogumtarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dogumtarihi.Name = "dogumtarihi";
            this.dogumtarihi.Size = new System.Drawing.Size(85, 15);
            this.dogumtarihi.TabIndex = 8;
            this.dogumtarihi.Text = "Doğum Tarihi:";
            // 
            // txtMailAdress
            // 
            this.txtMailAdress.Location = new System.Drawing.Point(120, 173);
            this.txtMailAdress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMailAdress.Name = "txtMailAdress";
            this.txtMailAdress.Size = new System.Drawing.Size(184, 23);
            this.txtMailAdress.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail Adresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefon:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 263);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 23);
            this.txtPassword.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Şifre:";
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.Location = new System.Drawing.Point(120, 303);
            this.txtPasswordAgain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.Size = new System.Drawing.Size(184, 23);
            this.txtPasswordAgain.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Şifre Tekrar:";
            // 
            // txtProfilePic
            // 
            this.txtProfilePic.Location = new System.Drawing.Point(120, 350);
            this.txtProfilePic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProfilePic.Name = "txtProfilePic";
            this.txtProfilePic.Size = new System.Drawing.Size(184, 23);
            this.txtProfilePic.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 350);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Profil Resmi:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(120, 129);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(184, 23);
            this.dateTimePicker.TabIndex = 20;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(120, 218);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBox1.Mask = "(053) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(184, 23);
            this.maskedTextBox1.TabIndex = 21;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(120, 408);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(184, 39);
            this.btnSignIn.TabIndex = 22;
            this.btnSignIn.Text = "Kayıt Ol";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 519);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtProfilePic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPasswordAgain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMailAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dogumtarihi);
            this.Controls.Add(this.txtMemberSurname);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.üyeadi);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label üyeadi;
        private System.Windows.Forms.TextBox txtMemberSurname;
        private System.Windows.Forms.Label soyadi;
        private System.Windows.Forms.Label dogumtarihi;
        private System.Windows.Forms.TextBox txtMailAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordAgain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProfilePic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnSignIn;
    }
}