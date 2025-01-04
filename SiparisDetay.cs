using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRestoranSiparisTakipSistemi
{
    public class SiparisDetay
    {
        public string MenuUrunID { get; set; }
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public string BirimFiyat1 { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal ToplamTutar => Miktar * BirimFiyat;
    }
}
