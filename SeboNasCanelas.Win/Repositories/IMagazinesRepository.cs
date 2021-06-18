using SeboNasCanelas.Win.AppObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboNasCanelas.Win.Repositories
{
    public interface IMagazinesRepository
    {
        public List<Magazine> List();

        public Magazine Find(int id);

        public void Insert(Magazine magazine);

        public void Update(Magazine magazine);

        public void Delete(Magazine magazine);
    }
}
