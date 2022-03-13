using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilia_Zoo
{
    class Food
    {
        public Food(FoodType type, int size)
        {
            Type = type;
            Size = size;
        }
        public FoodType Type { get; }
        public int Size { get; set; }
    }
}
