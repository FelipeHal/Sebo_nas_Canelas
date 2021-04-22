using Sebo_nas_Canelas_3.AppObjects;
using System.Collections.Generic;
using System.Linq;

namespace Sebo_nas_Canelas_3.Repositories
{
    public static class BooksRepository
    {
        static List<Book> _data = new List<Book>();

        static void LoadData()
        {
            if (!_data.Any(x => x.ID == 101))
            {
                _data.Add(new Book()
                {
                    ID = 101,
                    Title = "O Olho do Mundo: (A roda do tempo # 1)",
                    Author = "Robert Jordan",
                    Publisher = "Intrínseca",
                    Price = 36m
                });
            }

            if (!_data.Any(x => x.ID == 102))
            {
                _data.Add(new Book()
                {
                    ID = 102,
                    Title = "Go Rin No Sho",
                    Author = "Miyamoto Musashi, Jorge Kishikawa",
                    Publisher = "Kendoonline Livros",
                    Price = 25m
                });
            }

            if (!_data.Any(x => x.ID == 103))
            {
                _data.Add(new Book()
                {
                    ID = 103,
                    Title = "Mistborn",
                    Author = "Brandon Sanderson",
                    Publisher = "Tor Fantasy",
                    Price = 41m
                });
            }
            if (!_data.Any(x => x.ID == 104))
            {
                _data.Add(new Book()
                {
                    ID = 104,
                    Title = "A Espada dos Reis",
                    Author = "Bernard Cornwell",
                    Publisher = "Record",
                    Price = 44m
                });
            }
            if (!_data.Any(x => x.ID == 105))
            {
                _data.Add(new Book()
                {
                    ID = 105,
                    Title = "O Poder do Hábito",
                    Author = "Charles Duhigg",
                    Publisher = "Objetiva",
                    Price = 37m
                });
            }
        }


        public static List<Book> List()
        {
            LoadData();
            return _data;
        }

        public static Book Find(int id)
        {
            LoadData();
            return _data.FirstOrDefault(x => x.ID == id);
        }

        public static void Insert(Book book)
        {
            _data.Add(book);
                       
        }

        public static void Update(Book book)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == book.ID));
            _data.Add(book);
        }

        public static void Delete(Book book)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == book.ID));
        }
    }
}
