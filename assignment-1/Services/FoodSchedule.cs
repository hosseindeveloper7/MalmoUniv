using assignment_1.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Services
{
    public class FoodSchedule
    {
        //declaration of eater type and a list of strings
        private EaterType eaterType;
        private List<string> foodList;

        /// <summary>
        /// FoodSchedule constructor
        /// </summary>
        public FoodSchedule()
        {
            //create an instance list of strings
            foodList = new List<string>();
        }



        public int Count { get; set; }

        /// <summary>
        /// EaterType getter and setter
        /// </summary>
        public EaterType EaterType
        {
            get { return eaterType; }
            set { eaterType = value; }
        }

        /// <summary>
        /// method to add a string to the varable foodList
        /// </summary>
        /// <param name="item"></param>
        public void Add(string item)
        {
            foodList.Add(item);
        }

     
        public string[] GetFoodListInfoStrings()
        {
            string[] infoString = foodList.ToArray();
            return infoString;
        }
    }
}
