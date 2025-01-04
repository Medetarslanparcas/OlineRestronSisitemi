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
    public partial class FrmSiparisTakip : Form
    {

        public string kullaniciId { get; set; }
        public string musteriAd { get; set; }
        public FrmSiparisTakip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.kullaniciId = kullaniciId;
            menu.kullaniciAdi = musteriAd;

            menu.Show();

        }

        private void FrmSiparisTakip_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(kullaniciId))
            {
                lblAd.Text = $"Hoşgeldiniz, {musteriAd}";
         
            }
        }
    }
}
