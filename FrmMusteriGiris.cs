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
    public partial class FrmMusteriGiris : Form
    {
        public FrmMusteriGiris()
        {
            InitializeComponent();
        }

        private void SifreGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (SifreGöster.Checked)
            {
                txtMusteriPassword.PasswordChar = '\0';
            }
            else
            {
                txtMusteriPassword.PasswordChar = '*'; 
            }
        }

       

        private void KayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayitOl kayitOl = new FrmKayitOl();
            kayitOl.Show();

        }

        private void btnAnaEkran_Click(object sender, EventArgs e)
        {
            FrmAnaEkran frmAnaEkran = new FrmAnaEkran();
            frmAnaEkran.Show();
            this.Hide();
        }
        SqlBaglanti sqlbaglantisi = new SqlBaglanti();
        private void btnMusteriGiris_Click(object sender, EventArgs e)
        {
      

            SqlConnection conn = sqlbaglantisi.baglanti();
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "Select * From dbo.Kullanici Where Eposta=@p1 and Sifre=@p2", conn);
                sqlCommand.Parameters.AddWithValue("@p1", txtMusteriEmail.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtMusteriPassword.Text);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    FrmMenu menu = new FrmMenu();
                    menu.kullaniciAdi = reader["Ad"].ToString();
                    menu.kullaniciId = reader["Id"].ToString();
                    menu.Show();
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
    }
}
