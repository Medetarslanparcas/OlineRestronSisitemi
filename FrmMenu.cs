using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace OnlineRestoranSiparisTakipSistemi
{
   
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
         
        }
        public string kullaniciAdi { get; set; }
        public string kullaniciId  { get; set; }
        List<SiparisDetay> sepetDetaylari = new List<SiparisDetay>();


        private void btnAnaEkran_Click(object sender, EventArgs e)
        {
            FrmAnaEkran frmAnaEkran = new FrmAnaEkran();
            frmAnaEkran.Show();
            this.Hide();



         

        }
        SqlBaglanti sqlbaglantisi = new SqlBaglanti();
        private void FrmMenu_Load(object sender, EventArgs e)
        {
          

            KategorileriYukle();

            lvMenu.Columns.Add("ID", 150, HorizontalAlignment.Left); 
            lvMenu.Columns.Add("Kategori", 100, HorizontalAlignment.Left);
            lvMenu.Columns.Add("Menu Adı", 100, HorizontalAlignment.Left);
            lvMenu.Columns.Add("Toplam Tutar", 100, HorizontalAlignment.Left);
            lvlSiparislerim.Columns.Add("Ürün Adı", 150, HorizontalAlignment.Left);
            lvMenu.Columns.Add("Fiyat",50, HorizontalAlignment.Left);
            lvlSiparislerim.Columns.Add("Ürün Adı", 150, HorizontalAlignment.Left);
            lvlSiparislerim.Columns.Add("Tarih", 100, HorizontalAlignment.Left);
            lvlSiparislerim.Columns.Add("Toplam Tutar", 100, HorizontalAlignment.Left);
            lvlSiparislerim.Columns.Add("Durum", 100, HorizontalAlignment.Left);

            Ac();

            if (!String.IsNullOrEmpty(kullaniciId))
            {
                lblAd.Text = $"Hoşgeldiniz, {kullaniciAdi}";
                Gecmis();
            }
           
        }
        private void Gecmis()
        {
            lvlSiparislerim.Items.Clear();

            string query = @"
        SELECT mu.UrunAdi, o.SiparisTarihi, od.ToplamTutar, od.Durum
        FROM Siparis o
        JOIN SiparisDetayi od ON o.Id = od.SiparisID
        JOIN MenuUrunu mu ON od.MenuUrunID = mu.Id
        WHERE o.KullaniciId = @kullaniciId
        ORDER BY o.SiparisTarihi DESC";

            SqlConnection conn = sqlbaglantisi.baglanti();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["UrunAdi"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["SiparisTarihi"]).ToString("dd.MM.yyyy"));
                    item.SubItems.Add(string.Format("{0:C}", reader["ToplamTutar"]));
                    item.SubItems.Add(reader["Durum"].ToString());

                    lvlSiparislerim.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }



        private void Ac()
        {
     
            lvMenu.Items.Clear();
            string query = "SELECT  [Id], [UrunAdi], [Kategori], [Fiyat] FROM [RestoranDB].[dbo].[MenuUrunu] ";
            
       

            SqlConnection conn = sqlbaglantisi.baglanti();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
           
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Id"].ToString());
                    item.SubItems.Add(reader["Kategori"].ToString());
                    item.SubItems.Add(reader["UrunAdi"].ToString());
                    item.SubItems.Add(reader["Fiyat"].ToString());
                    lvMenu.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void Listele(string filter = "", string kategori = "", decimal minFiyat = 0, decimal maxFiyat = decimal.MaxValue)
        {
            lvMenu.Items.Clear();
            string query = "SELECT [Id], [UrunAdi], [Kategori], [Fiyat] FROM [RestoranDB].[dbo].[MenuUrunu] " +
                           "WHERE (@Kategori IS NULL OR [Kategori] = @kategori) " +
                           "AND (CAST([Fiyat] AS DECIMAL(10, 2)) >= @minFiyat AND CAST([Fiyat] AS DECIMAL(10, 2)) <= @maxFiyat) " +
                           "AND ([UrunAdi] LIKE @filter)";

            SqlConnection conn = sqlbaglantisi.baglanti();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                
                if (!string.IsNullOrEmpty(filter))
                {
                    cmd.Parameters.AddWithValue("@Filter", "%" + filter + "%");
                }

                
                cmd.Parameters.AddWithValue("@Kategori", string.IsNullOrEmpty(kategori) ? DBNull.Value : (object)kategori);

               
                cmd.Parameters.AddWithValue("@MinFiyat", minFiyat);
                cmd.Parameters.AddWithValue("@MaxFiyat", maxFiyat);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Id"].ToString());
                    item.SubItems.Add(reader["Kategori"].ToString());
                    item.SubItems.Add(reader["UrunAdi"].ToString());
                    item.SubItems.Add(reader["Fiyat"].ToString());
                    lvMenu.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }



        private void btnAra_Click(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();
            string kategoriFilter = cmbKategory.SelectedItem?.ToString();

            
            decimal minFiyat = MinFiyat.Value;
            decimal maxFiyat = MaxFiyat.Value;


            if (string.IsNullOrEmpty(filterText) && string.IsNullOrEmpty(kategoriFilter))
            {

             
                MessageBox.Show("Lütfen arama metni ve kategori seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
            
                Listele(filterText, kategoriFilter, minFiyat, maxFiyat);
            }
        }

        private void btnListeEkle_Click(object sender, EventArgs e)
        {
            if (lvMenu.SelectedItems.Count > 0)
            {
                ListViewItem seciliItem = lvMenu.SelectedItems[0];
                string urunKategori = seciliItem.SubItems[1].Text;
                string fiyatMetin = seciliItem.SubItems[3].Text;
                string urunAd = seciliItem.SubItems[2].Text;
          
                string temizFiyatMetin = new string(fiyatMetin.Where(char.IsDigit).ToArray());
                int miktar = (int)nmcDropDownMiktar.Value;

                if (decimal.TryParse(fiyatMetin, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal birimFiyat))
                {
                    decimal toplamFiyat = birimFiyat * miktar;

                   
                    SiparisDetay detay = new SiparisDetay
                    {
                        Miktar = miktar,
                        BirimFiyat = birimFiyat,
                        UrunAdi = urunAd,
                        Kategori = urunKategori,
                    
                    };

                    sepetDetaylari.Add(detay);

                   
                    Urunler.Items.Add($"{urunAd}-{urunKategori}- {toplamFiyat:C}");
                    lvMenu.SelectedItems.Clear();
                }
                else
                {
                    MessageBox.Show($"Fiyat geçerli bir sayı değil: {fiyatMetin}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (Urunler.SelectedItems != null) 
            {
                Urunler.Items.Remove(Urunler.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kullaniciId))
            {
                MessageBox.Show("Lütfen giriş yapınız.", "Giriş Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                FrmMusteriGiris giris = new FrmMusteriGiris();
                giris.Show();
                this.Hide();
            }
            else
            {
                FrmSepet frmSepet = new FrmSepet();

                frmSepet.kullaniciId = kullaniciId;
                frmSepet.musteriAd = kullaniciAdi;

                foreach (var item in Urunler.Items)
                {
                    string[] bilgiler = item.ToString().Split('-');
                    string urunAdi = bilgiler[0].Trim();
                    string kategori = bilgiler[1].Trim();
                    decimal birimFiyat = decimal.Parse(bilgiler[2].Trim(' ', '₺'));
                    
                    SiparisDetay detay = new SiparisDetay
                    {
                     
                        Miktar = (int)nmcDropDownMiktar.Value,
                        BirimFiyat = birimFiyat,
                        UrunAdi = urunAdi,
                        Kategori = kategori
                    };

                    
                    sepetDetaylari.Add(detay);
                    frmSepet.EkleUrun(detay);
                }

                frmSepet.Show();
                this.Hide();
            }
        }
        private void KategorileriYukle()
        {
            cmbKategory.Items.Clear();  

            string query = "SELECT DISTINCT [Kategori] FROM [RestoranDB].[dbo].[MenuUrunu] WHERE [Kategori] IS NOT NULL";

            SqlConnection conn = sqlbaglantisi.baglanti();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbKategory.Items.Add(reader["Kategori"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnIptanEt_Click(object sender, EventArgs e)
        {
            if (lvlSiparislerim.SelectedItems.Count > 0)
            {
                // Seçili ürünün adını doğru şekilde alalım
                string urunAdi = lvlSiparislerim.SelectedItems[0].SubItems[0].Text;

                SqlConnection conn = sqlbaglantisi.baglanti();
                string query = "SELECT Durum FROM SiparisDetayi WHERE MenuUrunID = (SELECT Id FROM MenuUrunu WHERE UrunAdi = @urunAdi)";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@urunAdi", urunAdi);

                    string durum = cmd.ExecuteScalar()?.ToString();

                    if (durum == "Hazırlanıyor...")
                    {
                        lvlSiparislerim.Items.Remove(lvlSiparislerim.SelectedItems[0]);
                        MessageBox.Show("Ürün başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Yalnızca 'Hazırlanıyor...' durumundaki ürünler silinebilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
