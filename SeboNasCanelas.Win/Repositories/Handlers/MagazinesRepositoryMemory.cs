using SeboNasCanelas.Win.AppObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboNasCanelas.Win.Repositories.Handlers
{
    public class MagazinesRepositoryMemory : IMagazinesRepository
    {
        List<Magazine> _data = new List<Magazine>();

        public void Delete(Magazine magazine)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == magazine.ID));
        }

        public Magazine Find(int id)
        {
            return _data.FirstOrDefault(x => x.ID == id);
        }

        public void Insert(Magazine magazine)
        {
            magazine.ID = _data.Any() ? _data.Max(x => x.ID) + 1 : 1;
            _data.Add(magazine);
        }

        public List<Magazine> List()
        {
            return _data;
        }

        public void Update(Magazine magazine)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == magazine.ID));
            _data.Add(magazine);
        }
    }
}
