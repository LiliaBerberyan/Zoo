using System;

namespace Lilia_Zoo
{
    interface ICage<in T>
    {
        event Action<FoodType> FoodArrived;
        void AddAnimal(T animal);
        void RemoveAnimal(T animal);
    }
}
