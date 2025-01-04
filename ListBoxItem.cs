using System;

namespace OnlineRestoranSiparisTakipSistemi
{
    internal class ListBoxItem
    {
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public decimal ToplamFiyat { get; set; }
        public Guid MenuUrunId { get; set; }
        public object SubItems { get; internal set; }
    }
}