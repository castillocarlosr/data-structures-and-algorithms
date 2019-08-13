using System;
namespace ModifyBST.Classes
{
    public class BSTmodifing
    {
        public class Sum
        {
            private readonly BSTmodifing outerInstance;

            public Sum(BSTmodifing outerInstance)
            {
                this.outerInstance = outerInstance;
            }

            public int sum = 0;
        }

        public virtual void addAllValuesGreater(Node node, Sum sumAdd)
        {
            if (node == null) return;

            this.addAllValuesGreater(node.RightChild, sumAdd);

            sumAdd.sum = sumAdd.sum + node.Value;
            //sumAdd += node.Value;
            node.Value = sumAdd.sum;

            this.addAllValuesGreater(node.LeftChild, sumAdd);
        }

        public virtual void modifySum(Node node)
        {
            Sum sumAdd = new Sum(this);
            this.addAllValuesGreater(node, sumAdd);
        }
    }
}
