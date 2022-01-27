using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lilia_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(TimeSpan.FromSeconds(2).TotalMilliseconds);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            Console.ReadKey();

            void Timer_Elapsed(object sender, ElapsedEventArgs e)
            {
                Console.WriteLine("aaaa");
            }
            //Zoo myZoo = new Zoo();
            //myZoo.AddAnimal(new Horse(2445, 5));
            //myZoo.AddAnimal(new Elephant(1098, 15));
            //myZoo.AddAnimal(new Horse(2935, 9));
            //myZoo.AddAnimal(new Elephant(3728, 10));
            //myZoo.StartWork();

            //foreach (Animal item in myZoo)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

           // Method();
        }
        //static void Method()
        //{
        //    Timer timer = new Timer(TimeSpan.FromSeconds(3).TotalMilliseconds);
        //    timer.Elapsed += Timer_Elapsed;
        //    timer.Start();
        //    Console.ReadKey();
        //}
        //private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    Console.WriteLine("aaaa");
        //}
    }
}
