using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace AnInterestingWebSiteName.Models
{
    [Serializable]
    public class Firma
    {

        public int ID { get; set; }

        public string Ad { get; set; }

        public string FirmaHakkinda { get; set; }

        public string FirmaResmi { get; set; }

        public string FirmaArkaPlanResmi { get; set; }

        public string Mail { get; set; }

        public bool Aktifmi { get; set; }

    }
}