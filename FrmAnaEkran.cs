using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRestoranSiparisTakipSistemi
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        private void Yonetici_Click(object sender, EventArgs e)
        {


            FrmYoneticiGiris frm = new FrmYoneticiGiris();
            frm.Show();
            this.Hide();
        }

        private void Musteri_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris musteri = new FrmMusteriGiris();

            musteri.Show();
            this.Hide();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();

        }

        private void Calisan_Click(object sender, EventArgs e)
        {
            FrmCalisanGiris frm = new FrmCalisanGiris();
            frm.Show();
            this.Hide();

        }
    }
}
