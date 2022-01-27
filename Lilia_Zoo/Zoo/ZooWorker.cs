using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lilia_Zoo
{
    class ZooWorker
    {       
        public void FeedAnimal(Animal animal, FoodType food)
        {
            animal.Feed(food);
        }
    }
}
