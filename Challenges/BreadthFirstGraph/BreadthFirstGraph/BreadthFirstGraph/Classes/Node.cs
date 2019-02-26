using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstGraph.Classes
{
    public class Node
    {

        public object Value { get; set; }

        //public bool Visited { get; set; }

        //public Node Next { get; set; }

        //public Node Previous { get; set; }

        //public List<Node> Children { get; set; }

        public Node(object value)

        {

            Value = value;

        }
    }
}
