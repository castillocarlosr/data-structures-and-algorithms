using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graph
    {

        /// <summary>
        /// Building an Adjacency list.
        /// </summary>
        public List<Vertex> Vertices { get; set; }

        public List<Edge> Edges { get; set; }

        public Graph()
        {

        }

        public Graph(List<object> list)
        {
            Vertices = new List<Vertex>();
            foreach (object item in list)
            {
                Vertices.Add(new Vertex(item));
            }
        }

        public void AddEdge(object from, object to, int weight)
        {
            //Edges.Add(new Edge(from, to, weight));
            Vertex fromPointer = Vertices.Find(f => f.Value == (object)from);
            if(fromPointer == null)
            {
                fromPointer = new Vertex(from);
                Vertices.Add(fromPointer);
            }
            Vertex toPointer = Vertices.Find(t => t.Value == (object)to);
            if(toPointer == null)
            {
                toPointer = new Vertex(to);
                Vertices.Add(toPointer);
            }

            fromPointer.AdjecentVertex.Add(toPointer, weight);
            toPointer.AdjecentVertex.Add(fromPointer, weight);
        }

        public void AddNode(Vertex vertex)
        {
            //To DO
        }

        public List<Vertex> GetNodes()
        {
            return Vertices;
        }

        public Dictionary<object, int> GetNeighbors(object value)
        {
            Vertex vertex = Vertices.Find(v => v.Value == value);

            if(vertex == null)
            {
                return null;
            }

            Dictionary<object, int> neighbors = new Dictionary<object, int>();
            foreach (var item in vertex.AdjecentVertex)
            {
                var key = item.Key;
                neighbors.Add((object)item.Value, vertex.AdjecentVertex[key]);
            }
            return neighbors;
        }

        public int Size()
        {
            return Vertices.Count;
        }
    }
}
