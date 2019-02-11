using System;
using System.Collections.Generic;
using System.Text;

namespace LeafsBoolTwoTrees.Classes
{
    public class Node
    {
        /// <summary>
        /// Setting the value as a string which can be pathway for directory.
        /// </summary>
        public string FolderName { get; set; }

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="folderName"></param>
        public Node(string folderName)
        {
            FolderName = folderName;

            LeftChild = RightChild = null;
        }
    }
}
