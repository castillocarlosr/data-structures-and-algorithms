using System;
using System.Collections.Generic;
using System.Text;

namespace CyclicLList.Classes
{
    public class Node
    {
        /// <summary>
        /// This is the value that goes in the node
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// This is the pointer to the next node
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Constructor for the nodes
        /// </summary>
        /// <param name="value">was int.  I changed it to object</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
