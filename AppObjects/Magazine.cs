using System;
using System.Collections.Generic;
using System.Text;

namespace Sebo_nas_Canelas_3.AppObjects
{
    public class Magazine : BaseProduct
    {        
        public string Publisher { get; set; }
        public string Edition { get; set; }

        public string Subject { get; set; }
        public int Pagenumber { get; set; }
        public int Year { get; set; }

        public static List<Magazine> GetMagazines()
        {
            List<Magazine> revistas = new List<Magazine>();
            revistas.Add(new Magazine()
            {
                ID = 301,
                Title = "Super Interessante",
                Publisher = "Abril",
                Price = 10
            });
            revistas.Add(new Magazine()
            {
                ID = 302,
                Title = "Homem-Aranha",
                Publisher = "Panini",
                Price = 30
            });

            return revistas;
        }
        
                        
    }
}
