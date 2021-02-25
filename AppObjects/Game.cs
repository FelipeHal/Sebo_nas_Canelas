using System;
using System.Collections.Generic;

namespace Sebo_nas_Canelas_3.AppObjects
{
    public class Game : BaseProduct
    {
        public string Developer { get; set; }

        public string Console { get; set; }
        
        public string AgeRating { get; set; }


        public static List<Game> GetGames() {
            List<Game> jogos = new List<Game>();

            jogos.Add(new Game()
            {
                ID = 201,
                Title = "Assassin's Creed Valhalla",
                Console = "XBOX",
                AgeRating = "+18",
                Price = 120
            });

            jogos.Add(new Game()
            {
                ID = 202,
                Title = "God of War",
                Console = "PS4",
                AgeRating = "+18",
                Price = 70
            });

            jogos.Add(new Game()
            {
                ID = 203,
                Title = "Super Mario World 3",
                Console = "SNES",
                AgeRating = "+12",
                Price = 150
            });

            return jogos;
        }
    }
}