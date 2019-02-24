using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Vertex
    {

        public object Value { get; set; }

        public bool Visited { get; set; }

        //public Vertex Next { get; set; }

        //public Vertex Previous { get; set; }
        public Dictionary<Vertex, int> AdjecentVertex { get; set; }

        public Vertex(object value)
        {
            Value = value;
            Visited = false;
            AdjecentVertex = new Dictionary<Vertex, int>();
        }
    }
}
