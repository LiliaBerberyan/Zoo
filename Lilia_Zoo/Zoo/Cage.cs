using System.Collections.Generic;

namespace Lilia_Zoo
{
    class Cage : ICage<Animal>
    {
        public Cage()
        {
            Animals = new List<Animal>();
        }
        private List<Animal> Animals { get; set; }
        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
        }
        public void PutFood()
        { 
        
        }
        //public IEnumerator GetEnumerator()
        //{
        //    return new AnimalEnumerator(Animals);
        //}
        //IEnumerator<Animal> IEnumerable<Animal>.GetEnumerator()
        //{
        //    return (IEnumerator<Animal>)GetEnumerator();
        //}
    }
}
