using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WMPLib;

namespace Lilia_Zoo
{
    abstract class Animal 
    {
        private int _id;
        private int _stomachSize;
        protected string url;
        protected int MaxSize { get; set; }
        public bool Alive { get; set; }
        public Animal(int id, int maxSize)
        {
            this.Id = id;
            StomachSize = maxSize;
            this.MaxSize = maxSize;
            Alive = true;
        }
        protected int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 1000 || value < 9999)
                {
                    _id = value;
                }
                else throw new ArgumentException("Valu is out of range");
            }
        }
        protected int StomachSize
        {
            get
            {
                return _stomachSize;
            }
            set
            {
                if (value < 0 || value > MaxSize)
                {
                    Alive = false;
                }
                else _stomachSize = value;
            }
        }
        protected abstract List<FoodType> AvailableFood { get; set; }

        protected Timer timer = new Timer(TimeSpan.FromSeconds(6).TotalMilliseconds);
        public void CallToEat()
        {
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
        }
        protected virtual void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (StomachSize <= MaxSize)
            {
                StomachSize--;
            }
        }
        protected bool CanEat(FoodType food)
        {
            if (AvailableFood.Contains(food))
            {
                return true;
            }
            else return false;
        }
        public void Feed(FoodType food)
        {
            if (Alive)
            {
                if (CanEat(food) || StomachSize + 2 < MaxSize)
                {
                    Console.WriteLine($"Feeding {this.ToString()} is done");
                    StomachSize += 2;
                }
                else if (!CanEat(food))
                {
                    Console.WriteLine($"{this.ToString()} can't eat {food}");
                }
                else if (CanEat(food) || StomachSize > MaxSize - 2)
                {
                    Console.WriteLine($"{this.ToString()} isn't hungry");
                }
            }
            else
            {
                Voice();
                Console.WriteLine($"{this.ToString()} is dead");              
            }
        }
        public override string ToString()
        {
            return $"{this.Id}_{this.GetType()}";
        }
        public void Voice()
        {
            WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

            wplayer.URL = url;

            wplayer.controls.play();
        }
    }
}
