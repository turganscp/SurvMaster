using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBoard
{
    public class Rabbit: Animal
    {        //fordi animal kender tile, så kender rabbit tile
        public Rabbit()
        {
            Species = 'R';
            Weight = 10;
        }
    }
}
