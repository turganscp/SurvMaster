using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBoard
{

    /// <summary>
    /// Denne klasse er ikke til noget længere, funktioner er lagt ind i SurvivalController. 
    /// </summary>
    public class Board //Board giver Tile sine koordinater
    {
        Tile[,] Tiles = new Tile[20,20]; //Alle Tiles starter null 'blanke'  dvs ingen dyr på dem.
        public Board() //Constructor, starter når en klasse instantieres. 
        {
            for (int i = 0; i < 20; i++) //hardcoded fordi boardet skulle være 20x20
            {
                for (int j = 0; j < 20; j++)
                {
                    Tiles[i, j] = new Tile(i, j);
                }
            }
        }

        public void PlaceAnimal(Animal animal, int Row, int Collum) //Row og Collum kommer fra tile, som er inde i animal)
        {
            Tiles[Row, Collum].AddAnimal(animal);
        }

        public Tile[,] GetTiles()
        {
            return Tiles; //referer tilbage til arrayet tidligere
        }

        public List<Tile> Emptytiles()
        {
            List<Tile> emptytiles = new List<Tile>();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (Tiles[i,j].Animal == null)
                    {
                        emptytiles.Add(Tiles[i,j]);
                    }
                }

            }
            return emptytiles;
        }
    }
}
