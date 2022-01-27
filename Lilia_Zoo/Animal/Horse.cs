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
            timer.Start();
            url = "Horse.mp3";
        }
        protected override List<FoodType> AvailableFood { get; set; } = new List<FoodType>() { FoodType.Fruit, FoodType.Grass };
    }
}
