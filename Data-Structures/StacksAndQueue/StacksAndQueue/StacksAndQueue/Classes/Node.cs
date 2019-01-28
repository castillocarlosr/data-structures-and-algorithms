using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueue.Classes;

namespace StacksAndQueue.Classes
{
    public class Node
    {
        /// <summary>
        /// Node set to the value given to
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Node references the next node
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// for instantiating Node
        /// </summary>
        /// <param name="value">int user input</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
