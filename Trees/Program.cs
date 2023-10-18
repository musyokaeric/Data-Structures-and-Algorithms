// See https://aka.ms/new-console-template for more information
using Trees;

Console.WriteLine("Hello, World!");

BinarySearchTreeIterative b1 = new BinarySearchTreeIterative();
BinarySearchTreeRecursive b2 = new BinarySearchTreeRecursive();

b2.root = b2.Insert(b2.root, 50); // only applies to BinarySearchTreeRecursive object

// The following works on BinarySearchTreeIterative and BinarySearchTreeRecursive objects. Go through each method on each class to undestand binary search trees better.

//b1.Insert(b1.root, 30);
//b1.Insert(b1.root, 80);
//b1.Insert(b1.root, 10);
//b1.Insert(b1.root, 40);
//b1.Insert(b1.root, 60);
//b1.Insert(b1.root, 90);

//Console.WriteLine("In-order Traversal");
//b1.InOrder(b1.root);
//Console.WriteLine();
//Console.WriteLine("Pre-order Traversal");
//b1.PreOrder(b1.root);
//Console.WriteLine();
//Console.WriteLine("Post-order Traversal");
//b1.PostOrder(b1.root);
//Console.WriteLine();
//Console.WriteLine("Level-order Traversal");
//b1.LevelOrder(b1.root);
//Console.WriteLine();
//Console.ReadKey();

//Console.WriteLine("Binary search result for element 60: " + b1.Search(60));
//Console.WriteLine();
//Console.WriteLine("Binary search result for element 30: " + b1.Search(30));
//Console.WriteLine();
//Console.WriteLine("Binary search result for element 70: " + b1.Search(70));
//Console.WriteLine();
//Console.ReadKey();


//Console.WriteLine("Delete element 40 from Binary search tree: " + b1.Delete(40));
//Console.WriteLine("In-order Traversal");
//b1.InOrder(b1.root);
//Console.WriteLine();
//Console.ReadKey();

b2.Insert(b2.root, 30);
b2.Insert(b2.root, 80);
b2.Insert(b2.root, 10);
b2.Insert(b2.root, 40);
b2.Insert(b2.root, 60);
b2.Insert(b2.root, 90);

Console.WriteLine("In-order Traversal");
b2.InOrder(b2.root);
Console.WriteLine();
Console.WriteLine("Pre-order Traversal");
b2.PreOrder(b2.root);
Console.WriteLine();
Console.WriteLine("Post-order Traversal");
b2.PostOrder(b2.root);
Console.WriteLine();
Console.WriteLine("Level-order Traversal");
b2.LevelOrder(b2.root);
Console.WriteLine();
Console.ReadKey();

Console.WriteLine("Binary search result for element 60: " + b2.Search(b2.root, 60));
Console.WriteLine();
Console.WriteLine("Binary search result for element 30: " + b2.Search(b2.root, 30));
Console.WriteLine();
Console.WriteLine("Binary search result for element 70: " + b2.Search(b2.root, 70));
Console.WriteLine();
Console.ReadKey();

Console.WriteLine("Number of nodes: " + b2.Count(b2.root));
Console.WriteLine();
Console.ReadKey();

Console.WriteLine("Height of binary search tree: " + b2.Height(b2.root));
Console.WriteLine();
Console.ReadKey();