// See https://aka.ms/new-console-template for more information
using Hashing;

Console.WriteLine("Hello, World!");

Console.WriteLine("============================================================");
Console.WriteLine("Hash table chaining");

HashChain chain = new HashChain();
chain.Insert(54);
chain.Insert(78);
chain.Insert(64);
chain.Insert(92);
chain.Insert(34);
chain.Insert(86);
chain.Insert(28);
chain.Display();
Console.WriteLine("Element 54 found: " + chain.Search(54));
Console.WriteLine("Element 58 found: " + chain.Search(58));
Console.ReadKey();

Console.WriteLine("============================================================");
Console.WriteLine("Hash linear probe");

HashLinearProbe linearProbe = new HashLinearProbe();
linearProbe.Insert(54);
linearProbe.Insert(78);
linearProbe.Insert(64);
linearProbe .Insert(92);
linearProbe.Insert(34);
linearProbe.Insert(86);
linearProbe.Insert(28);
chain.Display();
Console.WriteLine("Element 54 found: " + linearProbe.Search(54));
Console.WriteLine("Element 58 found: " + linearProbe.Search(58));
Console.ReadKey();