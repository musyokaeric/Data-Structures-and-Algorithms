// See https://aka.ms/new-console-template for more information
using Queues;

Console.WriteLine("Hello, World!");

QueuesArray q1 = new QueuesArray(10);
QueuesLinked q2 = new QueuesLinked();
DEQueLinked q3 = new DEQueLinked();

// The following works on QueuesArray and QueuesLinked objects. Go through each method on each class to undestand queues better.

//q2.Enqueue(5);
//q2.Enqueue(3);

//q2.Display();
//Console.WriteLine("Size: " + q2.Length);
//Console.ReadKey();

//Console.WriteLine("Element dequeued: " + q2.Dequeue());
//Console.WriteLine("IsEmpty: " + q2.IsEmpty);
//Console.WriteLine("Element dequeued: " + q2.Dequeue());
//Console.WriteLine("IsEmpty: " + q2.IsEmpty);
//Console.ReadKey();

//q2.Enqueue(7);
//q2.Enqueue(9);

//q2.Display();
//Console.WriteLine("Size: " + q2.Length);
//Console.ReadKey();

// The following works on DEQue object. Go through each method on each class to undestand queues better.

q3.AddFirst(5);
q3.AddFirst(3);
q3.AddLast(7);
q3.AddLast(12);

q3.Display();
Console.WriteLine("Size: " + q3.Length);
Console.ReadKey();

Console.WriteLine("Front element dequeued: " + q3.RemoveFirst());
Console.WriteLine("Rear element dequeued: " + q3.RemoveLast());
Console.WriteLine("IsEmpty: " + q3.IsEmpty);
Console.WriteLine("Front element dequeued: " + q3.RemoveFirst());
Console.WriteLine("Rear element dequeued: " + q3.RemoveLast());
Console.WriteLine("IsEmpty: " + q3.IsEmpty);
Console.ReadKey();

q3.AddFirst(5);
q3.AddFirst(3);
q3.AddLast(7);
q3.AddLast(12);

q3.Display();
Console.WriteLine("Size: " + q3.Length);
Console.ReadKey();

Console.WriteLine("First element: " + q3.First);
Console.WriteLine("Last element: " + q3.Last);
Console.ReadKey();
