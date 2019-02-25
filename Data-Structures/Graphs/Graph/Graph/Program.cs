using System;
using System.Collections.Generic;
using Graph.Classes;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Graphs");
            Console.WriteLine("");
            
            List<object> listTest = new List<object>();

            listTest.Add("soloNode");
            Graph.Classes.Graph graph = new Graph.Classes.Graph(listTest);
            graph.AddEdge("Apple", "Banana", 10);
            graph.AddEdge("Dog", "Cat", 22);
            graph.AddEdge("xBox", "PlayStation", 7);
            Console.WriteLine("Creating a new graph with 7 nodes and 3 edges");
            Console.WriteLine($"Return size of graph:  {graph.Size()}");

            Dictionary<object, int> toNeighbor = graph.GetNeighbors("Dog");
            Dictionary<object, int> fromNeighbor = graph.GetNeighbors("xBox");
            
            //Console.WriteLine($"Return neighbor of graph from Dog node:");
            foreach (var item in toNeighbor.Values)
            {
                //Console.WriteLine(item);
            }

            Console.WriteLine("Return all vertices in the graph:  ");
            foreach (var item in graph.Vertices)
            {
                Console.WriteLine(item.Value);
            }

            Console.ReadLine();
        }
    }
}
