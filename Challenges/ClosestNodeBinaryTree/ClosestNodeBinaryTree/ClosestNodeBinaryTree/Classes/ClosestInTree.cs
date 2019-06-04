using System;
using ClosestNodeBinaryTree.Classes;

namespace ClosestNodeBinaryTree.Classes
{
    public class ClosestInTree
    {
        /*
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
        public int ClosestNumber(Node nodeInput, int numberInput)
        {
            if(nodeInput.Value == numberInput)
            {
                return nodeInput.Value;
            }

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
        }
    }
}
