using System;
using System.Collections.Generic;
using System.Text;

namespace Pile.Classes
{
    internal class PileGenerique<T>
    {
        private T[] elements;
        private int count;

        public PileGenerique()
        {
            elements = new T[0];
            count = 0;
        }
        public void Empiler(T element)
        {
            if (count >= elements.Length)
                throw new InvalidOperationException("Pile pleine");
            elements[count] = element;
            count++;
        }
        public T Depiler()
        {
            if (count == 0)
                throw new InvalidOperationException("Pile vide");
            count--;
            T element = elements[count];
            elements[count] = default(T);
            return element;
        }

        public T RetirerElementParIndex(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException("Index hors limites");
            T element = elements[index];
            for (int i = index; i < count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            elements[count - 1] = default(T);
            count--;
            return element;
        }
       

    }
}
