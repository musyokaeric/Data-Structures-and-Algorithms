// See https://aka.ms/new-console-template for more information
using Heaps;

Console.WriteLine("Hello, World!");

Console.WriteLine("============================================================");
Console.WriteLine("Heaps");

Heap heap = new Heap();
heap.Insert(25);
heap.Insert(14);
heap.Insert(2);
heap.Insert(20);
heap.Insert(10);
heap.Display();
Console.ReadKey();
heap.Insert(40);
heap.Display();
Console.ReadKey();
Console.WriteLine("Element deleted: " + heap.DeleteMax());
heap.Display();
Console.ReadKey();
Console.WriteLine("============================================================");
Console.WriteLine("Heap sort");

HeapSort sort = new HeapSort();
int[] A = { 63, 250, 835, 947, 651, 28 };
Console.Write("Original array: ");
sort.Display(A, 6);
Console.Write("Sorted array: ");
sort.Sort(A, 6);
Console.ReadKey();