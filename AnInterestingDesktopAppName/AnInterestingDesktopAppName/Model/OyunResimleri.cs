using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnInterestingWebSiteName.Models
{
    [Serializable]
    public class OyunResimleri
    {
        public int ID { get; set; }

        public int Oyun_ID { get; set; }

        public virtual Urunler Urunler { get; set; }

        public string Resim { get; set; }

        public bool Aktifmi { get; set; }
    }
}