using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Edge
    {
        public Vertex To { get; set; }

        public Vertex From { get; set; }

        public int Weight { get; set; }

        public Edge(Vertex to, Vertex from, int weight)
        {
            To = to;
            From = from;
            Weight = weight;
        }
    }
}
