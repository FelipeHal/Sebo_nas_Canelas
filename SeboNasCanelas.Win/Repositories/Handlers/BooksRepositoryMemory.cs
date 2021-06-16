using SeboNasCanelas.Win.AppObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboNasCanelas.Win.Repositories.Handlers
{
    public class BooksRepositoryMemory : IBooksRepository
    {
        List<Book> _data = new List<Book>();


        public void Delete(Book book)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == book.ID));
        }

        public Book Find(int id)
        {
            return _data.FirstOrDefault(x => x.ID == id);
        }

        public void Insert(Book book)
        {
            book.ID = _data.Any() ? _data.Max(x => x.ID) + 1 : 1;
            _data.Add(book);
        }

        public List<Book> List()
        {
            return _data;
        }

        public void Update(Book book)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == book.ID));
            _data.Add(book);
        }
    }
}