using System;

namespace Lilia_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo myZoo = new Zoo();
            ICage<Elephant> cage = new Cage();
            cage.AddAnimal(new Elephant(3654, 10));
            cage.AddAnimal(new Elephant(6543, 5));
            myZoo.AddCage((Cage)cage);
            myZoo.StartFeeding();
        }
}
}
