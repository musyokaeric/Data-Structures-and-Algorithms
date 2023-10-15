// See https://aka.ms/new-console-template for more information
using Recursion;

Console.WriteLine("Hello, World!");

Console.WriteLine("============================================================");
Console.WriteLine("Understanding the difference between Iteration vs. Recursion");

var r1 = new IterationVsRecursion();

Console.WriteLine("Iterative function:");
r1.IterativeCalculation(4);
Console.ReadKey();

Console.WriteLine("Recursive function:");
r1.RecursiveCalculation(4);
Console.ReadKey();

Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("Types of Recursions");

var r2 = new RecursionTypes();

Console.WriteLine("Head recursion:");
r2.HeadRecursion(4);
Console.ReadKey();

Console.WriteLine("Tail recursion:");
r2.TailRecursion(4);
Console.ReadKey();

Console.WriteLine("Tree recursion:");
r2.TreeRecursion(4);
Console.ReadKey();

Console.WriteLine("Indirect recursion:");
r2.IndirectRecursionA(4);
Console.ReadKey();

Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("Sum of N Natural Numbers");

var r3 = new SumOfNumbers();

Console.WriteLine();
Console.WriteLine("Sum of N: " + r3.SumofN(5));
Console.WriteLine("Sum of N Iterative: " + r3.SumofNIteration(5));
Console.WriteLine("Sum of N Recursive: " + r3.SumofNRecursion(5));
Console.ReadKey();

Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("Factorial of N Natural Numbers");

var r4 = new Factorial();

Console.WriteLine();
Console.WriteLine("Factorial of N Iterative: " + r4.FactorialIterative(5));
Console.WriteLine("Factorial of N Recursive: " + r4.FactorialRecursive(5));
Console.ReadKey();


// Exercice: Use substitution method to get the recursive functions for:
// 1. Sum of N natural numbers => Sum(n) = 1 + 2 + 3 + 4 + ... + (n - 2) + (n - 1) + n
// 2. Factorial of N => Fact(n) = 1 x 2 x 3 x 4 x ... x (n - 2) x (n - 1) x n
//
// Note: Factorial of zero is 1.