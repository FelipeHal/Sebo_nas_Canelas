using Sebo_nas_Canelas_3.AppObjects;
using System.Collections.Generic;
using System.Linq;

namespace Sebo_nas_Canelas_3.Repositories
{
    public static class GamesRepository
    {
        static List<Game> _data = new List<Game>();

        static void LoadData()
        {
            if (!_data.Any(x => x.ID == 201))
            {
                _data.Add(new Game()
                {
                    ID = 201,
                    Title = "Assassin's Creed Valhalla",
                    Console = "XBOX",
                    AgeRating = "+18",
                    Price = 1120m
                });
            }

            if (!_data.Any(x => x.ID == 202))
            {
                _data.Add(new Game()
                {
                    ID = 202,
                    Title = "God of War",
                    Console = "PS4",
                    AgeRating = "+18",
                    Price = 70.51m
                });
            }

            if (!_data.Any(x => x.ID == 203))
            {
                _data.Add(new Game()
                {
                    ID = 203,
                    Title = "Super Mario World 3",
                    Console = "SNES",
                    AgeRating = "+12",
                    Price = 150m
                });
            }
        }


        public static List<Game> List()
        {
            LoadData();
            return _data;
        }
        
        public static Game Find(int id)
        {
            LoadData();
            return _data.FirstOrDefault(x => x.ID == id);
        }
        public static void Insert(Game game)
        {
            _data.Add(game);
        }

        public static void Update(Game game)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == game.ID));
            _data.Add(game);
        }

        public static void Delete(Game game)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == game.ID));
        }
    }
}