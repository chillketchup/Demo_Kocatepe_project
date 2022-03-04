namespace Demo_Kocatepe_project.Admin
{
    partial class frmTest
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
            this.btnKareHesaplama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTekmiCiftmi = new System.Windows.Forms.Button();
            this.btnBasamak = new System.Windows.Forms.Button();
            this.btnBakteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKareHesaplama
            // 
            this.btnKareHesaplama.Location = new System.Drawing.Point(46, 172);
            this.btnKareHesaplama.Name = "btnKareHesaplama";
            this.btnKareHesaplama.Size = new System.Drawing.Size(121, 52);
            this.btnKareHesaplama.TabIndex = 0;
            this.btnKareHesaplama.Text = "Kare Hesaplama";
            this.btnKareHesaplama.UseVisualStyleBackColor = true;
            this.btnKareHesaplama.Click += new System.EventHandler(this.btnKareHesaplama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTekmiCiftmi
            // 
            this.btnTekmiCiftmi.Location = new System.Drawing.Point(46, 239);
            this.btnTekmiCiftmi.Name = "btnTekmiCiftmi";
            this.btnTekmiCiftmi.Size = new System.Drawing.Size(121, 52);
            this.btnTekmiCiftmi.TabIndex = 5;
            this.btnTekmiCiftmi.Text = "Tek mi Çift mi";
            this.btnTekmiCiftmi.UseVisualStyleBackColor = true;
            this.btnTekmiCiftmi.Click += new System.EventHandler(this.btnTekmiCiftmi_Click);
            // 
            // btnBasamak
            // 
            this.btnBasamak.Location = new System.Drawing.Point(46, 297);
            this.btnBasamak.Name = "btnBasamak";
            this.btnBasamak.Size = new System.Drawing.Size(121, 52);
            this.btnBasamak.TabIndex = 6;
            this.btnBasamak.Text = "Basamak Toplama";
            this.btnBasamak.UseVisualStyleBackColor = true;
            this.btnBasamak.Click += new System.EventHandler(this.btnBasamak_Click);
            // 
            // btnBakteri
            // 
            this.btnBakteri.Location = new System.Drawing.Point(46, 355);
            this.btnBakteri.Name = "btnBakteri";
            this.btnBakteri.Size = new System.Drawing.Size(121, 52);
            this.btnBakteri.TabIndex = 7;
            this.btnBakteri.Text = "Bakteri";
            this.btnBakteri.UseVisualStyleBackColor = true;
            this.btnBakteri.Click += new System.EventHandler(this.btnBakteri_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.btnBakteri);
            this.Controls.Add(this.btnBasamak);
            this.Controls.Add(this.btnTekmiCiftmi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKareHesaplama);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKareHesaplama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTekmiCiftmi;
        private System.Windows.Forms.Button btnBasamak;
        private System.Windows.Forms.Button btnBakteri;
    }
}