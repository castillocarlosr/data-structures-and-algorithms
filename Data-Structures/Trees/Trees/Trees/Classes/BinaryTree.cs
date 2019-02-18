using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public List<int> values = new List<int>();
        /// <summary>
        /// Construcotr for a given Root.
        /// </summary>
        /// <param name="node"></param>
        public BinaryTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// Constructor for an empty tree
        /// </summary>
        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// Method to traverse through PreOrder.  Root, Left, Right
        /// </summary>
        /// <param name="node"></param>
        /// <returns>value</returns>
        public List<int> PreOrder(Node node)
        {
            values.Add(node.Value);
            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }
            if(node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
            return values;
        }

        /// <summary>
        /// Method to tracese through InOrder.  Left, Root, Right
        /// </summary>
        /// <param name="node"></param>
        /// <returns>value</returns>
        public List<int> InOrder(Node node)
        {
            if(node != null)
            {
                InOrder(node.LeftChild);
                values.Add(node.Value);
                InOrder(node.RightChild);
            }
            return values;
        }

        /// <summary>
        /// Methos to traverse through Post order.  Left, Right, Root.
        /// </summary>
        /// <param name="node"></param>
        /// <returns>value</returns>
        public List<int> PostOrder(Node node)
        {
            if(node != null)
            {
                PostOrder(node.LeftChild);
                PostOrder(node.RightChild);
                values.Add(node.Value);
            }
            return values;
        }
    }
}
