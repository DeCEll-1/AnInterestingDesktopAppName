using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnInterestingWebSiteName.Models
{
    [Serializable]
    public class Kutuphane
    {
        public int ID { get; set; }

        public int Kullanici_ID { get; set; }

        public Kullanici Kullanici { get; set; }

        public int Oyun_ID { get; set; }

        public Urunler Urunler { get; set; }


    }
}