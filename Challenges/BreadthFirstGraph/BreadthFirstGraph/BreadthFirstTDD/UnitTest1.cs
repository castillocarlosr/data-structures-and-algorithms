using BreadthFirstGraph.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace BreadthFirstTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
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
            List<Vertex> printList = graph.BreadthFirst(root);
            List<Vertex> expected;
            //string expexcted = expectedList.ToString();
            foreach (Vertex item in printList)
            {
                //expected.Add(item);
            }

            //Assert.Equals("something", expected);
        }
    }
}
