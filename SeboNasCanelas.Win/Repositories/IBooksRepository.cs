using SeboNasCanelas.Win.AppObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboNasCanelas.Win.Repositories
{
    public interface IBooksRepository
    {
        public List<Book> List();

        public Book Find(int id);

        public void Insert(Book book);

        public void Update(Book book);

        public void Delete(Book book);
    }
}