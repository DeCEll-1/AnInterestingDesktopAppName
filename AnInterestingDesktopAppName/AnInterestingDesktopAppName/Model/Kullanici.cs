using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnInterestingWebSiteName.Models
{
    [Serializable]
    public class Kullanici
    {
        public int ID { get; set; }

        public string Ad { get; set; }

        public string Sifre { get; set; }

        public string Mail { get; set; }

        public string Aciklama { get; set; }

        public string ProfilResmi { get; set; }

        public bool Aktifmi { get; set; }
    }
}