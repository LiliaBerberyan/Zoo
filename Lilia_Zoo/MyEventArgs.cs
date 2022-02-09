using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilia_Zoo
{
    class MyEventArgs : EventArgs
    {
        public MyEventArgs(Food food)
        {
            Food = food;
        }
        public Food Food { get; set; }
    }
}
