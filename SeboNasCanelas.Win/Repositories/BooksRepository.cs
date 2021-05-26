using SeboNasCanelas.Win.AppObjects;
using System.Collections.Generic;
using System.Linq;

namespace SeboNasCanelas.Win.Repositories
{
    public class BooksRepository
    {
        static List<Book> _data = new List<Book>();

        void LoadData()
        {
            if (!_data.Any(x => x.ID == 101))
            {
                _data.Add(new Book()
                {
                    ID = 101,
                    Title = "O Olho do Mundo: (A roda do tempo # 1)",
                    Category = "Fantasia",
                    Author = "Robert Jordan",
                    Publisher = "Intrínseca",
                    Price = 36m
                }) ;
            }

            if (!_data.Any(x => x.ID == 102))
            {
                _data.Add(new Book()
                {
                    ID = 102,
                    Title = "Go Rin No Sho",
                    Category = "Estratégia",
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
                    Category = "Fantasia",
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
                    Category = "Ficção Histórica",
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
                    Category = "Auto-ajuda",
                    Author = "Charles Duhigg",
                    Publisher = "Objetiva",
                    Price = 37m
                });
            }
        }


        public List<Book> List()
        {
            LoadData();
            return _data;
        }

        public Book Find(int id)
        {
            LoadData();
            return _data.FirstOrDefault(x => x.ID == id);
        }

        public void Insert(Book book)
        {
            _data.Add(book);
                       
        }

        public void Update(Book book)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == book.ID));
            _data.Add(book);
        }

        public void Delete(Book book)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == book.ID));
        }
    }
}
