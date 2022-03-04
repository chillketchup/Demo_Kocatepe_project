namespace Demo_Kocatepe_project.Admin
{
    partial class frmAuthor
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
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.üyeadi = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rctDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(96, 36);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(184, 23);
            this.txtAuthorName.TabIndex = 7;
            // 
            // üyeadi
            // 
            this.üyeadi.AutoSize = true;
            this.üyeadi.Location = new System.Drawing.Point(21, 36);
            this.üyeadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.üyeadi.Name = "üyeadi";
            this.üyeadi.Size = new System.Drawing.Size(63, 15);
            this.üyeadi.TabIndex = 6;
            this.üyeadi.Text = "Yazar Adı:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(96, 80);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(184, 23);
            this.txtSurname.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Açıklama:";
            // 
            // rctDescription
            // 
            this.rctDescription.Location = new System.Drawing.Point(96, 129);
            this.rctDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rctDescription.Name = "rctDescription";
            this.rctDescription.Size = new System.Drawing.Size(184, 187);
            this.rctDescription.TabIndex = 11;
            this.rctDescription.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 354);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 27);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 519);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rctDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.üyeadi);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAuthor";
            this.Text = "frmAuthor";
            this.Load += new System.EventHandler(this.frmAuthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label üyeadi;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rctDescription;
        private System.Windows.Forms.Button btnSave;
    }
}