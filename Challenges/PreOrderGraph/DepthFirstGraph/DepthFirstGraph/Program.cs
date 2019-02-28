using DepthFirstGraph.Classes;
using System;
using System.Collections.Generic;

namespace DepthFirstGraph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Depth First PreOrder Traversal of Graph!");

            Vertex one = new Vertex("A");
            Vertex two = new Vertex("B");
            Vertex three = new Vertex("C");
            Vertex four = new Vertex("D");
            Vertex five = new Vertex("E");
            Vertex six = new Vertex("F");
            Vertex seven = new Vertex("G");

            List<object> nodes = new List<object>();
            nodes.Add(one);
            nodes.Add(two);
            nodes.Add(three);
            nodes.Add(four);
            nodes.Add(five);
            nodes.Add(six);
            nodes.Add(seven);

            Graph graph = new Graph(nodes);
            graph.AddEdge(one, two, 150);
            graph.AddEdge(two, three, 42);
            graph.AddEdge(one, four, 82);
            graph.AddEdge(four, three, 105);
            graph.AddEdge(four, two, 99);
            graph.AddEdge(three, five, 73);
            graph.AddEdge(four, five, 26);
            graph.AddEdge(five, six, 250);
            graph.AddEdge(four, six, 37);
            graph.AddEdge(one, seven, 987);
            bool visited = false;

            DepthFirst(seven, visited);

            Console.ReadLine();
        }

        public static List<string> DepthFirst(Vertex vertex, bool visited)
        {
            List<string> output = new List<string>();

            

            output.Add(vertex.Value.ToString());

            return output;
        }

        public static void DFS(Vertex vertex)
        {
            bool visited = false;

            DepthFirst(vertex, visited);
        }
    }
}
