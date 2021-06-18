using SeboNasCanelas.Win.AppObjects;
using System.Collections.Generic;
using System.Linq;

namespace SeboNasCanelas.Win.Repositories
{
    public class GamesRepository : IGamesRepository
    {
        private readonly SeboNasCanelasContext context;

        public GamesRepository(SeboNasCanelasContext context)
        {
            this.context = context;
        }

        //void LoadData()
        //{
        //    if (!_data.Any(x => x.ID == 201))
        //    {
        //        _data.Add(new Game()
        //        {
        //            ID = 201,
        //            Title = "Assassin's Creed Valhalla",
        //            Console = "XBOX",
        //            AgeRating = "+18",
        //            Price = 112.00m
        //        });
        //    }

        //    if (!_data.Any(x => x.ID == 202))
        //    {
        //        _data.Add(new Game()
        //        {
        //            ID = 202,
        //            Title = "God of War",
        //            Console = "PS4",
        //            AgeRating = "+18",
        //            Price = 70.51m
        //        });
        //    }

        //    if (!_data.Any(x => x.ID == 203))
        //    {
        //        _data.Add(new Game()
        //        {
        //            ID = 203,
        //            Title = "Super Mario World 3",
        //            Console = "SNES",
        //            AgeRating = "+12",
        //            Price = 15.00m
        //        });
        //    }
        //}


        public List<Game> List()
        {
            //LoadData();
            return context.Games.ToList();
        }
        
        public Game Find(int id)
        {
            //LoadData();
            //return _data.FirstOrDefault(x => x.ID == id);
            return context.Games.Find();
        }
        public void Insert(Game game)
        {
            //game.ID = _data.Any() ? _data.Max(x => x.ID) + 1 : 1;
            //_data.Add(game);
            context.Games.Add(game);
            context.SaveChanges();
        }

        public void Update(Game game)
        {
            //_data.Remove(_data.FirstOrDefault(x => x.ID == game.ID));
            //_data.Add(game);
            context.Games.Update(game);
            context.SaveChanges();
        }

        public void Delete(Game game)
        {
            //_data.Remove(_data.FirstOrDefault(x => x.ID == game.ID));
            context.Games.Remove(game);
            context.SaveChanges();
        }
    }
}