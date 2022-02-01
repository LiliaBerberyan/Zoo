using System.Collections.Generic;
using System.Timers;

namespace Lilia_Zoo
{
    class Elephant : Animal
    {
        public Elephant(int id, int maxSize) : base(id, maxSize)
        {
            timer.Start();
            url = "Elephant.mp3";
            count = 3;
        }
        protected override List<FoodType> AvailableFood { get; set; } = new List<FoodType>() { FoodType.Grass };

    }
}
