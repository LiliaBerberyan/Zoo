using System;
using System.Collections.Generic;
using System.Timers;

namespace Lilia_Zoo
{

    class Zoo
    {
        private ZooWorker _worker;
        public Zoo()
        {
            _worker = new ZooWorker();
            Cages = new List<Cage>();
        }
        private List<Cage> Cages { get; set; }

        Timer timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);
        public void AddCage(Cage cage)
        {
            Cages.Add(cage);
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

        }

    }
}
