// See https://aka.ms/new-console-template for more information
using SearchAlgorithms;

Console.WriteLine("Hello, World!");

Console.WriteLine("============================================================");
Console.WriteLine("Understanding Search Algorithms");
int[] A = { 15, 21, 47, 84, 96 };

var s1 = new Search();

int index = s1.LinearSearch(A, 5, 96);
Console.WriteLine("Linear Search: Index " + index);
Console.ReadKey();

index = s1.BinarySearchIterative(A, 5, 96);
Console.WriteLine("Binary Search Iterative: Index " + index);
Console.ReadKey();

index = s1.BinarySearchRecursive(A, 96, 0, 4);
Console.WriteLine("Binary Search Recursive: Index " + index);
Console.ReadKey();
