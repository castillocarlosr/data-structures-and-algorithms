using System;
namespace ClosestNodeBinaryTree.Classes
{
    public class Node
    {
        /// <summary>
        /// Setting the value of the new node.  Left and right null upon inital creation.
        /// </summary>
        public int Value { get; set; }

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }

        public Node(int value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
    }
}
