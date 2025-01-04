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
using System.Text.RegularExpressions;
namespace OnlineRestoranSiparisTakipSistemi
{
    public partial class FrmCalisanYonetimi : Form
    {

        public string KullaniciAdi { get; set; }
        SqlBaglanti sqlbaglantisi = new SqlBaglanti();
        public FrmCalisanYonetimi()
        {
            InitializeComponent();
        }
       
        private void FrmCalisanYonetimi_Load(object sender, EventArgs e)
        {

            
            dtgvCalisanKaldir.Font = new Font("Arial", 10);
            dtgvCalisanKaldir.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(
    "SELECT * " +
    "FROM [RestoranDB].[dbo].[Kullanici] K " +
    "JOIN [RestoranDB].[dbo].[Rol] R ON K.[RolID] = R.[Id] " +
    "WHERE R.[Ad] = 'Çalışan' " +
    "ORDER BY K.[Id] DESC;",
    sqlbaglantisi.baglanti());


            adapter.Fill(dt);
            dtgvCalisanKaldir.DataSource = dt;
        }

        private void btnCalisanKaldir_Click(object sender, EventArgs e)
        {
            if (dtgvCalisanKaldir.SelectedRows.Count > 0)
            {
                Guid kullaniciID = (Guid)dtgvCalisanKaldir.SelectedRows[0].Cells["Id"].Value;

                DialogResult result = MessageBox.Show(
                    "Seçili kullanıcıyı ve ilgili verileri silmek istediğinizden emin misiniz?",
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
                            string deleteSiparisDetayiQuery = "DELETE FROM dbo.SiparisDetayi WHERE SiparisID IN (SELECT Id FROM dbo.Siparis WHERE KullaniciID = @KullaniciID)";
                            SqlCommand cmdSiparisDetayi = new SqlCommand(deleteSiparisDetayiQuery, conn);
                            cmdSiparisDetayi.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                            string deleteSiparisQuery = "DELETE FROM dbo.Siparis WHERE KullaniciID = @KullaniciID";
                            SqlCommand cmdSiparis = new SqlCommand(deleteSiparisQuery, conn);
                            cmdSiparis.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                            string deleteKullaniciQuery = "DELETE FROM dbo.Kullanici WHERE Id = @KullaniciID";
                            SqlCommand cmdKullanici = new SqlCommand(deleteKullaniciQuery, conn);
                            cmdKullanici.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                            conn.Open();

                            cmdSiparisDetayi.ExecuteNonQuery();
                            cmdSiparis.ExecuteNonQuery();
                            cmdKullanici.ExecuteNonQuery();

                            MessageBox.Show("Seçili kullanıcı ve ilgili veriler başarıyla silindi.");

                            FrmCalisanYonetimi_Load(sender, e);
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
                MessageBox.Show("Silinecek kullanıcıyı seçin.");
            }
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {



            string email = txtCalisanEposta.Text;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex emailRegex = new Regex(emailPattern);

            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("Geçersiz e-posta adresi! Lütfen geçerli bir e-posta adresi girin.");
                return;
            }

            string sifre = txtCalisanSifre.Text;
            string sifrePattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            Regex sifreRegex = new Regex(sifrePattern);

            if (!sifreRegex.IsMatch(sifre))
            {
                MessageBox.Show("Parola en az 8 karakter, bir büyük harf, bir küçük harf ve bir sayı içermelidir!");
                return;
            }



            SqlConnection conn = sqlbaglantisi.baglanti();
            try
            {
                conn.Open();

                SqlCommand checkEmailCommand = new SqlCommand(
                    "SELECT COUNT(*) FROM dbo.Kullanici WHERE Eposta = @pEmail", conn);
                checkEmailCommand.Parameters.AddWithValue("@pEmail", email);

                int emailCount = (int)checkEmailCommand.ExecuteScalar();

                if (emailCount > 0)
                {
                    MessageBox.Show("Bu e-posta adresi zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand sqlCommand = new SqlCommand(
                    "INSERT INTO dbo.Kullanici(Ad, Soyad, Eposta, Sifre, Telefon, Adres, RolID) " +
                    "VALUES(@p1, @p2, @p3, @p4, @p5, @p6, (SELECT Id FROM dbo.Rol WHERE Ad = 'Çalışan'))", conn);

                sqlCommand.Parameters.AddWithValue("@p1", txtCalisanAd.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtCalisanSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@p3", email);
                sqlCommand.Parameters.AddWithValue("@p4", sifre);
                sqlCommand.Parameters.AddWithValue("@p5", txtCalisanTelefon.Text);
                sqlCommand.Parameters.AddWithValue("@p6", txtCalisanAdres.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCalisanAd.Text = "";
                txtCalisanSoyad.Text = "";
                txtCalisanEposta.Text = "";
                txtCalisanSifre.Text = "";
                txtCalisanAdres.Text = "";
                txtCalisanTelefon.Text = "";

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

        private void btnYoneticiAnaEkran_Click(object sender, EventArgs e)
        {
            FrmYonetici frm = new FrmYonetici();
            frm.KullaniciAdi = KullaniciAdi;

            frm.Show();
            this.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifre.Checked)
            {
                txtCalisanSifre.PasswordChar = '\0';
            }
            else
            {
                txtCalisanSifre.PasswordChar = '*';
            }
        }

  
    }
}
