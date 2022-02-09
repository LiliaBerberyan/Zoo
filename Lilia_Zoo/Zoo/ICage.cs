using System;

namespace Lilia_Zoo
{
    interface ICage<in T>
    {
        event EventHandler<MyEventArgs> FoodArrived;
        void AddAnimal(T animal);
        void RemoveAnimal(T animal);
    }
}
