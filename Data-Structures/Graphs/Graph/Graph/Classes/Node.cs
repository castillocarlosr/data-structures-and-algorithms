using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Node
    {
        /// <summary>
        /// Node set to the value given to
        /// </summary>
        public object Value { get; set; }

        public Node Next { get; set; }

        public Node Previous { get; set; }

        /// <summary>
        /// for instantiating Node
        /// </summary>
        /// <param name="value">int user input</param>
        public Node(object value)
        {
            Value = value;
        }
    }
}
