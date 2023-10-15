using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Sort
    {
        public static void Display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
                if (i < n - 1) 
                    Console.Write(A[i] + ", ");
                else
                    Console.Write(A[i]);
            Console.WriteLine();
        }

        public void SelectionSort(int[] A, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int position = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] < A[position])
                        position = j;

                    //swapping
                    int temp = A[i];
                    A[i] = A[position];
                    A[position] = temp;
                }
            }
            Display(A, n);
        }

        public void InsertionSort(int[] A, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int temp = A[i];
                int position = i;

                while (position > 0 && A[position - 1] > temp)
                {
                    A[position] = A[position - 1];
                    position -= 1;
                }
                A[position] = temp;
            }
            Display(A, n);
        }

        public void BubbleSort(int[] A, int n)
        {
            for (int pass = n - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        // swapping
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }
            Display(A, n);
        }

        public void ShellSort(int[] A, int n)
        {
            int gap = n / 2;
            while (gap > 0)
            {
                int i = gap;
                while (i < n)
                {
                    int temp = A[i];
                    int j = i - gap;
                    while (j >= 0 && A[j] > temp)
                    {
                        A[j + gap] = A[j];
                        j -= gap;
                    }
                    A[j + gap] = temp;
                    i++;
                }
                gap /= 2;
            }

            // **************** OR ********************

            //for (int gap = n / 2; gap > 0; gap = gap / 2)
            //{
            //    for (int i = gap; i < n; i++)
            //    {
            //        int temp = A[i];
            //        int j = i - gap;

            //        while (j >= 0 && A[j] > temp)
            //        {
            //            A[j + gap] = A[j];
            //            j -= gap;
            //        }
            //        A[j + gap] = temp;
            //    }
            //}

            Display(A, n);
        }

        public void MergeSort(int[] A, int LEFT, int RIGHT)
        {
            if (LEFT < RIGHT)
            {
                // Divide and conquer
                int MID = (LEFT + RIGHT) / 2;
                MergeSort(A, LEFT, MID);
                MergeSort(A, MID + 1, RIGHT);

                // Merge
                Merge(A, LEFT, MID, RIGHT);
            }
        }

        private void Merge(int[] A, int LEFT, int MID, int RIGHT)
        {
            int i = LEFT;
            int j = MID + 1;
            int k = LEFT;
            int[] B = new int[RIGHT + 1];

            while (i <= MID && j <= RIGHT)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i++;
                }
                else
                {
                    B[k] = A[j];
                    j++;
                }
                k++;
            }
            while (i <= MID)
            {
                B[k] = A[i];
                i++; k++;
            }
            while (j <= RIGHT)
            {
                B[k] = A[j];
                j++; k++;
            }
            for (int x = LEFT; x < RIGHT + 1; x++)
            {
                A[x] = B[x];
            }
        }

        public void QuickSort(int[] A, int LOW, int HIGH)
        {
            if (LOW < HIGH)
            {
                // Create Partition
                int PARTITION = GetPartition(A, LOW, HIGH);

                // Quick Sort
                QuickSort(A, LOW, PARTITION - 1);
                QuickSort(A, PARTITION + 1, HIGH);
            }
        }

        private int GetPartition(int[] A, int LOW, int HIGH)
        {
            int pivot = A[LOW];
            int i = LOW + 1;
            int j = HIGH;

            do
            {
                while (i <= j && A[i] <= pivot)
                    i++;

                while (i <= j && A[j] > pivot)
                    j--;

                if (i <= j)
                    Swap(A, i, j);

            } while (i < j);

            Swap(A, LOW, j);

            return j;
        }

        private void Swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }
}
