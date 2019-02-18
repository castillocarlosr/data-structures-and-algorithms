using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    /// <summary>
    /// New Node class so I don't have to change my previous Node class challenge.
    /// </summary>
    public class Node
    {
        public object Value { get; set; }

        public Node Next { get; set; }

        public object Key { get; set; }

        public Node(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
