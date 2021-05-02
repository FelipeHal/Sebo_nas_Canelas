using System;
using System.Collections.Generic;
using System.Text;

namespace SeboNasCanelas.Win.AppObjects
{
    public class Magazine : BaseProduct
    {        
        public string Publisher { get; set; }
        public string Edition { get; set; }

        public string Subject { get; set; }
        public int Pagenumber { get; set; }
        public int Year { get; set; }
    }
}
