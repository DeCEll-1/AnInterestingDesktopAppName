using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace AnInterestingWebSiteName.Models
{
    [Serializable]
    public class Yonetici
    {
        public int ID { get; set; }

        public int YoneticiTur_ID { get; set; }

        public virtual YoneticiTur YoneticiTur { get; set; }

        public string Isim { get; set; }

        public string SoyIsim { get; set; }

        public string KullaniciAdi { get; set; }

        public string ProfilFotografi { get; set; }

        public string Sifre { get; set; }

        public string Mail { get; set; }

        public bool Aktifmi { get; set; }

    }
}