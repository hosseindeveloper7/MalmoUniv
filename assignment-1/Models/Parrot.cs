using assignment_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public class Parrot : Bird
    {
        //declaration of parrot fields
        private string _colorOfWings;

        /// <summary>
        /// default constructor for parrot
        /// </summary>
        public Parrot()
        {

        }

        /// <summary>
        /// constructor for parrot
        /// </summary>
        /// <param name="colorOfWings"></param>
        /// <param name="lengthofWing"></param>
        public Parrot(string colorOfWings, int lengthofWing) : base (lengthofWing)
        {
            _colorOfWings = colorOfWings;
        }

        /// <summary>
        /// default constructor for mammal
        /// </summary>
        /// <param name="lengthofWing"></param>
        public Parrot (int lengthofWing) : base(lengthofWing)
        {

        }

        /// <summary>
        /// get and set methods to access the private fields
        /// </summary>
        public string ColorOfWings
        {
            get { return _colorOfWings; }
            set { _colorOfWings = value; }
        }

        /// <summary>
        /// tostring method for parrot
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = base.ToString();
            outPut += String.Format("Color of wings :  {0} ", ColorOfWings);
            return outPut;
        }

        //************************************************

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = Types.EaterType.PlantEater;
            foodSchedule.Add("Morning: cheese and walnuts");
            foodSchedule.Add("Lunch: Wheat");
            foodSchedule.Add("Evening: Milk and Wheat");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            SetFoodSchedule();
            return foodSchedule;
        }
    }
}
