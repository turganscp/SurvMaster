using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBoard
{
    class Game
    {
        SurvivalController sc = new SurvivalController();

        private int TurnCount { get; set; }
        public void GameLoop(SurvivalController sc)
        {
            TurnCount++;

            foreach (Tile T in sc.GetAllTiles())
            {
                if (T.Animal != null) //forskellig fra NULL værdi
                {
                    if (T.Animal.Species == 'R')
                    {
                        Rabbit rabbit = (Rabbit)T.Animal;
                        rabbit.Move(sc);
                    }
                    else if  (T.Animal.Species == 'L')
                    {
                        Rabbit rabbit = (Rabbit)T.Animal;
                        rabbit.Move(sc);
                    }


                }
            }
        }



    }
}
