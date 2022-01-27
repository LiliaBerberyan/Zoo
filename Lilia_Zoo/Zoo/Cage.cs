using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilia_Zoo
{
    class Cage<T> where T : Animal
    {
        public Cage()
        {
            Animals = new List<T>();
        }
        private List<T> Animals { get; set; }
        public void AddAnimal(T animal)
        {
            Animals.Add(animal);
        }
        public void RemoveAnimal(T animal)
        {
            Animals.Remove(animal);
        }

    }
}
