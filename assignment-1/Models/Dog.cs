using assignment_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public class Dog : Mamal
    {
        //declaration for dogs fields
        private string _breed;


        /// <summary>
        /// constructor for dog
        /// </summary>
        /// <param name="breed"></param>
        /// <param name="teethNum"></param>
        public Dog(string breed, int teethNum) : base(teethNum)
        {
            _breed = breed;
        }


        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="teethNum"></param>
        public Dog(int teethNum) : base(teethNum)
        {

        }

        public Dog()
        {

        }


        /// <summary>
        /// get and set method to access the private fields
        /// </summary>
        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        /// <summary>
        /// tostring method for dog
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = base.ToString();
            outPut += String.Format("Breed : {0} ", Breed);
            return outPut;
        }

        //**************************************

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = Types.EaterType.AllEater;
            foodSchedule.Add("Morning: Dog Flakes and milk");
            foodSchedule.Add("Lunch: bones and meat");
            foodSchedule.Add("Evening: bones");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            SetFoodSchedule();
            return foodSchedule;
        }
    }
}
