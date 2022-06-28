using assignment_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public class Snake : Reptile
    {
        //declaration for snakes fields
        private int _length;


        /// <summary>
        /// constructor for Snake
        /// </summary>
        /// <param name="length"></param>
        /// <param name="lifeLong"></param>
        public Snake(int length, int lifeLong) : base(lifeLong)
        {
            _length = length;
        }


        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="lifeLong"></param>
        public Snake(int lifeLong) : base(lifeLong)
        {

        }

        public Snake()
        {

        }


        /// <summary>
        /// get and set method to access the private fields
        /// </summary>
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// <summary>
        /// tostring method for Snake
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = base.ToString();
            outPut += String.Format("Length : {0} ", Length);
            return outPut;
        }

        //**************************************

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = Types.EaterType.AllEater;
            foodSchedule.Add("Morning: meat for snakes");
            foodSchedule.Add("Lunch: snakes food");
            foodSchedule.Add("Evening: snakes food");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            SetFoodSchedule();
            return foodSchedule;
        }
    }
}
