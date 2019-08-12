using System;
namespace ModifyBST.Classes
{
    public class BSTmodifing
    {
        public void addAllValuesGreater(Node node, int sum)
        {
            if (node == null)
            {
                return;
            }
            addAllValuesGreater(node.RightChild, sum);

            sum += node.Value;
            node.Value = sum;

            addAllValuesGreater(node.LeftChild, sum);
        }

        public void runModifyBST(Node root)
        {
            int sum = 0;
            addAllValuesGreater(root, sum);
        }
    }
}
