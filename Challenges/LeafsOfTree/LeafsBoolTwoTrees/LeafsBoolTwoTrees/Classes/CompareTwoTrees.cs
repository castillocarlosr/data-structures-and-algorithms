using System;
using System.Collections.Generic;
using System.Text;

namespace LeafsBoolTwoTrees.Classes
{
    public class CompareTwoTrees
    {
        /// <summary>
        /// Takes two different trees and uses the count of leafs to compare.
        /// </summary>
        /// <param name="treeOne"></param>
        /// <param name="treeTwo"></param>
        /// <returns>boolean</returns>
        public bool LeafsInTwoTrees(FileStructureTree treeOne, FileStructureTree treeTwo)
        {
            int countTreeOne = treeOne.TotalLeafsCount;
            int countTreeTwo = treeTwo.TotalLeafsCount;

            if(countTreeOne == countTreeTwo)
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
