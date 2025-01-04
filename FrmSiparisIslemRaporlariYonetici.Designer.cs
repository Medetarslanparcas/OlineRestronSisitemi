namespace OnlineRestoranSiparisTakipSistemi
{
    partial class FrmSiparisIslemRaporlariYonetici
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpRaporSecimi = new System.Windows.Forms.GroupBox();
            this.lblTarihSecimi = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblRaporTuru = new System.Windows.Forms.Label();
            this.cmbRaporTuru = new System.Windows.Forms.ComboBox();
            this.dtgvRapor = new System.Windows.Forms.DataGridView();
            this.grpAnaliz = new System.Windows.Forms.GroupBox();
            this.btnYoneticiSayfa = new System.Windows.Forms.Button();
            this.lblEnCokSatilanUrun = new System.Windows.Forms.Label();
            this.txtEnCokSatilanUrun = new System.Windows.Forms.TextBox();
            this.lblToplamSiparisSayisi = new System.Windows.Forms.Label();
            this.txtToplamSiparisSayisi = new System.Windows.Forms.TextBox();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.txtToplamGelir = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grpRaporSecimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRapor)).BeginInit();
            this.grpAnaliz.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grpRaporSecimi
            // 
            this.grpRaporSecimi.Controls.Add(this.btnGuncelle);
            this.grpRaporSecimi.Controls.Add(this.lblTarihSecimi);
            this.grpRaporSecimi.Controls.Add(this.dtpBaslangicTarihi);
            this.grpRaporSecimi.Controls.Add(this.dtpBitisTarihi);
            this.grpRaporSecimi.Controls.Add(this.lblRaporTuru);
            this.grpRaporSecimi.Controls.Add(this.cmbRaporTuru);
            this.grpRaporSecimi.Location = new System.Drawing.Point(12, 12);
            this.grpRaporSecimi.Name = "grpRaporSecimi";
            this.grpRaporSecimi.Size = new System.Drawing.Size(1009, 120);
            this.grpRaporSecimi.TabIndex = 0;
            this.grpRaporSecimi.TabStop = false;
            this.grpRaporSecimi.Text = "Rapor Seçimi";
            // 
            // lblTarihSecimi
            // 
            this.lblTarihSecimi.Location = new System.Drawing.Point(109, 32);
            this.lblTarihSecimi.Name = "lblTarihSecimi";
            this.lblTarihSecimi.Size = new System.Drawing.Size(100, 23);
            this.lblTarihSecimi.TabIndex = 0;
            this.lblTarihSecimi.Text = "Tarih Aralığı Seçin:";
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(298, 25);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(320, 30);
            this.dtpBaslangicTarihi.TabIndex = 1;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(624, 25);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(331, 30);
            this.dtpBitisTarihi.TabIndex = 2;
            // 
            // lblRaporTuru
            // 
            this.lblRaporTuru.Location = new System.Drawing.Point(109, 68);
            this.lblRaporTuru.Name = "lblRaporTuru";
            this.lblRaporTuru.Size = new System.Drawing.Size(100, 23);
            this.lblRaporTuru.TabIndex = 3;
            this.lblRaporTuru.Text = "Rapor Türü Seçin:";
            // 
            // cmbRaporTuru
            // 
            this.cmbRaporTuru.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.cmbRaporTuru.Location = new System.Drawing.Point(298, 61);
            this.cmbRaporTuru.Name = "cmbRaporTuru";
            this.cmbRaporTuru.Size = new System.Drawing.Size(240, 33);
            this.cmbRaporTuru.TabIndex = 4;
            // 
            // dtgvRapor
            // 
            this.dtgvRapor.ColumnHeadersHeight = 29;
            this.dtgvRapor.Location = new System.Drawing.Point(12, 150);
            this.dtgvRapor.Name = "dtgvRapor";
            this.dtgvRapor.RowHeadersWidth = 51;
            this.dtgvRapor.Size = new System.Drawing.Size(1009, 200);
            this.dtgvRapor.TabIndex = 1;
            // 
            // grpAnaliz
            // 
            this.grpAnaliz.Controls.Add(this.btnYoneticiSayfa);
            this.grpAnaliz.Controls.Add(this.lblEnCokSatilanUrun);
            this.grpAnaliz.Controls.Add(this.txtEnCokSatilanUrun);
            this.grpAnaliz.Controls.Add(this.lblToplamSiparisSayisi);
            this.grpAnaliz.Controls.Add(this.txtToplamSiparisSayisi);
            this.grpAnaliz.Controls.Add(this.lblToplamGelir);
            this.grpAnaliz.Controls.Add(this.txtToplamGelir);
            this.grpAnaliz.Location = new System.Drawing.Point(12, 370);
            this.grpAnaliz.Name = "grpAnaliz";
            this.grpAnaliz.Size = new System.Drawing.Size(1009, 150);
            this.grpAnaliz.TabIndex = 2;
            this.grpAnaliz.TabStop = false;
            this.grpAnaliz.Text = "Analiz ve İstatistikler";
            // 
            // btnYoneticiSayfa
            // 
            this.btnYoneticiSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYoneticiSayfa.Location = new System.Drawing.Point(607, 53);
            this.btnYoneticiSayfa.Name = "btnYoneticiSayfa";
            this.btnYoneticiSayfa.Size = new System.Drawing.Size(260, 36);
            this.btnYoneticiSayfa.TabIndex = 7;
            this.btnYoneticiSayfa.Text = "Yönetiçi Sayfasına Dön";
            this.btnYoneticiSayfa.UseVisualStyleBackColor = false;
            this.btnYoneticiSayfa.Click += new System.EventHandler(this.btnYoneticiSayfa_Click);
            // 
            // lblEnCokSatilanUrun
            // 
            this.lblEnCokSatilanUrun.Location = new System.Drawing.Point(10, 30);
            this.lblEnCokSatilanUrun.Name = "lblEnCokSatilanUrun";
            this.lblEnCokSatilanUrun.Size = new System.Drawing.Size(100, 23);
            this.lblEnCokSatilanUrun.TabIndex = 0;
            this.lblEnCokSatilanUrun.Text = "En Çok Satılan Ürün:";
            // 
            // txtEnCokSatilanUrun
            // 
            this.txtEnCokSatilanUrun.Location = new System.Drawing.Point(200, 25);
            this.txtEnCokSatilanUrun.Name = "txtEnCokSatilanUrun";
            this.txtEnCokSatilanUrun.Size = new System.Drawing.Size(273, 30);
            this.txtEnCokSatilanUrun.TabIndex = 1;
            // 
            // lblToplamSiparisSayisi
            // 
            this.lblToplamSiparisSayisi.Location = new System.Drawing.Point(10, 66);
            this.lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            this.lblToplamSiparisSayisi.Size = new System.Drawing.Size(100, 23);
            this.lblToplamSiparisSayisi.TabIndex = 2;
            this.lblToplamSiparisSayisi.Text = "Toplam Sipariş Sayısı:";
            // 
            // txtToplamSiparisSayisi
            // 
            this.txtToplamSiparisSayisi.Location = new System.Drawing.Point(200, 61);
            this.txtToplamSiparisSayisi.Name = "txtToplamSiparisSayisi";
            this.txtToplamSiparisSayisi.Size = new System.Drawing.Size(273, 30);
            this.txtToplamSiparisSayisi.TabIndex = 3;
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.Location = new System.Drawing.Point(10, 108);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(100, 23);
            this.lblToplamGelir.TabIndex = 4;
            this.lblToplamGelir.Text = "Toplam Gelir:";
            // 
            // txtToplamGelir
            // 
            this.txtToplamGelir.Location = new System.Drawing.Point(200, 103);
            this.txtToplamGelir.Name = "txtToplamGelir";
            this.txtToplamGelir.Size = new System.Drawing.Size(273, 30);
            this.txtToplamGelir.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Cyan;
            this.btnGuncelle.Location = new System.Drawing.Point(709, 68);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(190, 34);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FrmSiparisIslemRaporlariYonetici
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1056, 550);
            this.Controls.Add(this.grpRaporSecimi);
            this.Controls.Add(this.dtgvRapor);
            this.Controls.Add(this.grpAnaliz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmSiparisIslemRaporlariYonetici";
            this.Text = "Sipariş ve İşlem Raporları";
            this.Load += new System.EventHandler(this.FrmSiparisIslemRaporlariYonetici_Load);
            this.grpRaporSecimi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRapor)).EndInit();
            this.grpAnaliz.ResumeLayout(false);
            this.grpAnaliz.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpRaporSecimi;
        private System.Windows.Forms.Label lblTarihSecimi, lblRaporTuru, lblEnCokSatilanUrun, lblToplamSiparisSayisi, lblToplamGelir;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi, dtpBitisTarihi;
        private System.Windows.Forms.ComboBox cmbRaporTuru;
        private System.Windows.Forms.DataGridView dtgvRapor;
        private System.Windows.Forms.GroupBox grpAnaliz;
        private System.Windows.Forms.TextBox txtEnCokSatilanUrun, txtToplamSiparisSayisi, txtToplamGelir;

    


        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYoneticiSayfa;
        private System.Windows.Forms.Button btnGuncelle;
    }
}