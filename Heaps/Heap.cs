using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class Heap
    {
        int[] data;
        int maxSize;
        int cSize;

        public Heap()
        {
            maxSize = 10;
            data = new int[maxSize];
            cSize = 0;

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = -1;
            }
        }

        public int Length => cSize;
        public bool IsEmpty => cSize == 0;

        public void Insert(int element)
        {
            if (cSize == maxSize)
            {
                Console.WriteLine("No Space in Heap");
                return;
            }
            cSize++;
            int hi = cSize;

            // up-heal bubbling
            while (hi > 1 && element > data[hi / 2]) 
            {
                data[hi] = data[hi / 2];
                hi /= 2;
            }
            data[hi] = element;
        }

        public int DeleteMax()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            int element = data[1];
            data[1] = data[cSize];
            data[cSize] = -1;
            cSize--;

            //down-heap bubbling
            int i = 1;
            int j = i * 2;
            while (j <= cSize)
            {
                if (data[j] < data[j + 1])
                    j++;
                if (data[i] < data[j])
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i = j;
                    j = i * 2;
                }
                else break;
            }
            return element;
        }

        public int Max()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            return data[1];
        }

        public void Display()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " - ");
            }
            Console.WriteLine();
        }
    }
}
