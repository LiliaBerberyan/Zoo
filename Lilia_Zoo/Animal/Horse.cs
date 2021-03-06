using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WMPLib;

namespace Lilia_Zoo
{
    class Horse : Animal
    {
        public Horse(int id, int maxSize) : base(id, maxSize)
        {
            url = "Horse.mp3";
            count = 1;
        }
        protected override List<FoodType> AvailableFood { get; set; } = new List<FoodType>() { FoodType.Fruit, FoodType.Grass };
    }
}
