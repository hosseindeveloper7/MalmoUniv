using assignment_1.Services;
using assignment_1.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
        double Age { get; set; }
        GenderTypes Gender { get; set; }

        FoodSchedule GetFoodSchedule();

        string GetExtraInfo();
    }
}
