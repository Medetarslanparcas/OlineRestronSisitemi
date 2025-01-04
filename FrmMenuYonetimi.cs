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
   
    public partial class FrmMenuYonetimi : Form
    { SqlBaglanti sqlbaglantisi = new SqlBaglanti();
        public FrmMenuYonetimi()
        {
            InitializeComponent();
        }
        public string KullaniciAdi { get; set; }

        private void btnYoneticiAnaEkran_Click(object sender, EventArgs e)
        {
            FrmYonetici frm = new FrmYonetici();
            frm.KullaniciAdi = KullaniciAdi;

            frm.Show();
        }

        private void FrmMenuYonetimi_Load(object sender, EventArgs e)
        {
            dtgvUrunListesi.Font = new Font("Arial", 10);
            dtgvUrunListesi.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(
    "SELECT * " +
    "FROM [RestoranDB].[dbo].[MenuUrunu];",
    sqlbaglantisi.baglanti());


            adapter.Fill(dt);
            dtgvUrunListesi.DataSource = dt;
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dtgvUrunListesi.SelectedRows.Count > 0)
            {
                Guid urunID = (Guid)dtgvUrunListesi.SelectedRows[0].Cells["Id"].Value;

                DialogResult result = MessageBox.Show(
                    "Seçili ürünü ve ilgili verileri silmek istediğinizden emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = sqlbaglantisi.baglanti())
                        {
                           
                            string deleteSiparisDetayiQuery = "DELETE FROM dbo.SiparisDetayi WHERE MenuUrunuID = @UrunID";
                            SqlCommand cmdSiparisDetayi = new SqlCommand(deleteSiparisDetayiQuery, conn);
                            cmdSiparisDetayi.Parameters.AddWithValue("@UrunID", urunID);

                            
                            string deleteMenuUrunuQuery = "DELETE FROM dbo.MenuUrunu WHERE Id = @UrunID";
                            SqlCommand cmdMenuUrunu = new SqlCommand(deleteMenuUrunuQuery, conn);
                            cmdMenuUrunu.Parameters.AddWithValue("@UrunID", urunID);

                            conn.Open();

                       
                            cmdSiparisDetayi.ExecuteNonQuery();
                            cmdMenuUrunu.ExecuteNonQuery();

                            MessageBox.Show("Seçili ürün ve ilgili veriler başarıyla silindi.");

                            FrmMenuYonetimi_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silinecek ürünü seçin.");
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            SqlConnection conn = sqlbaglantisi.baglanti();
            try
            {
                conn.Open();

              

                SqlCommand sqlCommand = new SqlCommand(
                    "INSERT INTO dbo.MenuUrunu(UrunAdi, Kategori, Fiyat,Aciklama) " +
                    "VALUES(@p1, @p2, @p3, @p4)", conn);

                sqlCommand.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtUrunKategori.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtUrunFiyat.Text);
                sqlCommand.Parameters.AddWithValue("@p4", txtUrunAciklama.Text);
       

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUrunAd.Text = "";
                txtUrunKategori.Text = "";
                txtUrunFiyat.Text = "";
                txtUrunAciklama.Text = "";
             

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }


        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (dtgvUrunListesi.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtUrunAd.Text) ||
                    string.IsNullOrWhiteSpace(txtUrunKategori.Text) ||
                    string.IsNullOrWhiteSpace(txtUrunFiyat.Text) ||
                    string.IsNullOrWhiteSpace(txtUrunAciklama.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtUrunFiyat.Text, out decimal fiyat))
                {
                    MessageBox.Show("Geçerli bir fiyat girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Guid urunID = (Guid)dtgvUrunListesi.SelectedRows[0].Cells["Id"].Value;

                using (SqlConnection conn = sqlbaglantisi.baglanti())
                {
                    try
                    {
                        conn.Open();

                        SqlCommand sqlCommand = new SqlCommand(
                            "UPDATE dbo.MenuUrunu " +
                            "SET UrunAdi = @p1, Kategori = @p2, Fiyat = @p3, Aciklama = @p4 " +
                            "WHERE Id = @p5", conn);

                        sqlCommand.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                        sqlCommand.Parameters.AddWithValue("@p2", txtUrunKategori.Text);
                        sqlCommand.Parameters.AddWithValue("@p3", fiyat);
                        sqlCommand.Parameters.AddWithValue("@p4", txtUrunAciklama.Text);
                        sqlCommand.Parameters.AddWithValue("@p5", urunID);

                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Alanları temizle
                        txtUrunAd.Text = "";
                        txtUrunKategori.Text = "";
                        txtUrunFiyat.Text = "";
                        txtUrunAciklama.Text = "";

                        // Formu yeniden yükle
                        FrmMenuYonetimi_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek ürünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
