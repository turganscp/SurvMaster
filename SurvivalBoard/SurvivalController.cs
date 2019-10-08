using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBoard
{
    public class SurvivalController
    {
        //Game Game = new Game();

        Tile[,] Tiles = new Tile[20, 20]; //Alle Tiles starter som null 'blanke' dvs ingen dyr på dem.
        public SurvivalController() //Constructor, starter når en klasse instantieres. 
        {
            CreateBoard(); //private method.
        }

        private void CreateBoard()
        {
            for (int i = 0; i < 20; i++) //hardcoded fordi boardet skulle være 20x20
            {
                for (int j = 0; j < 20; j++)
                {
                    Tiles[i, j] = new Tile(i, j);
                }
            }
        }

        public void PlaceAnimal(Animal animal, int Row, int Column) //Row og Collum kommer fra tile, som refereret i Animal)
        {
            Tiles[Row, Column].AddAnimal(animal);
        }

        public void OneGameTurn() 
        {
            GameLoop();
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
                    if (Tiles[i, j].Animal == null)
                    {
                        emptytiles.Add(Tiles[i, j]);
                    }
                }

            }
            return emptytiles;
        }

        public void PlaceOneAnimal(Animal animal, int row, int col)
        {
            PlaceAnimal(animal, row,col);
        }
        public Tile[,] GetAllTiles()
        {
            return GetTiles(); //referer tilbage til arrayet tidligere
        }

        public void GameLoop()
        {
            foreach (Tile T in GetAllTiles())
            {
                if (T.Animal != null) //forskellig fra NULL værdi
                {
                    if (T.Animal.Species == 'R')
                    {
                        Rabbit rabbit = (Rabbit)T.Animal;
                        rabbit.Move(this);
                    }
                    else if (T.Animal.Species == 'L')
                    {
                        Lion lion = (Lion)T.Animal;
                        lion.Move(this);
                    }


                }
            }
        }

    }
}
