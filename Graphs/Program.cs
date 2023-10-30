// See https://aka.ms/new-console-template for more information
using Graphs;

Console.WriteLine("Hello, World!");

Console.WriteLine("============================================================");
Console.WriteLine("Graphs Abstract Data Types");

GraphsADT graph1 = new GraphsADT(4);
graph1.Display();
Console.WriteLine("Vertices count: " + graph1.VertexCount);
Console.WriteLine("Edges count: " + graph1.EdgeCount());
Console.WriteLine();

graph1.InsertEdge(0, 1, 26);
graph1.InsertEdge(0, 2, 16);
graph1.InsertEdge(1, 0, 26);
graph1.InsertEdge(1, 2, 12);
graph1.InsertEdge(2, 0, 16);
graph1.InsertEdge(2, 1, 12);
graph1.InsertEdge(2, 3, 8);
graph1.InsertEdge(3, 2, 8);

Console.WriteLine();
Console.WriteLine("Graphs Adjacency Matrix:");
graph1.Display();
Console.WriteLine("Vertices count: " + graph1.VertexCount);
Console.WriteLine("Edges count: " + graph1.EdgeCount());
graph1.Edges();
Console.WriteLine();

Console.WriteLine("Edge between 1--3: " + graph1.ExistsEdge(1, 3));
Console.WriteLine("Edge between 1--2: " + graph1.ExistsEdge(1, 2));
Console.WriteLine("Degree of Vertex 2: " + graph1.InDegree(2));
Console.WriteLine();

Console.WriteLine("Graphs Adjacency Matrix:");
graph1.Display();
Console.WriteLine();

Console.WriteLine("Graphs Adjacency Matrix:");
graph1.RemoveEdge(1, 2);
graph1.Display();
Console.WriteLine("Edge between 1--2: " + graph1.ExistsEdge(1, 2));
Console.ReadKey();

Console.WriteLine();
Console.WriteLine("Breadth First Search");
Console.WriteLine("============================================================");
Console.WriteLine();

GraphsADT graph2 = new GraphsADT(7);
graph2.InsertEdge(0, 1, 1);
graph2.InsertEdge(0, 5, 1);
graph2.InsertEdge(0, 6, 1);
graph2.InsertEdge(1, 0, 1);
graph2.InsertEdge(1, 2, 1);
graph2.InsertEdge(1, 5, 1);
graph2.InsertEdge(1, 6, 1);
graph2.InsertEdge(2, 3, 1);
graph2.InsertEdge(2, 4, 1);
graph2.InsertEdge(2, 6, 1);
graph2.InsertEdge(3, 4, 1);
graph2.InsertEdge(4, 2, 1);
graph2.InsertEdge(4, 5, 1);
graph2.InsertEdge(5, 2, 1);
graph2.InsertEdge(5, 3, 1);
graph2.InsertEdge(6, 3, 1);
graph2.BreadthFirstSearch(0); //first level vertex
Console.ReadKey();

Console.WriteLine();
Console.WriteLine("Depth First Search");
Console.WriteLine("============================================================");
Console.WriteLine();

GraphsADT graph3 = new GraphsADT(7);
graph3.InsertEdge(0, 1, 1);
graph3.InsertEdge(0, 5, 1);
graph3.InsertEdge(0, 6, 1);
graph3.InsertEdge(1, 0, 1);
graph3.InsertEdge(1, 2, 1);
graph3.InsertEdge(1, 5, 1);
graph3.InsertEdge(1, 6, 1);
graph3.InsertEdge(2, 3, 1);
graph3.InsertEdge(2, 4, 1);
graph3.InsertEdge(2, 6, 1);
graph3.InsertEdge(3, 4, 1);
graph3.InsertEdge(4, 2, 1);
graph3.InsertEdge(4, 5, 1);
graph3.InsertEdge(5, 2, 1);
graph3.InsertEdge(5, 3, 1);
graph3.InsertEdge(6, 3, 1);
graph3.DepthFirstSearch(0); //first level vertex
Console.ReadKey();