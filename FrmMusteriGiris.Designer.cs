namespace OnlineRestoranSiparisTakipSistemi
{
    partial class FrmMusteriGiris
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
            this.txtMusteriEmail = new System.Windows.Forms.TextBox();
            this.btnMusteriGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriPassword = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SifreGöster = new System.Windows.Forms.CheckBox();
            this.KayitOl = new System.Windows.Forms.LinkLabel();
            this.btnAnaEkran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMusteriEmail
            // 
            this.txtMusteriEmail.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusteriEmail.Location = new System.Drawing.Point(510, 185);
            this.txtMusteriEmail.Name = "txtMusteriEmail";
            this.txtMusteriEmail.Size = new System.Drawing.Size(274, 39);
            this.txtMusteriEmail.TabIndex = 13;
            // 
            // btnMusteriGiris
            // 
            this.btnMusteriGiris.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriGiris.Location = new System.Drawing.Point(570, 375);
            this.btnMusteriGiris.Name = "btnMusteriGiris";
            this.btnMusteriGiris.Size = new System.Drawing.Size(156, 49);
            this.btnMusteriGiris.TabIndex = 12;
            this.btnMusteriGiris.Text = "Giriş Yap";
            this.btnMusteriGiris.UseVisualStyleBackColor = true;
            this.btnMusteriGiris.Click += new System.EventHandler(this.btnMusteriGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 49);
            this.label3.TabIndex = 11;
            this.label3.Text = "Müşteri Giriş Paneli";
            // 
            // txtMusteriPassword
            // 
            this.txtMusteriPassword.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusteriPassword.Location = new System.Drawing.Point(510, 270);
            this.txtMusteriPassword.Name = "txtMusteriPassword";
            this.txtMusteriPassword.PasswordChar = '*';
            this.txtMusteriPassword.Size = new System.Drawing.Size(274, 39);
            this.txtMusteriPassword.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eposta:";
            // 
            // SifreGöster
            // 
            this.SifreGöster.AutoSize = true;
            this.SifreGöster.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SifreGöster.Location = new System.Drawing.Point(510, 315);
            this.SifreGöster.Name = "SifreGöster";
            this.SifreGöster.Size = new System.Drawing.Size(147, 36);
            this.SifreGöster.TabIndex = 14;
            this.SifreGöster.Text = "Şifre Göster";
            this.SifreGöster.UseVisualStyleBackColor = true;
            this.SifreGöster.CheckedChanged += new System.EventHandler(this.SifreGöster_CheckedChanged);
            // 
            // KayitOl
            // 
            this.KayitOl.AutoSize = true;
            this.KayitOl.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayitOl.Location = new System.Drawing.Point(698, 319);
            this.KayitOl.Name = "KayitOl";
            this.KayitOl.Size = new System.Drawing.Size(86, 32);
            this.KayitOl.TabIndex = 15;
            this.KayitOl.TabStop = true;
            this.KayitOl.Text = "Kayıt Ol";
            this.KayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KayitOl_LinkClicked);
            // 
            // btnAnaEkran
            // 
            this.btnAnaEkran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAnaEkran.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaEkran.Location = new System.Drawing.Point(53, 375);
            this.btnAnaEkran.Name = "btnAnaEkran";
            this.btnAnaEkran.Size = new System.Drawing.Size(257, 49);
            this.btnAnaEkran.TabIndex = 17;
            this.btnAnaEkran.Text = "Yönetiçi Sayfasına Dön";
            this.btnAnaEkran.UseVisualStyleBackColor = false;
            this.btnAnaEkran.Click += new System.EventHandler(this.btnAnaEkran_Click);
            // 
            // FrmMusteriGiris
            // 
            this.AcceptButton = this.btnMusteriGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1145, 482);
            this.Controls.Add(this.btnAnaEkran);
            this.Controls.Add(this.KayitOl);
            this.Controls.Add(this.SifreGöster);
            this.Controls.Add(this.txtMusteriEmail);
            this.Controls.Add(this.btnMusteriGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.Name = "FrmMusteriGiris";
            this.Text = "Müşteri Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriEmail;
        private System.Windows.Forms.Button btnMusteriGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtMusteriPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SifreGöster;
        private System.Windows.Forms.LinkLabel KayitOl;
        private System.Windows.Forms.Button btnAnaEkran;
    }
}