using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace OnlineRestoranSiparisTakipSistemi
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifre.Checked)
            {
                txtKayitOlParola.PasswordChar = '\0'; 
            }
            else
            {
                txtKayitOlParola.PasswordChar = '*';
            }
        }

     
        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
          
            string email = txtKayitOlEposta.Text;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex emailRegex = new Regex(emailPattern);

            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("Geçersiz e-posta adresi! Lütfen geçerli bir e-posta adresi girin.");
                return;
            }

            string sifre = txtKayitOlParola.Text;
            string sifrePattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            Regex sifreRegex = new Regex(sifrePattern);

            if (!sifreRegex.IsMatch(sifre))
            {
                MessageBox.Show("Parola en az 8 karakter, bir büyük harf, bir küçük harf ve bir sayı içermelidir!");
                return;
            }



            SqlConnection conn = sqlBaglanti.baglanti();
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
                    "VALUES(@p1, @p2, @p3, @p4, @p5, @p6, (SELECT Id FROM dbo.Rol WHERE Ad = 'Müşteri'))", conn);

                sqlCommand.Parameters.AddWithValue("@p1", txtAd.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@p3", email);
                sqlCommand.Parameters.AddWithValue("@p4", sifre);
                sqlCommand.Parameters.AddWithValue("@p5", maskedTxtTelefonNo.Text);
                sqlCommand.Parameters.AddWithValue("@p6", txtAdres.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmMusteriGiris musteriGiris = new FrmMusteriGiris();
                musteriGiris.Show();
                this.Hide();
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

    }
}
