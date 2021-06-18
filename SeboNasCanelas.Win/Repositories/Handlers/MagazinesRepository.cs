using SeboNasCanelas.Win.AppObjects;
using System.Collections.Generic;
using System.Linq;

namespace SeboNasCanelas.Win.Repositories
{
    public class MagazinesRepository : IMagazinesRepository
    {
        private readonly SeboNasCanelasContext context;

        public MagazinesRepository(SeboNasCanelasContext context)
        {
            this.context = context;
        }

        //void LoadData()
        //{
        //    if (!_data.Any(x => x.ID == 301))
        //    {
        //        _data.Add(new Magazine()
        //        {
        //            ID = 301,
        //            Title = "Super Interessante",
        //            Publisher = "Abril",
        //            Price = 10m
        //        });
        //    }

        //    if (!_data.Any(x => x.ID == 302))
        //    {
        //        _data.Add(new Magazine()
        //        {
        //            ID = 302,
        //            Title = "Homem-Aranha",
        //            Publisher = "Panini",
        //            Price = 30m
        //        });
        //    }

        //    if (!_data.Any(x => x.ID == 303))
        //    {
        //        _data.Add(new Magazine()
        //        {
        //            ID = 303,
        //            Title = "Scientific American Brasil",
        //            Publisher = "Dueto",
        //            Price = 15m
        //        });
        //    }
        //}


        public List<Magazine> List()
        {
            return context.Magazines.ToList();


        }

        public Magazine Find(int id)
        {
            return context.Magazines.Find(id);
        }

        public void Insert(Magazine magazine)
        {
            context.Magazines.Add(magazine);
            context.SaveChanges();
        }

        public void Update(Magazine magazine)
        {
            context.Magazines.Update(magazine);
            context.SaveChanges();
        }

        public void Delete(Magazine magazine)
        {
            context.Magazines.Remove(magazine);
            context.SaveChanges();
        }
    }
}
