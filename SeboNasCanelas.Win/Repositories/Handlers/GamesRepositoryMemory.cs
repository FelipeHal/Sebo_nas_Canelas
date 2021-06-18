using SeboNasCanelas.Win.AppObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboNasCanelas.Win.Repositories.Handlers
{
    public class GamesRepositoryMemory : IGamesRepository
    {
        List<Game> _data = new List<Game>();

        public void Delete(Game game)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == game.ID));
        }

        public Game Find(int id)
        {
            return _data.FirstOrDefault(x => x.ID == id);
        }

        public void Insert(Game game)
        {
            game.ID = _data.Any() ? _data.Max(x => x.ID) + 1 : 1;
            _data.Add(game);
        }

        public List<Game> List()
        {
            return _data;
        }

        public void Update(Game game)
        {
            _data.Remove(_data.FirstOrDefault(x => x.ID == game.ID));
            _data.Add(game);
        }
    }
}
