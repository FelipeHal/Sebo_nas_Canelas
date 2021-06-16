using SeboNasCanelas.Win.AppObjects;
using System.Collections.Generic;
using System.Linq;

namespace SeboNasCanelas.Win.Repositories
{
    public class MagazinesRepository
    {
        static List<Magazine> _data = new List<Magazine>();

        void LoadData()
        {
            if (!_data.Any(x => x.ID == 301))
            {
                _data.Add(new Magazine()
                {
                    ID = 301,
                    Title = "Super Interessante",
                    Publisher = "Abril",
                    Price = 10m
                });
            }

            if (!_data.Any(x => x.ID == 302))
            {
                _data.Add(new Magazine()
                {
                    ID = 302,
                    Title = "Homem-Aranha",
                    Publisher = "Panini",
                    Price = 30m
                });
            }

            if (!_data.Any(x => x.ID == 303))
            {
                _data.Add(new Magazine()
                {
                    ID = 303,
                    Title = "Scientific American Brasil",
                    Publisher = "Dueto",
                    Price = 15m
                });
            }
        }


        public List<Magazine> List()
        {
            LoadData();
            return _data;
        }

        public Magazine Find(int id)
        {
            LoadData();
            return _data.FirstOrDefault(x => x.ID == id);
        }

        public void Insert(Magazine magazine)
        {
            magazine.ID = _data.Any() ? _data.Max(x => x.ID) + 1 : 1;
            _data.Add(magazine);
        }

        public void Update(Magazine magazine)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == magazine.ID));
            _data.Add(magazine);
        }

        public void Delete(Magazine magazine)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == magazine.ID));
        }
    }
}
