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

        public event EventHandler<MyEventArgs> FoodArrived;
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
        public void PutFood(MyEventArgs Food)
        {
            FoodArrived?.Invoke(this, Food);
            _logger.Info($"Food put to {this.ToString()}");
        }
        public Type GetAnimalType()
        {
            if (Animals.Count != 0)
            {
                return Animals[0].GetType();               
            }
            else throw new Exception();
        }
    }
}
