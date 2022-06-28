using assignment_1.Services;
using assignment_1.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public abstract class Reptile : Animal
    {
        //declaration of Reptile fields
        private int _lifeLong;
        private ReptileTypes _reptileType;


        /// <summary>
        /// default constructor for Reptile
        /// </summary>
        public Reptile()
        {

        }

        /// <summary>
        /// constructor for Reptile
        /// </summary>
        /// <param name="lifeLong"></param>
        public Reptile(int lifeLong)
        {
            _lifeLong = lifeLong;
        }

        /// <summary>
        /// get and set methods to access the private fields
        /// </summary>
        public int LifeLong
        {
            get { return _lifeLong; }
            set { _lifeLong = value; }
        }

        /// <summary>
        /// get and set methods to access the private fields
        /// </summary>
        public ReptileTypes ReptileType
        {
            get { return _reptileType; }
            set { _reptileType = value; }
        }

        /// <summary>
        /// tostring method for Reptile
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = base.ToString();
            outPut += String.Format("{0,-15} {1, 6}\n{2, -15} {3,6}\n",
                                           "Life Long: ", LifeLong, "ReptileType: ", ReptileType);
            return outPut;
        }



        //***********************************************************************

        public override abstract FoodSchedule GetFoodSchedule();


    }
}
