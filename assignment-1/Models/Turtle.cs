using assignment_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public class Turtle : Reptile
    {
        //declaration for Turtle fields
        private string _color;


        /// <summary>
        /// constructor for dog
        /// </summary>
        /// <param name="color"></param>
        /// <param name="lifeLong"></param>
        public Turtle(string color, int lifeLong) : base(lifeLong)
        {
            _color = color;
        }


        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="lifeLong"></param>
        public Turtle(int lifeLong) : base(lifeLong)
        {

        }

        public Turtle()
        {

        }


        /// <summary>
        /// get and set method to access the private fields
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// tostring method for Turtle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = base.ToString();
            outPut += String.Format("Color : {0} ", Color);
            return outPut;
        }

        //**************************************

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = Types.EaterType.PlantEater;
            foodSchedule.Add("Morning: Vegetables");
            foodSchedule.Add("Lunch: Bread");
            foodSchedule.Add("Evening: Turtles food");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            SetFoodSchedule();
            return foodSchedule;
        }
    }
}
