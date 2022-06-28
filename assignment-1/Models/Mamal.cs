using assignment_1.Services;
using assignment_1.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public abstract class Mamal : Animal
    {
        //declaration of mammal fields
        private int _teethNum;
        private MamalTypes _mamalType;


        /// <summary>
        /// default constructor for mammal
        /// </summary>
        public Mamal()
        {

        }

        /// <summary>
        /// constructor for mammal
        /// </summary>
        /// <param name="teethNum"></param>
        public Mamal(int teethNum)
        {
            _teethNum = teethNum;
        }

        /// <summary>
        /// get and set methods to access the private fields
        /// </summary>
        public int TeethNum
        {
            get { return _teethNum; }
            set { _teethNum = value; }
        }

        /// <summary>
        /// get and set methods to access the private fields
        /// </summary>
        public MamalTypes MamalType
        {
            get { return _mamalType; }
            set { _mamalType = value; }
        }

        /// <summary>
        /// tostring method for mammal
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = base.ToString();
            outPut += String.Format("{0,-15} {1, 6}\n{2, -15} {3,6}\n",
                                           "Number of teeth: ", TeethNum, "mammalType: ", MamalType);
            return outPut;
        }



        //***********************************************************************

        public override abstract FoodSchedule GetFoodSchedule();


    }
}
