using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WMPLib;

namespace Lilia_Zoo
{
    class Elephant : Animal
    {
        public Elephant(int id, int maxSize) : base(id, maxSize)
        {
            timer.Start();
            url= "Elephant.mp3";
        }
        protected override List<FoodType> AvailableFood { get; set; } = new List<FoodType>() { FoodType.Grass };
      
        protected override void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (StomachSize <= MaxSize)
            {
                StomachSize -= 3;
            }
        }
       
    }
}
