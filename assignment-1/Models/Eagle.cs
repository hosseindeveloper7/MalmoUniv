using assignment_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public class Eagle : Bird
    {
        //declaration for eagle fields
        private int _heightFly;


        /// <summary>
        /// constructor for eagle
        /// </summary>
        /// <param name="heightFly"></param>
        /// <param name="lengthofWing"></param>
        public Eagle(int heightFly, int lengthofWing) : base (lengthofWing)
        {
            HeightFly = heightFly;
        }

        /// <summary>
        /// default constructor for eagle
        /// </summary>
        /// <param name="lengthofWing"></param>
        public Eagle(int lengthofWing) : base (lengthofWing)
        {

        }

        /// <summary>
        /// get and set method to access the private fields
        /// </summary>
        public int HeightFly
        {
            get { return _heightFly; }
            set { _heightFly = value; }
        }

        /// <summary>
        /// tostring method for eagle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = base.ToString();
            outPut += String.Format("Fly height :  {0} ", HeightFly);
            return outPut;
        }

        //***********************************

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = Types.EaterType.AllEater;
            foodSchedule.Add("Morning:  Eagle food");
            foodSchedule.Add("Lunch: meet");
            foodSchedule.Add("Evening: Eagelfood");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            SetFoodSchedule();
            return foodSchedule;
        }


    }
}
