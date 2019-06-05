using System;
using ClosestNodeBinaryTree.Classes;

namespace ClosestNodeBinaryTree.Classes
{
    public class ClosestInTree
    {
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
        }
    }
}
