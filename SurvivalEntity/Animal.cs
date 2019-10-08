using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalEntity
{
    public abstract class Animal
    {

        protected string name;
        protected string gender; // subklasser kan få fat i denne attribut, dens børn
        protected string species; //tag for picture box
        protected int movement;
        protected int weight;

        public Animal(string name, string gender, string species, int movement, int weight)
        {
            this.gender = gender;
            this.species = species;
            this.movement = movement;
            this.weight = weight;
        }
        public abstract int GetAnimal();
        public abstract int eat();
        public abstract int getMove();


    }
}
