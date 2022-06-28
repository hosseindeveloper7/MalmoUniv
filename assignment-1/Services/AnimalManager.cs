using assignment_1.Models;
using assignment_1.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Services
{
    public class AnimalManager
    {

        public List<Animal> animalList;


        /// <summary>
        /// default constructor for animalmanager
        /// </summary>
        public AnimalManager()
        {
            animalList = new List<Animal>();
        }

        /// <summary>
        /// method to create a mammal object
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="teethNum"></param>
        /// <returns></returns>
        public Mamal CreateMammalType(MamalTypes kind, int teethNum)
        {
            Mamal mammal = null;

            switch (kind)
            {
                case MamalTypes.Cat:
                    mammal = new Cat(teethNum);
                    mammal.MamalType = MamalTypes.Cat;
                    //mammal.
                    break;

                case MamalTypes.Dog:
                    mammal = new Dog(teethNum);
                    mammal.MamalType = MamalTypes.Dog;
                    break;

                case MamalTypes.Sheep:
                    mammal = new Sheep(teethNum);
                    mammal.MamalType = MamalTypes.Sheep;
                    break;
            }
            return mammal;
        }



        /// <summary>
        /// method to create a Reptile object
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="lifeLong"></param>
        /// <returns></returns>
        public Reptile CreateReptileType(ReptileTypes kind, int lifeLong)
        {
            Reptile reptile = null;

            switch (kind)
            {
                case ReptileTypes.Snake:
                    reptile = new Snake(lifeLong);
                    reptile.ReptileType = ReptileTypes.Snake;
                    break;

                case ReptileTypes.Turtle:
                    reptile = new Turtle(lifeLong);
                    reptile.ReptileType = ReptileTypes.Turtle;
                    break;
            }
            return reptile;
        }



        /// <summary>
        /// method to create a bird object
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="lengthofWing"></param>
        /// <returns></returns>
        public Bird CreateBirdType(BirdTypes kind, int lengthofWing)
        {
            Bird bird = null;

            switch (kind)
            {
                case BirdTypes.Eagle:
                    bird = new Eagle(lengthofWing);
                    bird.BirdType = BirdTypes.Eagle;
                    break;

                case BirdTypes.Parrot:
                    bird = new Parrot(lengthofWing);
                    bird.BirdType = BirdTypes.Parrot;
                    break;
            }
            return bird;
        }


        /// <summary>
        /// method to add an animal object to the list animalList
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public bool AddAnimal(Animal animal)
        {
            if(animal != null)
            {
                animalList.Add(animal);
                return true;
            }
            else
            {
                return false;
            }           
        }

        public Animal GetAnimalAt(int index)
        {
            return animalList[index];
        }



    }
}
