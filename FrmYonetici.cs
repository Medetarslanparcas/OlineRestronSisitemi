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
    public partial class FrmYonetici : Form
    {
        public string KullaniciAdi { get; set; }
        public FrmYonetici()
        {
            InitializeComponent();
        }

        private void FrmYonetici_Load(object sender, EventArgs e)
        {
            lblYoneticiAd.Text = $"Hoşgeldiniz, {KullaniciAdi}";
        }

        private void btnCalisanYonetimSistemi_Click(object sender, EventArgs e)
        {
            FrmCalisanYonetimi frm = new FrmCalisanYonetimi();
            frm.KullaniciAdi = KullaniciAdi;
            frm.Show();
            this.Hide();

        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            FrmAnaEkran anaEkran = new FrmAnaEkran();
            anaEkran.Show();
            this.Hide();

        }

        private void btnMenuYonetimSistemi_Click(object sender, EventArgs e)
        {
            FrmMenuYonetimi frm = new FrmMenuYonetimi();
            frm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSiparisIslemRaporlariYonetici frm = new FrmSiparisIslemRaporlariYonetici();
            frm.Show();
            this.Hide();

        }
    }
}
