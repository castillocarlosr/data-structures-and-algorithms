using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnilmalShelter.Classes
{
    public class Node
    {
        /// <summary>
        /// Node created and set to accept strings instead of intigers values.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Node references the next node
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// for instantiating Node
        /// </summary>
        /// <param name="value">int user input</param>
        public Node(string value)
        {
            Value = value;
        }
    }
}
