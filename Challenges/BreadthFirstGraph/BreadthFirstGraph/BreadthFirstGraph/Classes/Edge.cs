using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstGraph.Classes
{
    public class Edge
    {
        public object To { get; set; }

        public object From { get; set; }

        public int Weight { get; set; }

        public Edge(Vertex to, Vertex from, int weight)
        {
            To = to;
            From = from;
            Weight = weight;
        }
    }
}
