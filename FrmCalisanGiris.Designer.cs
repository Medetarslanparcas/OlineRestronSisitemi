﻿namespace OnlineRestoranSiparisTakipSistemi
{
    partial class FrmCalisanGiris
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
            this.chckSifreGöster = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCalisanGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnaEkran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chckSifreGöster
            // 
            this.chckSifreGöster.AutoSize = true;
            this.chckSifreGöster.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckSifreGöster.Location = new System.Drawing.Point(512, 309);
            this.chckSifreGöster.Name = "chckSifreGöster";
            this.chckSifreGöster.Size = new System.Drawing.Size(163, 36);
            this.chckSifreGöster.TabIndex = 15;
            this.chckSifreGöster.Text = "Şifreyi Göster";
            this.chckSifreGöster.UseVisualStyleBackColor = true;
            this.chckSifreGöster.CheckedChanged += new System.EventHandler(this.chckSifreGöster_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(510, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 39);
            this.txtEmail.TabIndex = 14;
            // 
            // btnCalisanGiris
            // 
            this.btnCalisanGiris.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalisanGiris.Location = new System.Drawing.Point(558, 365);
            this.btnCalisanGiris.Name = "btnCalisanGiris";
            this.btnCalisanGiris.Size = new System.Drawing.Size(156, 49);
            this.btnCalisanGiris.TabIndex = 13;
            this.btnCalisanGiris.Text = "Giriş Yap";
            this.btnCalisanGiris.UseVisualStyleBackColor = true;
            this.btnCalisanGiris.Click += new System.EventHandler(this.btnCalisanGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 49);
            this.label3.TabIndex = 12;
            this.label3.Text = "Calışan Giriş Paneli";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(510, 264);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(274, 39);
            this.txtPassword.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eposta:";
            // 
            // btnAnaEkran
            // 
            this.btnAnaEkran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAnaEkran.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaEkran.Location = new System.Drawing.Point(32, 365);
            this.btnAnaEkran.Name = "btnAnaEkran";
            this.btnAnaEkran.Size = new System.Drawing.Size(182, 49);
            this.btnAnaEkran.TabIndex = 16;
            this.btnAnaEkran.Text = "Ana Ekrana Dön";
            this.btnAnaEkran.UseVisualStyleBackColor = false;
            this.btnAnaEkran.Click += new System.EventHandler(this.btnAnaEkran_Click);
            // 
            // FrmCalisanGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1145, 482);
            this.Controls.Add(this.btnAnaEkran);
            this.Controls.Add(this.chckSifreGöster);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCalisanGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.Name = "FrmCalisanGiris";
            this.Text = "Calışan Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckSifreGöster;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCalisanGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnaEkran;
    }
}