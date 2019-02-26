using BreadthFirstGraph.Classes;
using System;
using System.Collections.Generic;

namespace BreadthFirstGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Breadth First Graph");
            Console.WriteLine("");

            List<object> listTest = new List<object>();

            listTest.Add("soloNode");

            
            Graph graph = new Graph(listTest);
            graph.Vertices = new List<Vertex>();
            Vertex root = new Vertex("Apple");
            listTest.Add(root);
            listTest.Add("more");
            graph.AddEdge(root, "Banana", 10);
            graph.AddEdge("Dog", "Cat", 22);
            graph.AddEdge("xBox", "PlayStation", 7);
            Console.WriteLine("Creating a new graph with 6 nodes and 3 edges");
            Console.WriteLine($"Return size of graph:  {graph.Size()}");
            Console.WriteLine("");
            Console.WriteLine($"Breadth First Traversal: {graph.BreadthFirst(root)}");
            //graph.BreadthFirst(root);
            Console.WriteLine("==========BreadthFirst=========");
            List<Vertex> printList = graph.BreadthFirst(root);
            foreach (Vertex item in printList)
            {
                Console.Write(item.Value);
            }

            Console.ReadLine();
        }
    }
}
