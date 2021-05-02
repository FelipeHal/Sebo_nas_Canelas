using System;
using System.Collections.Generic;
using System.Text;

namespace Sebo_nas_Canelas_3.AppObjects
{
    public class Book : BaseProduct
    {
        public string Author { get; set; }

        public string Publisher { get; set; }

        public string Edition { get; set; }        

        public int Pagenumber { get; set; }

        public int Year { get; set; }
    }
}
