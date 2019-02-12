using System;
using System.Collections.Generic;
using System.Text;

namespace IsAncestor.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public int TraverseThroughTreeLeft(Node node)
        {
            int nextValue = TraverseThroughTreeLeft(node.LeftChild);
            return nextValue;
        }
        public int TraverseThroughTreeRight(Node node)
        {
            int nextValue = TraverseThroughTreeRight(node.RightChild);
            return nextValue;
        }

        

        public bool IsAncestor(int a, int b, Node node)
        {
            if(node == null)
            {
                return false;
            }
            /*
            if(node.Value == a || node.Value == b)
            {
                 left = IsAncestor(a, b, node.LeftChild);

            }
            */
            if(node.Value == a)
            {
                return true;
            }
            if (IsAncestor(a, b, node.LeftChild) || IsAncestor(a, b, node.RightChild))
            {
                //if (node.Value == b)
                //{
                    return true;
                //}
            }
            
            return false;
        }
    }
}
