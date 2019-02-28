using DepthFirstGraph;
using DepthFirstGraph.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace DepthFirstGraphTDD
{
    public class UnitTest1
    {
        [Fact]
        public void PreOrderOne()
        {
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

            List<string> expected = new List<string> { "A, B, C, D, E, F, G" };
            bool visited = false;

            Assert.Equal(expected, Program.DepthFirst(seven, visited));
        }

        [Fact]
        public void PreOrderTwo()
        {
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

            List<string> expected = new List<string> { "G, F, H, E, D, C, B, A" };
            bool visited = false;

            Assert.Equal(expected, Program.DepthFirst(five, visited));
        }

        [Fact]
        public void PreOrderThree()
        {
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

            List<string> expected = new List<string> { "A, C, B, D, E, G, F" };
            bool visited = false;

            Assert.Equal(expected, Program.DepthFirst(four, visited));
        }
    }
}
