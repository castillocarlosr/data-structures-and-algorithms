using System;
using Xunit;
using Graph.Classes;
using Graph;
using System.Collections.Generic;

namespace GraphsTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Test for adding Edges with their connecting Nodes/Vertices.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        /// <param name="weight"></param>
        [Theory]
        [InlineData("Apple", "Banana", 10)]
        [InlineData("Dog", "Cats", 22)]
        [InlineData("Chocolate", "Candy", 33)]
        public void TestAddEdgeandNodes(object to, object from, int weight)
        {
            List<object> listTest = new List<object>();

            Graph.Classes.Graph graph = new Graph.Classes.Graph(listTest);
            graph.AddEdge(to, from, weight);

            Dictionary<object, int> toNeighbor = graph.GetNeighbors(to);
            Dictionary<object, int> fromNeighbor = graph.GetNeighbors(from);

            Assert.True(toNeighbor.ContainsValue(weight) && fromNeighbor.ContainsValue(weight));
        }

        /// <summary>
        /// Test to get all node or known as vertices
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <param name="three"></param>
        [Theory]
        [InlineData("Apple", "Orange", 4)]
        [InlineData("Dog", "Cat", "squirrel")]
        [InlineData(43, "Orange", 55)]
        public void GetAllNodes(object one, object two, object three)
        {
            List<object> listTest = new List<object>();

            listTest.Add(one);
            listTest.Add(two);
            listTest.Add(three);
            Graph.Classes.Graph graphTest = new Graph.Classes.Graph(listTest);
            List<Vertex> vertices = graphTest.GetNodes();

            //Assert.Equal(graphTest.GetNodes()[two].Value, one);
            Assert.True(listTest[0] == vertices[0].Value && listTest[1] == vertices[1].Value && listTest[2] == vertices[2].Value);
        }
        
        /// <summary>
        /// Test to get all connecting Neighbors
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        /// <param name="weight"></param>
        [Theory]
        [InlineData("Apple", "Banana", 10)]
        [InlineData("Dog", "Cats", 22)]
        [InlineData("Chocolate", "Candy", 33)]
        public void GetNeighbots(object to, object from, int weight)
        {
            List<object> listTest = new List<object>();

            Graph.Classes.Graph graph = new Graph.Classes.Graph(listTest);
            graph.AddEdge(to, from, weight);

            Dictionary<object, int> toNeighbor = graph.GetNeighbors(to);
            Dictionary<object, int> fromNeighbor = graph.GetNeighbors(from);

            Assert.True(toNeighbor.ContainsValue(weight) && fromNeighbor.ContainsValue(weight));
        }

        /// <summary>
        /// Get Size of graph including empty graph on the bottom.
        /// </summary>
        [Fact]
        public void GetSizeOne()
        {
            List<object> listTest = new List<object>();

            Graph.Classes.Graph graph = new Graph.Classes.Graph(listTest);
            graph.AddEdge("Apple", "Banana", 10);
            graph.Size();

            Assert.Equal(2, graph.Size());
        }
        [Fact]
        public void GetSizeTwo()
        {
            List<object> listTest = new List<object>();

            listTest.Add("Dog");
            Graph.Classes.Graph graph = new Graph.Classes.Graph(listTest);
            graph.Size();

            Assert.Equal(1, graph.Size());
        }
        [Fact]
        public void GetSizeThree()
        {
            List<object> listTest = new List<object>();

            listTest.Add("Dog");
            listTest.Add("Cat");
            listTest.Add("Chocolate");
            listTest.Add("Banana");
            Graph.Classes.Graph graph = new Graph.Classes.Graph(listTest);
            graph.AddEdge("Peach", "Orange", 10);
            graph.Size();

            Assert.Equal(6, graph.Size());
        }

        [Fact]
        public void GetSizeEmpty()
        {
            List<object> listTest = new List<object>();

            Graph.Classes.Graph graph = new Graph.Classes.Graph(listTest);
            graph.Size();

            Assert.Equal(0, graph.Size());
        }
    }
}
