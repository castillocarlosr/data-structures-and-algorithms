using System;
using System.Collections.Generic;
using System.Text;

namespace HeightBinaryTree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Method for getting the maximum height in a tree.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int CalculateBinaryTreeHeight(Node node)
        {
            if(node == null)
            {
                return -1;
            }
            if(node.LeftChild == null && node.RightChild == null)
            {
                return 0;
            }
            else
            {
                int leftDepth = CalculateBinaryTreeHeight(node.LeftChild);
                int rightDepth = CalculateBinaryTreeHeight(node.RightChild);
                if(leftDepth > rightDepth)
                {
                    return (leftDepth + 1);
                }
                else
                {
                    return (rightDepth + 1);
                }
            }
        }

        /// <summary>
        /// Method for counting the number of levels in a tree.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Levels(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.LeftChild == null && node.RightChild == null)
            {
                return 1;
            }
            else
            {
                int leftDepth = Levels(node.LeftChild);
                int rightDepth = Levels(node.RightChild);
                if (leftDepth > rightDepth)
                {
                    return (leftDepth + 1);
                }
                else
                {
                    return (rightDepth + 1);
                }
            }
        }
    }
}
