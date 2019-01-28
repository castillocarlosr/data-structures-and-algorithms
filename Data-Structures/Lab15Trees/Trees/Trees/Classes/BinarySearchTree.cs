using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Construcctor for Binary Search tree.  Empty or node.
        /// </summary>
        public BinarySearchTree()
        {

        }

        public BinarySearchTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// Method Node to add to Binary search tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Add(Node root, int value)
        {
            if(root == null)
            {
                root = new Node(value);
                return root;
            }
            if(value < root.Value)
            {
                root.LeftChild = Add(root.LeftChild, value);
            }
            else
            {
                root.RightChild = Add(root.RightChild, value);
            }
            return root;
        }

        /// <summary>
        /// Method to search for a node value
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns>boolean</returns>
        public bool Contains(Node root, int value)
        {
            while(root != null)
            {
                if(value == root.Value)
                {
                    return true;
                }
                if(value < root.Value)
                {
                    root = root.LeftChild;
                }
                if (value > root.Value)
                {
                    root = root.RightChild;
                }
            }
            return false;
        }
    }
}
