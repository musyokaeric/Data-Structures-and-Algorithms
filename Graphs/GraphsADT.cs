using Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class GraphsADT
    {
        int vertices;
        int[,] adjacentMatrix;
        int[] visited;

        public GraphsADT(int n)
        {
            vertices = n;
            adjacentMatrix = new int[n, n];
            visited = new int[vertices];
        }

        public int VertexCount => vertices;

        public int EdgeCount()
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    if (adjacentMatrix[i, j] != 0)
                        count++;
            }
            return count;
        }

        public void InsertEdge(int u, int v, int x)
        {
            adjacentMatrix[u, v] = x;
        }

        public void RemoveEdge(int u, int v)
        {
            adjacentMatrix[u, v] = 0;
        }

        public bool ExistsEdge(int u, int v) => adjacentMatrix[u, v] != 0;

        public void Edges()
        {
            Console.WriteLine("Edges:");
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    if (adjacentMatrix[i, j] != 0)
                        Console.WriteLine(i + " -- " + j);
            }
        }

        public int OutDegree(int v)
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
                if (adjacentMatrix[v, i] != 0)
                    count++;
            return count;
        }

        public int InDegree(int v)
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
                if (adjacentMatrix[i, v] != 0)
                    count++;
            return count;
        }

        public void Display()
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    Console.Write(adjacentMatrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        public void BreadthFirstSearch(int s) // first-level vertex
        {
            int i = s;
            QueuesLinked q = new QueuesLinked();
            Console.Write(i + " -> ");
            visited[i] = 1;
            q.Enqueue(i);
            while (!q.IsEmpty)
            {
                i = q.Dequeue();
                for (int j = 0; j < vertices; j++)
                {
                    if (adjacentMatrix[i, j] == 1 && visited[j] == 0)
                    {
                        Console.Write(j + " -> ");
                        visited[j] = 1;
                        q.Enqueue(j);
                    }
                }
            }
        }

        public void DepthFirstSearch(int s) // first-level vertex
        {
            if (visited[s] == 0)
            {
                Console.Write(s + " -> ");
                visited[s] = 1;
                for (int j = 0; j < vertices; j++)
                    if (adjacentMatrix[s, j] == 1 && visited[j] == 0)
                        DepthFirstSearch(j);
            }
        }
    }
}
