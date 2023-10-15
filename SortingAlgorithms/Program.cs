// See https://aka.ms/new-console-template for more information
using SortingAlgorithms;

Console.WriteLine("Hello, World!");

Console.WriteLine("============================================================");
Console.WriteLine("Sorting Algorithms");

var s = new Sort();

int[] A = { 3, 5, 8, 9, 6, 2 };

Console.WriteLine();
Console.Write("Original array: ");
Sort.Display(A, 6);

Console.Write("Selection sort: ");
s.SelectionSort(A, 6);
Console.ReadKey();

A = new int[]{ 3, 5, 8, 9, 6, 2 };

Console.WriteLine();
Console.Write("Original array: ");
Sort.Display(A, 6);

Console.Write("Insertion sort: ");
s.InsertionSort(A, 6);
Console.ReadKey();

A = new int[] { 3, 5, 8, 9, 6, 2 };

Console.WriteLine();
Console.Write("Original array: ");
Sort.Display(A, 6);

Console.Write("Bubble sort: ");
s.BubbleSort(A, 6);
Console.ReadKey();

A = new int[] { 3, 5, 8, 9, 6, 2 };

Console.WriteLine();
Console.Write("Original array: ");
Sort.Display(A, 6);

Console.Write("Shell sort: ");
s.ShellSort(A, 6);
Console.ReadKey();

A = new int[] { 3, 5, 8, 9, 6, 2 };

Console.WriteLine();
Console.Write("Original array: ");
Sort.Display(A, 6);

Console.Write("Merge sort: ");
s.MergeSort(A, 0, 5);
Sort.Display(A, 6);
Console.ReadKey();

A = new int[] { 3, 5, 8, 9, 6, 2 };

Console.WriteLine();
Console.Write("Original array: ");
Sort.Display(A, 6);

Console.Write("Quick sort: ");
s.QuickSort(A, 0, 5);
Sort.Display(A, 6);
Console.ReadKey();