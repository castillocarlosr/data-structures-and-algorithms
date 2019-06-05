using System;
using ClosestNodeBinaryTree.Classes;

namespace ClosestNodeBinaryTree.Classes
{
    public class ClosestInTree
    {
        /*
        /// <summary>
        /// This is for a binary tree.  NOT a binary search tree.
        /// </summary>       
        public Node ClosestNumber(Node nodeInput, int numberInput)
        {
            //int difference = Math.Abs(nodeInput.Value - numberInput);
            int difference = 999999999;
            Node output = nodeInput;
            if(nodeInput != null)
            {
                if(Math.Abs(nodeInput.Value-numberInput) < difference)
                {
                    difference = Math.Abs(nodeInput.Value - numberInput);
                    output = nodeInput;
                }
                if(nodeInput.LeftChild != null)
                {
                    ClosestNumber(nodeInput.LeftChild, numberInput);
                }
                if(nodeInput.RightChild != null)
                {
                    ClosestNumber(nodeInput.RightChild, numberInput);
                }
            }
            return output;
        }
        */

        /// <summary>
        /// This is for a binary search tree
        /// </summary>
        /// <returns>The number.</returns>
        /// <param name="nodeInput">Node input.</param>
        /// <param name="numberInput">Number input.</param>
        public int ClosestNumber(Node nodeInput, int numberInput)
        {
            if(nodeInput.Value == numberInput)
            {
                return nodeInput.Value;
            }

            if(nodeInput.Value > numberInput)
            {
                if(nodeInput.LeftChild == null)
                {
                    return nodeInput.Value;
                }
                int closest = ClosestNumber(nodeInput.LeftChild, numberInput);
                if (Math.Abs(closest - numberInput) > Math.Abs(nodeInput.Value - numberInput))
                {
                    return nodeInput.Value;
                }
                return closest;
            }
            else
            {
                if(nodeInput.RightChild == null)
                {
                    return nodeInput.Value;
                }
                int closest = ClosestNumber(nodeInput.RightChild, numberInput);
                if (Math.Abs(closest - numberInput) > Math.Abs(nodeInput.Value - numberInput))
                {
                    return nodeInput.Value;
                }
                return closest;
            }

            /*
            int difference = Math.Abs(nodeInput.Value - numberInput);
            int output = nodeInput.Value;
            if (Math.Abs(nodeInput.Value - numberInput) < difference)
            {
                output = nodeInput.Value;
                difference = Math.Abs(nodeInput.Value - numberInput);
            }

            if (nodeInput != null)
            {
                

                if (nodeInput.LeftChild != null)
                {
                    ClosestNumber(nodeInput.LeftChild, numberInput);
                }
                if (nodeInput.RightChild != null)
                {
                    ClosestNumber(nodeInput.RightChild, numberInput);
                }
            }
            return output;
            */           
        }
    }
}
