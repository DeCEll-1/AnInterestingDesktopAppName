using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AnInterestingWebSiteName.Models
{
    [Serializable]
    public class Urunler
    {

        public int ID { get; set; }

        public int Yapimci_ID { get; set; }

        public Firma Yapimci { get; set; }

        public int? Yayinci_ID { get; set; }

        public Firma Yayinci { get; set; }

        public string Ad { get; set; }

        public string Aciklama { get; set; }

        public string AciklamaAlt1 { get; set; }

        public string AciklamaAlt2 { get; set; }

        public string AciklamaAlt3 { get; set; }

        public double Fiyat { get; set; }

        public byte? Indirim { get; set; }

        public double? IndirimliFiyat { get; set; }

        public string IkonYolu { get; set; }

        public string TamResimYolu { get; set; }

        public string ArkaPlanResmi { get; set; }

        public DateTime YayinTarihi { get; set; }

        public bool Aktifmi { get; set; }
    }
}