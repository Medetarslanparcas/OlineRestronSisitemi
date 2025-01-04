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
    public partial class FrmYoneticiGiris : Form
    {
        public FrmYoneticiGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti sqlbaglantisi = new SqlBaglanti();
        private void BtnYoneticiGiris_Click(object sender, EventArgs e)
        {
            SqlConnection conn = sqlbaglantisi.baglanti();
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "Select * From dbo.Kullanici Where Eposta=@p1 and Sifre=@p2", conn);
                sqlCommand.Parameters.AddWithValue("@p1", txtEmail.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtPassword.Text);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    FrmYonetici yonetici = new FrmYonetici();
                    yonetici.KullaniciAdi = reader["Ad"].ToString();
                    yonetici.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Eposta veya Şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void chckSifreGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSifreGöster.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnAnaEkran_Click(object sender, EventArgs e)
        {
            FrmAnaEkran frmAnaEkran = new FrmAnaEkran();
            frmAnaEkran.Show();
            this.Hide();

        }
    }
}
