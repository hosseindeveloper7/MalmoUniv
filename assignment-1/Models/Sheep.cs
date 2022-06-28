using assignment_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public class Sheep : Mamal
    {
        //declaration of fields
        private string _land;

        /// <summary>
        /// constructor for the object cat
        /// </summary>
        /// <param name="land"></param>
        /// <param name="teethNum"></param>
        public Sheep(string land, int teethNum) : base(teethNum)
        {
            _land = land;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="teethNum"></param>
        public Sheep(int teethNum) : base(teethNum)
        {

        }

        public Sheep()
        {

        }

        /// <summary>
        /// get and set method to access private fields
        /// </summary>
        public string Land
        {
            get { return _land; }
            set { _land = value; }
        }

        /// <summary>
        /// tostring method for cat
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = base.ToString();
            outPut += String.Format("Which Land :  {0} ", Land);
            return outPut;
        }

        //************************************

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = Types.EaterType.PlantEater;
            foodSchedule.Add("Morning: Hay and bread");
            foodSchedule.Add("Lunch: Hay");
            foodSchedule.Add("Evening: Vegetables");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            SetFoodSchedule();
            return foodSchedule;
        }
    }
}
