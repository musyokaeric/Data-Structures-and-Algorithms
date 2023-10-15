using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class Search
    {
        public int LinearSearch(int[] A, int n, int key)
        {
            int index = 0;
            while (index < n)
            {
                if (A[index] == key)
                    return index;
                index += 1;
            }
            return -1;
        }

        public int BinarySearchIterative(int[] A, int n, int key)
        {
            int LEFT = 0;
            int RIGHT = n - 1;

            while (LEFT <= RIGHT)
            {
                int MIDDLE = (LEFT + RIGHT) / 2;
                if (key == A[MIDDLE])
                    return MIDDLE;
                else if (key < A[MIDDLE])
                    RIGHT = MIDDLE - 1;
                else if (key > A[MIDDLE])
                    LEFT = MIDDLE + 1;
            }
            return -1;
        }

        public int BinarySearchRecursive(int[] A, int key, int LEFT, int RIGHT)
        {
            if (LEFT > RIGHT) return -1;
            else
            {
                int MIDDLE = (LEFT + RIGHT) / 2;
                if (key == A[MIDDLE])
                    return MIDDLE;
                else if (key < A[MIDDLE])
                    return BinarySearchRecursive(A, key, LEFT, MIDDLE - 1);
                else if (key > A[MIDDLE])
                    return BinarySearchRecursive(A, key, MIDDLE + 1, RIGHT);
            }
            return -1;
        }
    }
}
