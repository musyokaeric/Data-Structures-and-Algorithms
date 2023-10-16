// See https://aka.ms/new-console-template for more information
using Stacks;

Console.WriteLine("Hello, World!");

StacksArray s1 = new StacksArray(10);
StackLinked s2 = new StackLinked();

// The following works on all objects. Go through each method on each class to undestand stacks better.

s2.Push(5);
s2.Push(3);

s2.Display();
Console.WriteLine("Size: " + s2.Length);
Console.ReadKey();

Console.WriteLine("Element popped: " + s2.Pop());
Console.WriteLine("IsEmpty: " + s2.IsEmpty);
Console.WriteLine("Element popped: " + s2.Pop());
Console.WriteLine("IsEmpty: " + s2.IsEmpty);
Console.ReadKey();

s2.Push(7);
s2.Push(9);

s2.Display();
Console.WriteLine("Size: " + s2.Length);
Console.ReadKey();

Console.WriteLine("Top element: " + s2.Peek());
Console.ReadKey();