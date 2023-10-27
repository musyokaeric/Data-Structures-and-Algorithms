using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Heaps
{
    public class HeapSort
    {
        public void Sort(int[] A, int n)
        {
            Heap heap = new Heap();
            for (int i = 0; i < n; i++)
            {
                heap.Insert(A[i]);
            }
            int k = n - 1;
            for (int i = 0; i < n; i++)
            {
                A[k] = heap.DeleteMax();
                k--;
            }
            Display(A, n);
        }

        public void Display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " - ");
            }
            Console.WriteLine();
        }
    }
}
