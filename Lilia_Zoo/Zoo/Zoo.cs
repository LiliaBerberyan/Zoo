using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lilia_Zoo
{
    class Zoo //: IEnumerable<Animal>
    {
        private ZooWorker _worker;
        public Zoo()
        {
            _worker = new ZooWorker();
            Cages = new List<Cage<Animal>>();
        }
        private List<Cage<Animal>> Cages { get; set; }

        Timer timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);
        
        public void StartWork()
        {
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            Console.ReadKey();
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var random = new Random();
            //foreach (Animal animal in Animals)
            //{
            //    _worker.FeedAnimal(animal, random.NextEnum<FoodType>());
            //    if (!animal.Alive)
            //    {
            //        RemoveAnimal(animal);
            //    }
            //}
        }
        //public IEnumerator GetEnumerator()
        //{
        //    return new AnimalEnumerator(Cages);
        //}
        //IEnumerator<Animal> IEnumerable<Animal>.GetEnumerator()
        //{
        //    return (IEnumerator<Animal>)GetEnumerator();
        //}
    }
}
