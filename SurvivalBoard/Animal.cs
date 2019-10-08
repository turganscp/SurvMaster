using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBoard
{
    public abstract class Animal
    {
        private static Random rand = new Random();
        public char Species  { get; set; }
        public char Gender { get; set; }
        public int Movement { get; set; }
  
        public double Weight { get; set; }
        public bool Alive { get; set; }
        public Tile Tile { get; set; } //eksistere kun på Tile, indbyrdes reference

        public Animal()
        {
            Species = 'A';
            Weight = 5;
        }
        public void Move(SurvivalController sc) //vælger target location. Animal kan se tiles omkring sig
        { 
            List<Tile> Tiles = new List<Tile>();
                int row = Tile.Row;
                int col = Tile.Column;
 
            for (int roffset = -1; roffset <= 1; roffset++) {
                    int nextRow = row + roffset;
                    if (nextRow >= 0 && nextRow < 20)
                    {
                        for (int coffset = -1; coffset <= 1; coffset++)
                        {
                            int nextCol = col + coffset;
                            // Exclude invalid locations and the original location.
                            if (nextCol >= 0 && nextCol < 20 && (roffset != 0 || coffset != 0))
                            {
                                Tiles.Add(new Tile(nextRow, nextCol));
                            }
                        }
                    }            
            }

            Tile availableTile;
            int count = 1;
            while (count <= Tiles.Count)
            {
                int randomTile = rand.Next(Tiles.Count);
                availableTile = Tiles[randomTile];
                if (availableTile.Animal == null) //grass
                {
                    Tile.RemoveAnimal(this);
                    sc.PlaceOneAnimal(this, availableTile.Row, availableTile.Column);
                    break;
                }
                count++;
            }
            Tiles.Clear();
        }    
    }
}
