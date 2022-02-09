using System;
using System.Collections.Generic;
using System.Timers;

namespace Lilia_Zoo
{
    class Zoo
    {
        public Zoo()
        {
            Cages = new List<Cage>();
        }
        private List<Cage> Cages { get; set; }

        ILogger _logger = new Logger(typeof(Zoo));

        Timer timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);
        public void AddCage(Cage cage)
        {
            Cages.Add(cage);
            _logger.Info($"{cage.ToString()} added to Zoo");
        }
        public void StartWork()
        {
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            Console.ReadKey();
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            StartFeeding();
        }
        public void StartFeeding()
        {
            for (int i = 0; i < Cages.Count; i++)
            {
                _logger.Info($"Feeding Animals in {Cages[i].ToString()} started");
                if (Cages[i].GetAnimalType().Name=="Horse" || Cages[i].GetAnimalType().Name == "Elephant")
                {
                    Cages[i].PutFood(new MyEventArgs(new Food(FoodType.Grass, 10)));
                }
                if (Cages[i].GetAnimalType().Name == "Horse")
                {
                    Cages[i].PutFood(new MyEventArgs(new Food(FoodType.Fruit, 10)));
                }
              
            }
        }
    }
}
