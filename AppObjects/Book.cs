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
        
        public static List<Book> GetBooks() 
        {
            List<Book> livros = new List<Book>();
            livros.Add(new Book()
            {
                ID = 101,
                Title = "O Olho do Mundo: (Série A roda do tempo vol. 1)",
                Author = "Robert Jordan",
                Publisher = "Intrínseca",
                Price = 36


            });
            livros.Add(new Book()
            {
                ID = 102,
                Title = "Go Rin No Sho",
                Author = "Miyamoto Musashi, Jorge Kishikawa",
                Publisher = "Kendoonline Livros",
                Price = 25
            });
            livros.Add(new Book()
            {
                ID = 103,
                Title = "Mistborn",
                Author = "Brandon Sanderson",
                Publisher = "Tor Fantasy",
                Price = 41
            });
            livros.Add(new Book()
            {
                ID = 104,
                Title = "A Espada dos Reis",
                Author = "Bernard Cornwell",
                Publisher = "Editora Record",
                Price = 44
            });
            livros.Add(new Book()
            {
                ID = 105,
                Title = "O Poder do Hábito",
                Author = "Charles Duhigg",
                Publisher = "Objetiva",
                Price = 37
            });
            return livros;
        }
         
        


    }
}
