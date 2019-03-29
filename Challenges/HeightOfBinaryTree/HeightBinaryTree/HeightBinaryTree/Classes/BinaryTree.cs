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

        public bool RootToLeafsSum(Node root, int sum, List<int> result)
        {
            if(root == null)
            {
                return false;
            }
            if(root.LeftChild == null && root.RightChild == null)
            {
                if(root.Value == sum)
                {
                    result.Add(root.Value);
                    return true;
                }
            }
            if(RootToLeafsSum(root.LeftChild, sum-root.Value, result))
            {
                result.Add(root.Value);
                return true;
            }
            if (RootToLeafsSum(root.RightChild, sum - root.Value, result))
            {
                result.Add(root.Value);
                return true;
            }
            return false;
        }

        //public int difference;
        public int output;
        public int Closest(Node node, int outside)
        {
            int difference = Math.Abs(node.Value - outside);
            if (node == null)
            {
                return -1;
            }
            if (outside == node.Value)
            {
                return node.Value;
            }
            if(difference > Math.Abs(node.Value - outside))
            {
                difference = Math.Abs(node.Value - outside);
                output = node.Value;
            }
            if (outside < node.Value && node.LeftChild != null)
            {
                Closest(node.LeftChild, outside);
            }
            if (outside > node.Value && node.RightChild != null)
            {
                Closest(node.RightChild, outside);
            }
            return output;
        }

        public bool TreeInt(Node node, int outside)
        {
            
            if (node == null)
            {
                return false;
            }
            else
            {
                bool output = false;
                int inside = outside - node.Value;
                if(node.LeftChild == null && node.RightChild == null)
                {
                    if(inside == 0)
                    {
                        //return true;
                        output = true;
                    }
                }
                if(node.LeftChild != null)
                {
                    output = output || TreeInt(node.LeftChild, inside);
                }
                if(node.RightChild != null)
                {
                    output = output || TreeInt(node.RightChild, inside);
                }
                return output;
            }
        }
    }
}
