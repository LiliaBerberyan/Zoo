using System;

namespace Lilia_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo myZoo = new Zoo();

            ICage<Elephant> cageE = new Cage();
            cageE.AddAnimal(new Elephant(3654, 20));
            cageE.AddAnimal(new Elephant(6543, 15));

            myZoo.AddCage((Cage)cageE);

            ICage<Horse> cageH = new Cage();
            cageH.AddAnimal(new Horse(1789, 7));
            cageH.AddAnimal(new Horse(2343, 5));

            myZoo.AddCage((Cage)cageH);

            myZoo.StartWork();
            Console.ReadKey();
        }
    }
}
