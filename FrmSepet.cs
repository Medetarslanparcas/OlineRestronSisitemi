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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;

namespace OnlineRestoranSiparisTakipSistemi
{
    public partial class FrmSepet : Form
    {
        public string kullaniciId { get; set; }
        public string musteriAd { get; set; }
        public string siparisId { get; set; }
        List<SiparisDetay> sepetDetaylari = new List<SiparisDetay>();

        public FrmSepet()
        {
            InitializeComponent();
        }
           SqlBaglanti sqlBaglanti = new SqlBaglanti();
        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {

     
            SqlConnection conn = sqlBaglanti.baglanti();
            try
            {
                conn.Open();

              
                SqlCommand sqlCommand = new SqlCommand(
                    "INSERT INTO dbo.Siparis(KullaniciID, SiparisTarihi) " +
                    "OUTPUT INSERTED.Id " + 
                    "VALUES(@kullaniciId, @siparisTarihi)", conn);

                sqlCommand.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                sqlCommand.Parameters.AddWithValue("@siparisTarihi", DateTime.Now);

                var siparisId = sqlCommand.ExecuteScalar();

             
                foreach (var detay in sepetDetaylari)
                { 
                  
                    SqlCommand sqlCommandDetay = new SqlCommand(
                        "INSERT INTO dbo.SiparisDetayi(SiparisID,MenuUrunID, Miktar,BirimFiyat,ToplamTutar,Durum) " +
                        "VALUES(@p1,(SELECT Id FROM dbo.MenuUrunu WHERE UrunAdi =@p2 ),@p3,@p4,@p5,@p6)", conn);

                    sqlCommandDetay.Parameters.AddWithValue("@p1", siparisId); 
                    sqlCommandDetay.Parameters.AddWithValue("@p2", detay.UrunAdi);
                    sqlCommandDetay.Parameters.AddWithValue("@p3", detay.Miktar);
                       sqlCommandDetay.Parameters.AddWithValue("@p4",detay.BirimFiyat);
                    sqlCommandDetay.Parameters.AddWithValue("@p5", detay.ToplamTutar);
                    sqlCommandDetay.Parameters.AddWithValue("@p6", "Hazırlanıyor...");
                    sqlCommandDetay.ExecuteNonQuery();
                }

                MessageBox.Show("Siparişiniz başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            FrmSiparisTakip takip = new FrmSiparisTakip();

            takip.kullaniciId = kullaniciId;
            takip.musteriAd = musteriAd;

            takip.Show();
            this.Hide();

        }

        private void FrmSepet_Load(object sender, EventArgs e)
        {
            lblAd.Text = $"Hoşgeldiniz, {musteriAd}";
   
        }


        public void EkleUrun(SiparisDetay urun)
        {
            sepetDetaylari.Add(urun);
            ListeGuncelle(); 
        }
        private void ListeGuncelle()
        {
            Urunler.Items.Clear(); 

            foreach (var detay in sepetDetaylari)
            {
               
                string urunBilgisi = $"{detay.UrunAdi} - {detay.Kategori}-{detay.ToplamTutar}";
                Urunler.Items.Add(urunBilgisi);  
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Urunler.SelectedItems.Count > 0)
            {
                List<object> secilenUrunler = new List<object>(Urunler.SelectedItems.Cast<object>());

              
                foreach (object urun in secilenUrunler)
                {
                    Urunler.Items.Remove(urun);
                }

               
                Urunler.ClearSelected();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.kullaniciAdi = musteriAd;
            frmMenu.kullaniciId = kullaniciId;

            frmMenu.Show();
            this.Hide();


        }
    }
}
