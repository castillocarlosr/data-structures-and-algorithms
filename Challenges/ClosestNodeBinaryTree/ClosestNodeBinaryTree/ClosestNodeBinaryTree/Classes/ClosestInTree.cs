using System;
namespace ClosestNodeBinaryTree.Classes
{
    public class ClosestInTree
    {
        public Node ClosestNumber(Node nodeInput, int numberInput)
        {
            int difference = Math.Abs(nodeInput.Value - numberInput);
            if(nodeInput != null)
            {
                if(Math.Abs(nodeInput.Value-numberInput) < difference)
                {
                    difference = Math.Abs(nodeInput.Value - numberInput);
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
        }
    }
}
