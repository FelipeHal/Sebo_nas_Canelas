using SeboNasCanelas.Win.AppObjects;
using System.Collections.Generic;
using System.Linq;

namespace SeboNasCanelas.Win.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly SeboNasCanelasContext context;

        public BooksRepository(SeboNasCanelasContext context)
        {
            this.context = context;
        }


        public List<Book> List()
        {
            //LoadData();
            return context.Books.ToList();
        }

        public Book Find(int id)
        {
            //LoadData();
            //return _data.FirstOrDefault(x => x.ID == id);
            return context.Books.Find(id);
        }

        public void Insert(Book book)
        {
            //book.ID = _data.Any() ? _data.Max(x => x.ID) + 1 : 1;
            //_data.Add(book);
            context.Books.Add(book);
            context.SaveChanges();       
        }

        public void Update(Book book)
        {
            //_data.Remove(_data.FirstOrDefault(x => x.ID == book.ID));
            //_data.Add(book);
            context.Books.Update(book);
            context.SaveChanges();
        }

        public void Delete(Book book)
        {
            //_data.Remove(_data.FirstOrDefault(x => x.ID == book.ID));
            context.Books.Remove(book);
            context.SaveChanges();
        }
    }
}
