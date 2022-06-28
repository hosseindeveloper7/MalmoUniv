using assignment_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public class Cat : Mamal
    {
        //declaration of fields
        private string _eyeColor;

        /// <summary>
        /// constructor for the object cat
        /// </summary>
        /// <param name="eyeColor"></param>
        /// <param name="teethNum"></param>
        public Cat(string eyeColor, int teethNum) : base (teethNum)
        {
            _eyeColor = eyeColor;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="teethNum"></param>
        public Cat(int teethNum) : base (teethNum)
        {

        }

        public Cat()
        {

        }

        /// <summary>
        /// get and set method to access private fields
        /// </summary>
        public string EyeColor
        {
            get { return _eyeColor; }
            set { _eyeColor = value; }
        }

        /// <summary>
        /// tostring method for cat
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = base.ToString();
            outPut += String.Format("Color of eyes :  {0} ", EyeColor);
            return outPut;
        }

        //************************************

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = Types.EaterType.AllEater;
            foodSchedule.Add("Morning: Cat Flakes and milk");
            foodSchedule.Add("Lunch: soft meat");
            foodSchedule.Add("Evening: meat");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            SetFoodSchedule();
            return foodSchedule;
        }
    }
}
