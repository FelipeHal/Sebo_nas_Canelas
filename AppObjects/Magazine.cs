using System;
using System.Collections.Generic;
using System.Text;

namespace Sebo_nas_Canelas_3.AppObjects
{
    public class Magazine : BaseProduct
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Edition { get; set; }

        public string Subject { get; set; }
        public int Pagenumber { get; set; }
        public int Year { get; set; }
    }
}
