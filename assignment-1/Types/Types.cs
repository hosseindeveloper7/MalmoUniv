using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Types
{
    //animal category like: mammal, bird, reptile etc
    public enum AnimalTypes
    {
        Mamal,
        Bird,
        Reptile
    }

    //mammal types like : cat, dog, elephan etc
    public enum MamalTypes
    {
        Cat,
        Dog,
        Sheep
    }

    public enum ReptileTypes
    {
        Snake,
        Turtle
    }

    //bird types like : eagle, parrot etc
    public enum BirdTypes
    {
        Eagle,
        Parrot
    }

    //Gender types
    public enum GenderTypes
    {
        male,
        female,
        unkown
    }

    //EaterType
    public enum EaterType
    {
        MeatEater,
        PlantEater,
        AllEater
    }
}
