using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeBalanced.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Method for getting the maximum height in a tree.
        /// Similar as Find Hieght challenge but returning each depth seperatly.
        /// </summary>
        /// <param name="node"></param>
        /// <returns>integer</returns>
        public int CalculateBinaryTreeHeight(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                //int leftDepth = CalculateBinaryTreeHeight(node.LeftChild);
                //int rightDepth = CalculateBinaryTreeHeight(node.RightChild);
                return 1 + Math.Max(CalculateBinaryTreeHeight(node.LeftChild), CalculateBinaryTreeHeight(node.RightChild));
            }
        }
        
        /// <summary>
        /// This is where the two heights are compared.
        /// </summary>
        /// <param name="node"></param>
        /// <returns>boolen</returns>
        public bool IsBinaryTreeBalanced(Node node)
        {
            int leftDepth = CalculateBinaryTreeHeight(node.LeftChild);
            int rightDepth = CalculateBinaryTreeHeight(node.RightChild);
            if (Math.Abs(leftDepth - rightDepth) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
