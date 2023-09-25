// See https://aka.ms/new-console-template for more information
using System;

namespace BST_RangeInclusive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting tree");
            Console.WriteLine("---5---");
            Console.WriteLine("-3---8-");
            Console.WriteLine("2-4-6-8");
            TreeNode tree1 = new TreeNode(5);
            tree1.left = new TreeNode(3);
            tree1.left.left = new TreeNode(2);
            tree1.left.right = new TreeNode(4);
            tree1.right = new TreeNode(8);
            tree1.right.left = new TreeNode(6);
            tree1.right.right = new TreeNode(10);
            int[] range = new int[]{4,9};
            int low = range[0];
            int high = range[1];
            
            BST solution = new BST();
            int sum = solution.RangeSum(tree1, low, high);
            Console.WriteLine("Sum of elements within the range [" + low + ", " + high + "]: " + sum);
        }
        public class TreeNode
        {
            public int data;
            public TreeNode? left;
            public TreeNode? right;
            public TreeNode(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }

        public class BST
        {
            public int RangeSum(TreeNode head, int lower, int upper)
            {
                TreeNode current = head;
                int answer = 0;
                if(current == null) return answer;

                if(current.data >= lower && current.data <= upper)
                {
                    answer += current.data;
                }
                if(current.data > lower)
                {
                    answer += RangeSum(current.left, lower, upper);
                }
                if(current.data < upper)
                {
                    answer += RangeSum(current.right, lower, upper);
                }
                return answer;
            }
        }
    }
}

