using SeboNasCanelas.Win.AppObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboNasCanelas.Win.Repositories
{
    public interface IGamesRepository
    {
        public List<Game> List();

        public Game Find(int id);

        public void Insert(Game game);

        public void Update(Game game);

        public void Delete(Game game);
    }
}
