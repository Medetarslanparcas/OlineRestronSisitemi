using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineRestoranSiparisTakipSistemi
{
    public partial class FrmSiparisIslemRaporlariYonetici : Form
    {
        public FrmSiparisIslemRaporlariYonetici()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();
        public string KullaniciAdi { get; set; }
        private void FrmSiparisIslemRaporlariYonetici_Load(object sender, EventArgs e)
        {
            dtpBaslangicTarihi.Value = DateTime.Today.AddDays(-7);
            dtpBitisTarihi.Value = DateTime.Today;


            cmbRaporTuru.Items.Add("Günlük");
            cmbRaporTuru.Items.Add("Haftalık");
            cmbRaporTuru.Items.Add("Yıllık");
            cmbRaporTuru.Items.Add("Tüm Veriler");  
            cmbRaporTuru.SelectedIndex = 0; 

         
            GetMenuUrunuData();
            GetRolData();
            GetSiparisData();
            GetSiparisDetayiData();
        }

    
        private void btnRaporGoster_Click(object sender, EventArgs e)
        {
            string selectedReportType = cmbRaporTuru.SelectedItem.ToString();
            GetKullaniciDataByDateRange(selectedReportType);
        }

   
        private void GetKullaniciDataByDateRange(string dateRange)
        {
            string query = "";
            DateTime today = DateTime.Today;

    
            switch (dateRange)
            {
                case "Günlük":
                    query = "SELECT [Ad], [Soyad], [Eposta], [Sifre], [Telefon], [Adres], [RolID] " +
                            "FROM [RestoranDB].[dbo].[Kullanici] " +
                            "WHERE DATEDIFF(DAY, [SiparisTarihi], @Today) = 0";
                    break;

                case "Haftalık":
                    query = "SELECT [Ad], [Soyad], [Eposta], [Sifre], [Telefon], [Adres], [RolID] " +
                            "FROM [RestoranDB].[dbo].[Kullanici] " +
                            "WHERE DATEDIFF(WEEK, [SiparisTarihi], @Today) = 0";
                    break;

                case "Yıllık":
                    query = "SELECT [Ad], [Soyad], [Eposta], [Sifre], [Telefon], [Adres], [RolID] " +
                            "FROM [RestoranDB].[dbo].[Kullanici] " +
                            "WHERE DATEDIFF(YEAR, [SiparisTarihi], @Today) = 0";
                    break;

                default:  
                    query = "SELECT [Ad], [Soyad], [Eposta], [Sifre], [Telefon], [Adres], [RolID] " +
                            "FROM [RestoranDB].[dbo].[Kullanici]";
                    break;
            }


            SqlParameter todayParam = new SqlParameter("@Today", SqlDbType.Date) { Value = today };
            DataTable dt = ExecuteQueryWithParameters(query, todayParam);
            dtgvRapor.DataSource = dt;
        }


        private void GetMenuUrunuData()
        {
            string query = "SELECT [UrunAdi], [Kategori], [Fiyat], [Aciklama] FROM [RestoranDB].[dbo].[MenuUrunu]";
            DataTable dt = ExecuteQuery(query);
            dtgvRapor.DataSource = dt;
        }


        private void GetRolData()
        {
            string query = "SELECT [Ad] FROM [RestoranDB].[dbo].[Rol]";
            DataTable dt = ExecuteQuery(query);
            dtgvRapor.DataSource = dt;
        }


        private void GetSiparisData()
        {
            string query = "SELECT [KullaniciID], [SiparisTarihi] FROM [RestoranDB].[dbo].[Siparis]";
            DataTable dt = ExecuteQuery(query);
            dtgvRapor.DataSource = dt;
        }

        private void GetSiparisDetayiData()
        {
            string query = "SELECT [SiparisID], [MenuUrunID], [Miktar], [BirimFiyat], [ToplamTutar], [Durum] FROM [RestoranDB].[dbo].[SiparisDetayi]";
            DataTable dt = ExecuteQuery(query);
            dtgvRapor.DataSource = dt;
        }

 
        private DataTable ExecuteQueryWithParameters(string query, SqlParameter parameter)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = sqlBaglanti.baglanti())
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.Add(parameter);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            return dt;
        }

   
        private DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = sqlBaglanti.baglanti())
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            return dt;
        }

 
        private void btnYoneticiSayfa_Click(object sender, EventArgs e)
        {
            FrmYonetici frm = new FrmYonetici();
            frm.KullaniciAdi = KullaniciAdi;
            frm.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DateTime basTarih = dtpBaslangicTarihi.Value.Date;
            DateTime bitTarih = dtpBitisTarihi.Value.Date;

            string query = @"
    SELECT sd.*
    FROM [RestoranDB].[dbo].[SiparisDetayi] sd
    INNER JOIN [RestoranDB].[dbo].[Siparis] s ON sd.SiparisID = s.Id
    WHERE s.SiparisTarihi BETWEEN @BaslangicTarihi AND @BitisTarihi";

            SqlParameter baslangicParam = new SqlParameter("@BaslangicTarihi", SqlDbType.Date) { Value = basTarih };
    SqlParameter bitisParam = new SqlParameter("@BitisTarihi", SqlDbType.Date) { Value = bitTarih };


    DataTable dt = ExecuteQueryWithParameters(query, baslangicParam, bitisParam);

    
    dtgvRapor.DataSource = dt;
        }


        private DataTable ExecuteQueryWithParameters(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = sqlBaglanti.baglanti())
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    foreach (var parameter in parameters)
                    {
                        adapter.SelectCommand.Parameters.Add(parameter);
                    }
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            return dt;
        }





    }
}
