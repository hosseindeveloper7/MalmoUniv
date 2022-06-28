using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignment_1.Models;
using assignment_1.Services;
using assignment_1.Types;

namespace assignment_1
{
    public partial class Form1 : Form
    {
        //create an instance of AnimalManager class
        private AnimalManager manager = new AnimalManager();
        //declaration in initialization of a boolian variable to control of inputs
        public bool okGeneral = false;

        
        public Form1()
        {
            InitializeComponent();
            InitializeGUI(); 
            
        }

        /// <summary>
        /// method to initialize the list boxes
        /// </summary>
        public void InitializeGUI()
        {
            cmbGender.Items.AddRange(Enum.GetNames(typeof(Types.GenderTypes)));
            lbxCategori.Items.AddRange(Enum.GetNames(typeof(Types.AnimalTypes)));
        }

        /// <summary>
        /// method to read the animal category, mammal or bird
        /// boolian ok is to determine if animal category is taken or not
        /// </summary>
        /// <param name="ok"></param>
        /// <returns></returns>
        private AnimalTypes ReadAnimalType(out bool ok)
        {
            AnimalTypes animalType;
            ok = false;

            if (lbxCategori.SelectedIndex >= 0)
            {
                animalType = (AnimalTypes)lbxCategori.SelectedIndex;
                ok = true;
            }
            else
            {
                MessageBox.Show("Please select an animal type");
                animalType = AnimalTypes.Bird;
                
            }
            return animalType;
        }

        /// <summary>
        /// method to read mammal species
        /// </summary>
        /// <param name="ok"></param>
        /// <returns></returns>
        private MamalTypes ReadMammalType(out bool ok)
        {
            MamalTypes mamalType;
            ok = false;

            if (lbxAnimal.SelectedIndex >= 0)
            {
                mamalType = (MamalTypes)lbxAnimal.SelectedIndex;
                ok = true;
            }
            else
            {
                MessageBox.Show("Please select an mammal type");
                mamalType = MamalTypes.Cat;
                ok = false;
            }
            return mamalType;
        }


        /// <summary>
        /// method to read Reptile species
        /// </summary>
        /// <param name="ok"></param>
        /// <returns></returns>
        private ReptileTypes ReadReptileType(out bool ok)
        {
            ReptileTypes reptileType;
            ok = false;

            if (lbxAnimal.SelectedIndex >= 0)
            {
                reptileType = (ReptileTypes)lbxAnimal.SelectedIndex;
                ok = true;
            }
            else
            {
                MessageBox.Show("Please select an mammal type");
                reptileType = ReptileTypes.Snake;
                ok = false;
            }
            return reptileType;
        }



        /// <summary>
        /// method to read bird species
        /// </summary>
        /// <param name="ok"></param>
        /// <returns></returns>
        private BirdTypes ReadBirdType(out bool ok)
        {
            BirdTypes birdType;
            ok = false;

            if (lbxAnimal.SelectedIndex >= 0)
            {
                birdType = (BirdTypes)lbxAnimal.SelectedIndex;
                ok = true;
            }
            else
            {
                MessageBox.Show("Please select a Bird type");
                birdType = BirdTypes.Eagle;
                ok = false;
            }
            return birdType;
        }



        /// <summary>
        /// to create a mammal: cat or dog
        /// </summary>
        /// <param name="ok"></param>
        /// <returns></returns>
        private Animal CreateAnimalMammal(out bool ok)
        {
            //create an animal object 
            Animal animal = null;           
            int teethNum;           
            ok = false; //to control if mammal specie is taken or not

            //to create a mammal species user should give number of teeth
            if (!int.TryParse(tbNoTeeth.Text, out teethNum) || string.IsNullOrEmpty(tbNoTeeth.Text))
            {
                MessageBox.Show("Please give a number for number of teeth.");
            }
            else
            {
                
                MamalTypes mammalType = ReadMammalType(out ok);

                if (ok)
                {
                    animal = manager.CreateMammalType(mammalType, teethNum);                           
                    animal.Category = AnimalTypes.Mamal;

                    if (mammalType == MamalTypes.Cat)
                    {
                        //to give unique field like eye color to animal
                        ((Cat)animal).EyeColor = tbEyeColor.Text;
                    }
                    else if (mammalType == MamalTypes.Dog)
                    {
                        ((Dog)animal).Breed = tbBreed.Text;
                    }
                    else if (mammalType == MamalTypes.Sheep)
                    {
                        ((Sheep)animal).Land = tbLand.Text;
                    }

                }
                ok = true;
            }          
            return animal;
        }



        /// <summary>
        /// to create a mammal: cat or dog
        /// </summary>
        /// <param name="ok"></param>
        /// <returns></returns>
        private Animal CreateAnimalReptile(out bool ok)
        {
            //create an animal object 
            Animal animal = null;
            int lifeLong;
            ok = false; //to control if reptile specie is taken or not

            //to create a mammal species user should give number of teeth
            if (!int.TryParse(tbLifeLong.Text, out lifeLong) || string.IsNullOrEmpty(tbLifeLong.Text))
            {
                MessageBox.Show("Please give a number for life long.");
            }
            else
            {

                ReptileTypes reptileType = ReadReptileType(out ok);

                if (ok)
                {
                    animal = manager.CreateReptileType(reptileType, lifeLong);
                    animal.Category = AnimalTypes.Reptile;

                    if (reptileType == ReptileTypes.Snake)
                    {
                        if (!string.IsNullOrEmpty(tbxLength.Text) && int.TryParse(tbxLength.Text, out int len))
                        {
                            //to give unique field like lengtn to animal
                            ((Snake)animal).Length = len;
                            ok = true;
                        }
                        else
                        {
                            MessageBox.Show("Please give a number for length");
                            ok = false;
                        } 
                    }
                    else if (reptileType == ReptileTypes.Turtle)
                    {
                        ((Turtle)animal).Color = tbColorTurtle.Text;
                    }

                }
                ok = true;
            }
            return animal;
        }



        /// <summary>
        /// to create a bird: eagle or parrot
        /// </summary>
        /// <param name="ok"></param>
        /// <returns></returns>
        private Animal CreateAnimalBird(out bool ok)
        {
            Animal animal = null;
            int lengthofWing = 0;
            
            ok = false;


            if (!int.TryParse(tbWingLength.Text, out lengthofWing))
            {
                MessageBox.Show("Please write length of the wings.");
            }
            else
            {
                BirdTypes birdType = ReadBirdType(out ok);

                if (ok)
                {
                    animal = manager.CreateBirdType(birdType, lengthofWing);
                    animal.Category = AnimalTypes.Bird;

                    if (birdType == BirdTypes.Eagle)
                    {
                        if (!string.IsNullOrEmpty(tbHeightofFly.Text) && int.TryParse(tbHeightofFly.Text, out int h))
                        {
                            ((Eagle)animal).HeightFly = h;
                            ok = true;
                        }
                        else
                        {
                            MessageBox.Show("Please give a number for height of flight");
                            ok = false;
                        }
                        
                    }
                    else if (birdType == BirdTypes.Parrot)
                    {
                        ((Parrot)animal).ColorOfWings = tbColorofWings.Text;
                        ok = true;
                    }
                }
                
            }

            
            
            return animal;
        }



        /// <summary>
        /// to create an animal with general information like name and age
        /// </summary>
        /// <param name="ok"></param>
        /// <returns></returns>
        private Animal ReadAnimal(out bool ok)
        {
            ok = false;
            AnimalTypes animalType = ReadAnimalType(out ok);
            Animal animal = null;
            

            if (ok)
            {
                switch (animalType)
                {
                    case AnimalTypes.Mamal:
                        animal = CreateAnimalMammal(out ok);
                        break;

                    case AnimalTypes.Bird:
                        animal = CreateAnimalBird(out ok);                        
                        break;

                    case AnimalTypes.Reptile:
                        animal = CreateAnimalReptile(out ok);
                        break;
                }  
            }
            
            if(animal != null)
            {
                ReadGeneralInfo(ref animal, out okGeneral);
            }


            return animal;
        }  



        /// <summary>
        /// method to read the name of animal
        /// </summary>
        /// <param name="okName"></param>
        /// <returns></returns>
        private string ReadName(out bool okName)
        {
            okName = false;
            string name = string.Empty;
            if (!string.IsNullOrEmpty(tbName.Text))
            {
                name = tbName.Text;
                okName = true;
            }
            else
            {
                MessageBox.Show("Please give a name for the animal.");
            }
            return name;
        }



        /// <summary>
        /// method to read the age fo animal
        /// </summary>
        /// <param name="okAge"></param>
        /// <returns></returns>
        private double ReadAge(out bool okAge)
        {
            double age;
            okAge = false;
            if (!string.IsNullOrEmpty(tbAge.Text) && double.TryParse(tbAge.Text, out age))
            {
                okAge = true;
            }
            else
            {
                MessageBox.Show("Please give an age for the animal.");
                age = 0;
            }
            return age;
        }



        /// <summary>
        /// method to read the gender of animal
        /// </summary>
        /// <param name="okGender"></param>
        /// <returns></returns>
        private GenderTypes ReadGender(out bool okGender)
        {
            GenderTypes gender;
            okGender = false;
            if (cmbGender.SelectedIndex >= 0)
            {
                gender = (GenderTypes)cmbGender.SelectedIndex;
                okGender = true;
            }
            else
            {
                MessageBox.Show("Please select a gender for the animal.");
                gender = GenderTypes.unkown;
            }
            return gender;
        }



        /// <summary>
        /// method to read the general information of animal
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="okGeneral"></param>
        private void ReadGeneralInfo(ref Animal animal, out bool okGeneral)
        {

            okGeneral = false;
            animal.Id = GenerateId();
            animal.Name = ReadName(out bool okName);
            animal.Age = ReadAge(out bool okAge);
            animal.Gender = ReadGender(out bool okGender);
            

            if (okName && okAge && okGender)
            {
                okGeneral = true;
            }
        }



        /// <summary>
        /// to select a category and then show the sub category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxCategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxCategori.SelectedIndex >= 0)
            {
                if(lbxCategori.SelectedIndex == 0)
                {
                    lbxAnimal.Items.Clear();
                    lbxAnimal.Items.AddRange(Enum.GetNames(typeof(Types.MamalTypes)));
                    DisableTextBoxes();
                    tbNoTeeth.Enabled = true;
                }
                
                if (lbxCategori.SelectedIndex == 1)
                {
                    lbxAnimal.Items.Clear();
                    lbxAnimal.Items.AddRange(Enum.GetNames(typeof(Types.BirdTypes)));
                    DisableTextBoxes();
                    tbWingLength.Enabled = true;
                }

                if (lbxCategori.SelectedIndex == 2)
                {
                    lbxAnimal.Items.Clear();
                    lbxAnimal.Items.AddRange(Enum.GetNames(typeof(Types.ReptileTypes)));
                    DisableTextBoxes();
                    tbLifeLong.Enabled = true;
                }
            }
        }

        /// <summary>
        /// to disable and enable desired text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAnimal.SelectedIndex >= 0)
            {
                if (lbxAnimal.SelectedIndex == 0 && lbxCategori.SelectedIndex ==0)
                {
                    DisableTextBoxes();
                    tbEyeColor.Enabled = true;
                    tbNoTeeth.Enabled = true;

                }

                if (lbxAnimal.SelectedIndex == 1 && lbxCategori.SelectedIndex == 0)
                {
                    DisableTextBoxes();
                    tbBreed.Enabled = true;
                    tbNoTeeth.Enabled = true;
                }

                if (lbxAnimal.SelectedIndex == 2 && lbxCategori.SelectedIndex == 0)
                {
                    DisableTextBoxes();
                    tbLand.Enabled = true;
                    tbNoTeeth.Enabled = true;
                }

                if (lbxAnimal.SelectedIndex == 0 && lbxCategori.SelectedIndex == 1)
                {
                    DisableTextBoxes();
                    tbHeightofFly.Enabled = true;
                    tbWingLength.Enabled = true;
                }

                if (lbxAnimal.SelectedIndex == 1 && lbxCategori.SelectedIndex == 1)
                {
                    DisableTextBoxes();
                    tbColorofWings.Enabled = true;
                    tbWingLength.Enabled = true;
                }

                if (lbxAnimal.SelectedIndex == 0 && lbxCategori.SelectedIndex == 2)
                {
                    DisableTextBoxes();
                    tbxLength.Enabled = true;
                    tbLifeLong.Enabled = true;
                }

                if (lbxAnimal.SelectedIndex == 1 && lbxCategori.SelectedIndex == 2)
                {
                    DisableTextBoxes();
                    tbColorTurtle.Enabled = true;
                    tbLifeLong.Enabled = true;
                }
            }

        }

        /// <summary>
        /// to disable all text boxes but not name, age and gender text boxes
        /// </summary>
        private void DisableTextBoxes()
        {
            tbEyeColor.Enabled = false;
            tbBreed.Enabled = false;
            tbHeightofFly.Enabled = false;
            tbWingLength.Enabled = false;
            tbColorofWings.Enabled = false;
            tbNoTeeth.Enabled = false;
            tbLifeLong.Enabled = false;
            tbColorTurtle.Enabled = false;
            tbxLength.Enabled = false;
            tbLand.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// to clear text boxes
        /// </summary>
        private void RefreshTBoxes()
        {
            tbColorofWings.Text = "";
            tbBreed.Text = "";
            tbEyeColor.Text = "";
            tbNoTeeth.Text = "";
            tbWingLength.Text = "";
            tbHeightofFly.Text = "";
            tbLifeLong.Text = "";
            tbColorTurtle.Text = "";
            tbxLength.Text = "";
            tbLand.Text = "";
        }

        /// <summary>
        /// method to generate a 4-digit Id
        /// </summary>
        /// <returns></returns>
        private string GenerateId()
        {
            Random randomNumberGenerator = new Random();
            return string.Concat(
                randomNumberGenerator.Next(0, 9),
                randomNumberGenerator.Next(0, 9),
                randomNumberGenerator.Next(0, 9),
                randomNumberGenerator.Next(0, 9));
        }

        /// <summary>
        /// to show all information about the animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        { 
            lblAnimalInfo.Text = "";
            bool ok = false;
            Animal animal = ReadAnimal(out ok);
            

            if (ok && okGeneral)
            {
                lblAnimalInfo.Text = animal.ToString();
            }  
        }


        /// <summary>
        /// to add the animal to the main list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            bool ok = false;
            Animal animal = ReadAnimal(out ok);
            RefreshTBoxes();

            manager.AddAnimal(animal);

            lbxAnimalsList.Items.Clear();

            ShowList(manager.animalList);

            lblAnimalInfo.Text = "";

        }

        /// <summary>
        /// to show basic information in the list box
        /// </summary>
        /// <param name="list"></param>
        private void ShowList(List<Animal> list)
        {
            foreach (var item in list)
            {
                lbxAnimalsList.Items.Add($"{item.Id}   \t{item.Name}   \t{item.Age}    \t{item.Gender}");
            }
        }


        /// <summary>
        /// to show details when click on an animal in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxAnimalsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal animal;

            if(lbxAnimalsList.SelectedIndex >= 0)
            {
                lbxFoodInfo.Items.Clear();

                animal = manager.animalList[lbxAnimalsList.SelectedIndex];

                lblAnimalExtraInfo.Text = animal.ToString();

                lblEaterType.Text = animal.GetFoodSchedule().EaterType.ToString();

                lbxFoodInfo.Items.Add(animal.GetFoodSchedule().GetFoodListInfoStrings()[0]);
                lbxFoodInfo.Items.Add(animal.GetFoodSchedule().GetFoodListInfoStrings()[1]);
                lbxFoodInfo.Items.Add(animal.GetFoodSchedule().GetFoodListInfoStrings()[2]);

            }
        }
    }
}
