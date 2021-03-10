using Sebo_nas_Canelas_3.AppObjects;
using System.Collections.Generic;
using System.Linq;

namespace Sebo_nas_Canelas_3.Repositories
{
    public static class MagazinesRepository
    {
        static List<Magazine> _data = new List<Magazine>();

        static void LoadData()
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


        public static List<Magazine> List()
        {
            LoadData();
            return _data;
        }

        public static Magazine Find(int id)
        {
            return _data.FirstOrDefault(x => x.ID == id);
        }

        public static void Insert(Magazine magazine)
        {
            LoadData();
            _data.Add(magazine);
        }

        public static void Update(Magazine magazine)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == magazine.ID));
            _data.Add(magazine);
        }

        public static void Delete(Magazine magazine)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == magazine.ID));
        }
    }
}
