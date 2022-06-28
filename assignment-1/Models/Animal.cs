using assignment_1.Interfaces;
using assignment_1.Services;
using assignment_1.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Models
{
    public abstract class Animal : IAnimal
    {
        //Declaration of fields for Animal
        //_ means the field is private
        private string _name;
        private double _age;
        private GenderTypes _gender;
        private AnimalTypes _category;
        private string _id;

        /// <summary>
        /// Constructor for the object animal
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="category"></param>
        public Animal(string name, double age, GenderTypes gender, AnimalTypes category)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _category = category;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Animal() 
        {
           
        }

        /// <summary>
        /// get and set method to access the animals fields
        /// </summary>
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// get and set method to access the animals fields
        /// </summary>
        public string Name
        {
            get { return _name;  }
            set { _name = value; }
        }

        /// <summary>
        /// get and set method to access the animals fields
        /// </summary>
        public double Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// get and set method to access the animals fields
        /// </summary>
        public GenderTypes Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        /// <summary>
        /// get and set method to access the animals fields
        /// </summary>
        public AnimalTypes Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// ToString method for the object animal
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outPut = string.Format("{0,-15} {1, 8}\n{2, -15} {3,8} \n{4, -15} {5, 8}\n",
                                           "Id: ", Id, "Name: ", Name, "Age: ", Age);

            outPut += String.Format("{0,-15} {1, 8}\n{2, -15} {3,8}\n",
                                           "Gender: ", Gender, "Category: ", Category);

            return outPut;
        }

        //****************************************************************************************

        public abstract FoodSchedule GetFoodSchedule();

        public virtual string GetExtraInfo()
        {
            string strOut = string.Empty;
            strOut = string.Format("{0,-15} {1, 10}\n", "Category:", Category.ToString());

            return strOut;
        }



    }
}
