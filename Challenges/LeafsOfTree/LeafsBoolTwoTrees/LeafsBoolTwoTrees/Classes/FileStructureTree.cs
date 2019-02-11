using System;
using System.Collections.Generic;
using System.Text;

namespace LeafsBoolTwoTrees.Classes
{
    public class FileStructureTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// This is counting the number of leafs in a tree.  Increase one when child is reached.
        /// </summary>
        /// <param name="node"></param>
        /// <returns>integer</returns>
        public int LeafCount(Node node)
        {
            if(node == null)
            {
                return 0;
            }
            if(node.LeftChild == null && node.RightChild == null)
            {
                return 1;
            }
            else
            {
                return LeafCount(node.LeftChild) + LeafCount(node.RightChild);
            }
        }

        /// <summary>
        /// Recursion for counting the tree.
        /// </summary>
        public int TotalLeafsCount
        {
            get
            {
                return LeafCount(Root);
            }
        }
    }
}
