using System;
using System.Collections.Generic;
using System.Text;

namespace IsAncestor.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        

        public bool IsAncestor(Node a, Node b, Node root)
        {
            if(root == null)
            {
                return false;
            }
            else
            {
                while(root.LeftChild != null)
                {
                    if(root.LeftChild == a)
                    {

                    }
                }
            }
        }
    }
}
