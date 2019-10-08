using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBoard
{
    public class Tile
    {
        private static Random Gen = new Random();
        public int Row { get; set; }
        public int Column { get; set; }
        public bool Grass { get; set; }
        public Animal Animal { get; set; }
        public Tile(int row, int col)
        {
            Row = row;
            Column = col;
            if (Gen.Next(0, 4) == 2)
            {
                Grass = true;
            }
        }

        public void AddAnimal(Animal animal)
        {
            Animal = animal;
            animal.Tile = this; //hvert animal kommer på sin specifikke tile
        }

        public void RemoveAnimal(Animal animal) //laver tile om til sin oprindelige form.
        {
            Animal = null; 
            animal.Tile = null;
        }
    }
}
