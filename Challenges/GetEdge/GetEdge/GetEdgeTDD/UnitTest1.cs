using GetEdge.Classes;
using GetEdge;
using System;
using System.Collections.Generic;
using Xunit;

namespace GetEdgeTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TwoCitiesGoodConnection()
        {
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

            string[] cities = new string[] { "Arendelle", "Pandora" };

            Tuple<bool, int> expected = new Tuple<bool, int>(true, 150);

            Assert.Equal(expected, Program.GetEdge(graph, cities));
        }

        [Fact]
        public void ThreeCitiesGoodConnection()
        {
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

            string[] cities = new string[] { "Pandora", "Metroville", "Naboo" };

            Tuple<bool, int> expected = new Tuple<bool, int>(true, 187);

            Assert.Equal(expected, Program.GetEdge(graph, cities));
        }

        [Fact]
        public void FalseBadConnection()
        {
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

            string[] cities = new string[] { "Pandora", "Narnia" };

            Tuple<bool, int> expected = new Tuple<bool, int>(false, 0);

            Assert.Equal(expected, Program.GetEdge(graph, cities));
        }
    }
}
