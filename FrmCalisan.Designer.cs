namespace OnlineRestoranSiparisTakipSistemi
{
    partial class FrmCalisan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAktifSiparis = new System.Windows.Forms.DataGridView();
            this.btnDurumGüncelleme = new System.Windows.Forms.Button();
            this.grpGünlükÖzet = new System.Windows.Forms.GroupBox();
            this.lblToplamSiparis = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.dsadasdad = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblCalisanAd = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktifSiparis)).BeginInit();
            this.grpGünlükÖzet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 60);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktif Siparişler";
            // 
            // dataGridViewAktifSiparis
            // 
            this.dataGridViewAktifSiparis.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAktifSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAktifSiparis.Location = new System.Drawing.Point(12, 134);
            this.dataGridViewAktifSiparis.Name = "dataGridViewAktifSiparis";
            this.dataGridViewAktifSiparis.RowHeadersWidth = 51;
            this.dataGridViewAktifSiparis.RowTemplate.Height = 24;
            this.dataGridViewAktifSiparis.Size = new System.Drawing.Size(877, 312);
            this.dataGridViewAktifSiparis.TabIndex = 5;
            // 
            // btnDurumGüncelleme
            // 
            this.btnDurumGüncelleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDurumGüncelleme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDurumGüncelleme.Location = new System.Drawing.Point(597, 452);
            this.btnDurumGüncelleme.Name = "btnDurumGüncelleme";
            this.btnDurumGüncelleme.Size = new System.Drawing.Size(219, 41);
            this.btnDurumGüncelleme.TabIndex = 6;
            this.btnDurumGüncelleme.Text = "Durumu Güncelle";
            this.btnDurumGüncelleme.UseVisualStyleBackColor = false;
            this.btnDurumGüncelleme.Click += new System.EventHandler(this.btnDurumGüncelleme_Click);
            // 
            // grpGünlükÖzet
            // 
            this.grpGünlükÖzet.Controls.Add(this.lblToplamSiparis);
            this.grpGünlükÖzet.Controls.Add(this.lblToplamTutar);
            this.grpGünlükÖzet.Controls.Add(this.dsadasdad);
            this.grpGünlükÖzet.Controls.Add(this.label);
            this.grpGünlükÖzet.Location = new System.Drawing.Point(65, 452);
            this.grpGünlükÖzet.Name = "grpGünlükÖzet";
            this.grpGünlükÖzet.Size = new System.Drawing.Size(332, 155);
            this.grpGünlükÖzet.TabIndex = 7;
            this.grpGünlükÖzet.TabStop = false;
            this.grpGünlükÖzet.Text = "Günlük Sipariş Özeti";
       
            // 
            // lblToplamSiparis
            // 
            this.lblToplamSiparis.AutoSize = true;
            this.lblToplamSiparis.Location = new System.Drawing.Point(168, 93);
            this.lblToplamSiparis.Name = "lblToplamSiparis";
            this.lblToplamSiparis.Size = new System.Drawing.Size(26, 32);
            this.lblToplamSiparis.TabIndex = 8;
            this.lblToplamSiparis.Text = "0";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(153, 61);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(26, 32);
            this.lblToplamTutar.TabIndex = 2;
            this.lblToplamTutar.Text = "0";
            // 
            // dsadasdad
            // 
            this.dsadasdad.AutoSize = true;
            this.dsadasdad.Location = new System.Drawing.Point(6, 93);
            this.dsadasdad.Name = "dsadasdad";
            this.dsadasdad.Size = new System.Drawing.Size(157, 32);
            this.dsadasdad.TabIndex = 0;
            this.dsadasdad.Text = "Toplam Sipariş:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(141, 32);
            this.label.TabIndex = 1;
            this.label.Text = "Toplam Tutar:";
            // 
            // lblCalisanAd
            // 
            this.lblCalisanAd.AutoSize = true;
            this.lblCalisanAd.Location = new System.Drawing.Point(12, 9);
            this.lblCalisanAd.Name = "lblCalisanAd";
            this.lblCalisanAd.Size = new System.Drawing.Size(0, 32);
            this.lblCalisanAd.TabIndex = 9;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Location = new System.Drawing.Point(597, 521);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(219, 43);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Cıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(920, 669);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblCalisanAd);
            this.Controls.Add(this.grpGünlükÖzet);
            this.Controls.Add(this.btnDurumGüncelleme);
            this.Controls.Add(this.dataGridViewAktifSiparis);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FrmCalisan";
            this.Text = "Restoran Çalışanı Ekranı ";
            this.Load += new System.EventHandler(this.FrmCalisan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktifSiparis)).EndInit();
            this.grpGünlükÖzet.ResumeLayout(false);
            this.grpGünlükÖzet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAktifSiparis;
        private System.Windows.Forms.Button btnDurumGüncelleme;
        private System.Windows.Forms.GroupBox grpGünlükÖzet;
        private System.Windows.Forms.Label dsadasdad;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblToplamSiparis;
        private System.Windows.Forms.Label lblCalisanAd;
        private System.Windows.Forms.Button btnCikis;
    }
}