using System;
using System.Collections;
using System.Collections.Generic;

namespace Lilia_Zoo
{
    class AnimalEnumerator : IEnumerator<Animal>
    {
        Animal[] animals;
        int position = -1;
        private List<object> animals1;

        public AnimalEnumerator(List<Animal> animals)
        {
            this.animals = new Animal[animals.Count];
            animals.CopyTo(this.animals);
        }

        public AnimalEnumerator(List<object> animals1)
        {
            this.animals1 = animals1;
        }

        public Animal Current
        {
            get
            {
                if (position == -1 || position >= animals.Length)
                {
                    throw new ArgumentException();
                }
                else
                {
                    return animals[position];
                }
            }
        }
        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
        public bool MoveNext()
        {
            if (position < animals.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }
    }
}
