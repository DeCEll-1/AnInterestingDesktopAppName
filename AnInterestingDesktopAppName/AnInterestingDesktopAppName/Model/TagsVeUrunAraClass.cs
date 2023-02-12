using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnInterestingWebSiteName.Models
{
    [Serializable]
    public class TagsVeUrunAraClass
    {
        public int ID { get; set; }

        public int Tag_ID { get; set; }

        public Tag Tag { get; set; }

        public int Urun_ID { get; set; }

        public Urunler Urunler { get; set; }
    }
}