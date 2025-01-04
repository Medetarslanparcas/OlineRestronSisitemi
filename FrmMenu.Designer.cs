using System.Drawing;
using System.Windows.Forms;

namespace OnlineRestoranSiparisTakipSistemi
{
    partial class FrmMenu
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
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.nmcDropDownMiktar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnListeEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbKategory = new System.Windows.Forms.ComboBox();
            this.MinFiyat = new System.Windows.Forms.NumericUpDown();
            this.lvMenu = new System.Windows.Forms.ListView();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Urunler = new System.Windows.Forms.ListBox();
            this.lvlSiparislerim = new System.Windows.Forms.ListView();
            this.btnIptanEt = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnaEkran = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.menuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcDropDownMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinFiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.nmcDropDownMiktar);
            this.menuGroupBox.Controls.Add(this.label1);
            this.menuGroupBox.Controls.Add(this.btnAra);
            this.menuGroupBox.Controls.Add(this.btnListeEkle);
            this.menuGroupBox.Controls.Add(this.label11);
            this.menuGroupBox.Controls.Add(this.label10);
            this.menuGroupBox.Controls.Add(this.label9);
            this.menuGroupBox.Controls.Add(this.label8);
            this.menuGroupBox.Controls.Add(this.MaxFiyat);
            this.menuGroupBox.Controls.Add(this.txtSearch);
            this.menuGroupBox.Controls.Add(this.cmbKategory);
            this.menuGroupBox.Controls.Add(this.MinFiyat);
            this.menuGroupBox.Controls.Add(this.lvMenu);
            this.menuGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.menuGroupBox.Location = new System.Drawing.Point(12, 47);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(500, 446);
            this.menuGroupBox.TabIndex = 0;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menü";
            // 
            // nmcDropDownMiktar
            // 
            this.nmcDropDownMiktar.Font = new System.Drawing.Font("Arial", 10F);
            this.nmcDropDownMiktar.Location = new System.Drawing.Point(172, 328);
            this.nmcDropDownMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcDropDownMiktar.Name = "nmcDropDownMiktar";
            this.nmcDropDownMiktar.Size = new System.Drawing.Size(200, 27);
            this.nmcDropDownMiktar.TabIndex = 12;
            this.nmcDropDownMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Miktar:";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAra.Location = new System.Drawing.Point(20, 363);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(437, 30);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "Ürün Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnListeEkle
            // 
            this.btnListeEkle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnListeEkle.Location = new System.Drawing.Point(20, 399);
            this.btnListeEkle.Name = "btnListeEkle";
            this.btnListeEkle.Size = new System.Drawing.Size(437, 30);
            this.btnListeEkle.TabIndex = 5;
            this.btnListeEkle.Text = "Seçili Ürünü Listeye Ekle";
            this.btnListeEkle.Click += new System.EventHandler(this.btnListeEkle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "Maxsimum Fİyat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Minumum Fiyat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kategori:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ara:";
            // 
            // MaxFiyat
            // 
            this.MaxFiyat.Font = new System.Drawing.Font("Arial", 10F);
            this.MaxFiyat.Location = new System.Drawing.Point(257, 152);
            this.MaxFiyat.Name = "MaxFiyat";
            this.MaxFiyat.Size = new System.Drawing.Size(200, 27);
            this.MaxFiyat.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSearch.Location = new System.Drawing.Point(172, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // cmbKategory
            // 
            this.cmbKategory.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbKategory.Items.AddRange(new object[] {
            "Yemek"});
            this.cmbKategory.Location = new System.Drawing.Point(172, 70);
            this.cmbKategory.Name = "cmbKategory";
            this.cmbKategory.Size = new System.Drawing.Size(200, 27);
            this.cmbKategory.TabIndex = 1;
            // 
            // MinFiyat
            // 
            this.MinFiyat.Font = new System.Drawing.Font("Arial", 10F);
            this.MinFiyat.Location = new System.Drawing.Point(20, 152);
            this.MinFiyat.Name = "MinFiyat";
            this.MinFiyat.Size = new System.Drawing.Size(200, 27);
            this.MinFiyat.TabIndex = 2;
            // 
            // lvMenu
            // 
            this.lvMenu.Font = new System.Drawing.Font("Arial", 10F);
            this.lvMenu.FullRowSelect = true;
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(20, 195);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.Size = new System.Drawing.Size(437, 100);
            this.lvMenu.TabIndex = 3;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            this.lvMenu.View = System.Windows.Forms.View.Details;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSepeteEkle.Location = new System.Drawing.Point(461, 506);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(200, 42);
            this.btnSepeteEkle.TabIndex = 4;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Urunler);
            this.groupBox1.Controls.Add(this.lvlSiparislerim);
            this.groupBox1.Controls.Add(this.btnIptanEt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(583, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 446);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sepete Ekle";
            // 
            // Urunler
            // 
            this.Urunler.FormattingEnabled = true;
            this.Urunler.ItemHeight = 24;
            this.Urunler.Location = new System.Drawing.Point(10, 60);
            this.Urunler.Name = "Urunler";
            this.Urunler.Size = new System.Drawing.Size(426, 100);
            this.Urunler.TabIndex = 21;
            // 
            // lvlSiparislerim
            // 
            this.lvlSiparislerim.Font = new System.Drawing.Font("Arial", 10F);
            this.lvlSiparislerim.FullRowSelect = true;
            this.lvlSiparislerim.HideSelection = false;
            this.lvlSiparislerim.Location = new System.Drawing.Point(12, 271);
            this.lvlSiparislerim.Name = "lvlSiparislerim";
            this.lvlSiparislerim.Size = new System.Drawing.Size(426, 97);
            this.lvlSiparislerim.TabIndex = 20;
            this.lvlSiparislerim.UseCompatibleStateImageBehavior = false;
            this.lvlSiparislerim.View = System.Windows.Forms.View.Details;
            // 
            // btnIptanEt
            // 
            this.btnIptanEt.BackColor = System.Drawing.Color.Yellow;
            this.btnIptanEt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnIptanEt.Location = new System.Drawing.Point(6, 373);
            this.btnIptanEt.Name = "btnIptanEt";
            this.btnIptanEt.Size = new System.Drawing.Size(432, 29);
            this.btnIptanEt.TabIndex = 12;
            this.btnIptanEt.Text = "Seçili Ürünü İptal Et";
            this.btnIptanEt.UseVisualStyleBackColor = false;
            this.btnIptanEt.Click += new System.EventHandler(this.btnIptanEt_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Liste";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 24);
            this.label13.TabIndex = 13;
            this.label13.Text = "Siparişlerim";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(10, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(434, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Seçili Ürünü Listeden Kaldır ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnaEkran
            // 
            this.btnAnaEkran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAnaEkran.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaEkran.Location = new System.Drawing.Point(12, 499);
            this.btnAnaEkran.Name = "btnAnaEkran";
            this.btnAnaEkran.Size = new System.Drawing.Size(182, 49);
            this.btnAnaEkran.TabIndex = 18;
            this.btnAnaEkran.Text = "Ana Ekrana Dön";
            this.btnAnaEkran.UseVisualStyleBackColor = false;
            this.btnAnaEkran.Click += new System.EventHandler(this.btnAnaEkran_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(527, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 16);
            this.lblId.TabIndex = 19;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(47, 13);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(0, 25);
            this.lblAd.TabIndex = 20;
            // 
            // FrmMenu
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1073, 560);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAnaEkran);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(this.btnSepeteEkle);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Sipariş";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuGroupBox.ResumeLayout(false);
            this.menuGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcDropDownMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinFiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      /*  private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox Filtreleme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Icerik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;*/
        private GroupBox menuGroupBox;
        private TextBox txtSearch;
        private ComboBox cmbKategory;
        private NumericUpDown MinFiyat;
        private ListView lvMenu;
        private Button btnSepeteEkle;
        private Label label8;
        private NumericUpDown MaxFiyat;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnListeEkle;
        private GroupBox groupBox1;
        private Button button1;
        private Label label13;
        private Label label12;
        private Button btnIptanEt;
        private Button btnAra;
        private Button btnAnaEkran;
        private Label lblId;
        private Label lblAd;
        private NumericUpDown nmcDropDownMiktar;
        private Label label1;
        private ListView lvlSiparislerim;
        private ListBox Urunler;
    }
}