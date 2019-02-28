using GetEdge.Classes;
using System;
using System.Collections.Generic;

namespace GetEdge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Edge from Graph");
            Console.WriteLine("");
            //Console.WriteLine(GetEdge(one, two));

            Vertex one = new Vertex("Pandora");
            Vertex two = new Vertex("Arendelle");
            Vertex three = new Vertex("Monstropolis");
            Vertex four = new Vertex("Metroville");
            Vertex five = new Vertex("Naboo");
            Vertex six = new Vertex("Narnia");
            Vertex seven = new Vertex("StarTrek");

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
            //Dictionary<string, int> neighbors = graph.GetNeighbors(one);

            string[] cities = new string[]{ "Metroville", "Pandora" };

            Console.WriteLine("Below is the trip from Metroville to Pandora");
            Console.WriteLine(graph.GetEdge(graph, cities));

            Console.ReadLine();
        }
        /*
        public static Tuple<bool, int> GetEdge(Graph graph, string[] cities)
        {
            bool exsist = false;
            int cost = 0;
            Tuple<bool, int> output = new Tuple<bool, int>(exsist, cost);
            Dictionary<string, int> neighbors = new Dictionary<string, int>();
            
            List<Vertex> vertexList = new List<Vertex>();
            for (int i = 0; i < cities.Length; i++)
            {
                vertexList.Add(new Vertex(i));
            }
            for (int j = 0; j < cities.Length - 1; j++)
            {
                neighbors = graph.GetNeighbors(vertexList[j]);
                //if (neighbors.ContainsKey(vertexList[j + 1]))
                if (neighbors.Keys.ToString() == cities[j])
                {
                    cost += neighbors[cities[j + 1]];
                }
                else
                {
                    return output;
                }
            }
            return output;
        }
        */
        
    }
}
