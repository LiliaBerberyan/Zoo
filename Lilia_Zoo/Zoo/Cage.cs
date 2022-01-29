using System;
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

        ILogger _logger = new Logger(typeof(Cage));

        public event Action<FoodType> FoodArrived;
        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            animal.SetCage(this);
            _logger.Info($"{animal.ToString()} added to {this.ToString()}");
        }
        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
            _logger.Info($"{animal.ToString()} removed from {this.ToString()}");
        }
        public void PutFood(FoodType food)
        {
            FoodArrived?.Invoke(food);
            _logger.Info($"Food put to {this.ToString()}");
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
