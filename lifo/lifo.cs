using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifo
{
    
    public class LIFO
    {
        private double[] items;
        private int count;
        private int capacity;

        public LIFO()
        {

        }   
        public LIFO(int initialCapacity = 100)
        {
            this.capacity = initialCapacity;
            this.items = new double[capacity];
            this.count = 0;
        }

        public void Push(double elem)
        {
            if (count == capacity)
            {
                Console.WriteLine("A tároló megtelt!");
                return;
            }

            items[count++] = elem;
        }

        public double Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("A tároló üres!");
            }

            return items[--count];
        }

        public void Clear()
        {
            count = 0;
        }

        public int Length()
        {
            return count;
        }

        public int GetSize()
        {
            return capacity;
        }

        public double[] Reverse()
        {
            double[] reversedItems = new double[count];
            for (int i = 0; i < count; i++)
            {
                reversedItems[i] = items[count - 1 - i];
            }
            return reversedItems;
        }
    }
}

