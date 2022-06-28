using assignment_1.Services;
using assignment_1.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public abstract class Bird : Animal
    {
        //Declaration of the fields of bird
        private int _lengthofWing;
        private BirdTypes _birdType;
        

        /// <summary>
        /// constructor for bird
        /// </summary>
        /// <param name="lengthofWing"></param>
        public Bird(int lengthofWing)
        {
            LengthofWing = lengthofWing;
        }

        /// <summary>
        /// default constructor for bird
        /// </summary>
        public Bird()
        {

        }

        /// <summary>
        /// get and set method to access the private fields
        /// </summary>
        public int LengthofWing
        {
            get { return _lengthofWing; }
            set { _lengthofWing = value; }
        }

        /// <summary>
        /// get and set method to access the private fields
        /// </summary>
        public BirdTypes BirdType
        {
            get { return _birdType; }
            set { _birdType = value; }
        }

        /// <summary>
        /// tostring method for the object bird
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = base.ToString();
            outPut += String.Format("{0,-15} {1, 6}\n{2, -15} {3,6}\n",
                                    "Length of Wings: ", LengthofWing, "mammalType: ", BirdType);
            return outPut;
        }

        //*********************************************************

        public override abstract FoodSchedule GetFoodSchedule();
    }



}
