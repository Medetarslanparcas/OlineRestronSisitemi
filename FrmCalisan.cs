using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineRestoranSiparisTakipSistemi
{
    public partial class FrmCalisan : Form
    {
        public string KullaniciAdi { get; set; }
        public FrmCalisan()
        {
            InitializeComponent();
        }
 SqlBaglanti sqlbaglantisi = new SqlBaglanti();
        private void FrmCalisan_Load(object sender, EventArgs e)
        {
            lblCalisanAd.Text = $"Hoşgeldiniz, {KullaniciAdi}";
            dataGridViewAktifSiparis.Font = new Font("Arial", 10);
            dataGridViewAktifSiparis.DefaultCellStyle.WrapMode = DataGridViewTriState.False;


            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(
    "SELECT S.[Id] AS SiparisID, " +
        "MU.[UrunAdi], " +
        "K.[Ad] + ' ' + K.[Soyad] AS MusteriAdSoyad, " +
        "K.[Telefon] AS MusteriTelefon, " +
        "K.[Adres] AS TeslimatAdresi, " +
        "SD.[ToplamTutar], " +
        "SD.[Miktar], " +
        "SD.[Durum] " +
        "FROM [RestoranDB].[dbo].[Siparis] S " +
        "JOIN [RestoranDB].[dbo].[Kullanici] K ON S.KullaniciID = K.Id " +
        "JOIN [RestoranDB].[dbo].[SiparisDetayi] SD ON S.Id = SD.SiparisID " +
        "JOIN [RestoranDB].[dbo].[MenuUrunu] MU ON SD.MenuUrunID = MU.Id " +
        "WHERE SD.[Durum] = 'Hazırlanıyor...' " +
        "ORDER BY S.[Id] DESC;",
    sqlbaglantisi.baglanti());


            adapter.Fill(dt);
            dataGridViewAktifSiparis.DataSource = dt;
            foreach (DataGridViewColumn col in dataGridViewAktifSiparis.Columns)
            {
                col.ReadOnly = col.Name != "Durum";
            }
            SiparisOzetiniGuncelle();
        }

        private void SiparisOzetiniGuncelle()
        {
            using (SqlConnection conn = sqlbaglantisi.baglanti())
            {
                try
                {
                    conn.Open();

                  
                    SqlCommand toplamSiparisKomut = new SqlCommand(
                        "SELECT COUNT(*) FROM dbo.Siparis", conn);
                    int toplamSiparisSayisi = (int)toplamSiparisKomut.ExecuteScalar();
                    lblToplamSiparis.Text = $"{toplamSiparisSayisi}";

                   
                    SqlCommand toplamTutarKomut = new SqlCommand(
                        "SELECT ISNULL(SUM(ToplamTutar), 0) FROM dbo.SiparisDetayi", conn);
                    decimal toplamTutar = (decimal)toplamTutarKomut.ExecuteScalar();
                    lblToplamTutar.Text = $"{toplamTutar:C}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }







        private void btnDurumGüncelleme_Click(object sender, EventArgs e)
        {
            if (dataGridViewAktifSiparis.CurrentRow != null)
            {
            
                Guid siparisId = Guid.Parse(dataGridViewAktifSiparis.CurrentRow.Cells["SiparisID"].Value.ToString());

             
                string yeniDurum = dataGridViewAktifSiparis.CurrentRow.Cells["Durum"].Value.ToString();

          
                if (string.IsNullOrWhiteSpace(yeniDurum))
                {
                    MessageBox.Show("Lütfen durum alanını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                string sorgu = "UPDATE dbo.SiparisDetayi SET Durum = @Durum WHERE SiparisID = @SiparisID";

                using (SqlConnection conn = sqlbaglantisi.baglanti())
                {
                    using (SqlCommand komut = new SqlCommand(sorgu, conn))
                    {
                       
                        komut.Parameters.AddWithValue("@Durum", yeniDurum);
                        komut.Parameters.AddWithValue("@SiparisID", siparisId);

                        try
                        {
                           
                            conn.Open();
                            int etkilenenSatir = komut.ExecuteNonQuery();

                            if (etkilenenSatir > 0)
                            {
                                
                                MessageBox.Show("Sipariş durumu başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                             
                                MessageBox.Show("Sipariş güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                          
                            MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
             
                MessageBox.Show("Lütfen güncellemek için bir sipariş seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmAnaEkran frm = new FrmAnaEkran();
            frm.Show();
            this.Hide();

        }

      
    }
}
