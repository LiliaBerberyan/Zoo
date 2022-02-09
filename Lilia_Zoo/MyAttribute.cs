using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilia_Zoo
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class MyAttribute : Attribute
    {
        private int number;
        public int Max { get; }
        public int Min { get; }
        public MyAttribute(int max, int min)
        {
            this.Max = max;
            this.Min = min;
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value > Min || value < Max)
                {
                    number = value;
                }
                else
                {
                    throw new ArgumentException("Value is out of range");
                }
            }
        }
    }
}
