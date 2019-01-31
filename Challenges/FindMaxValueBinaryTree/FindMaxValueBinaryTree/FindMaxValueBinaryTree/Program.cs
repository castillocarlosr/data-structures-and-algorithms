using System;
using FindMaxValueBinaryTree.Classes;

namespace FindMaxValueBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Max Value Binary Tree");

            Node root = new Node(3);
            Node nodeTwo = new Node(4);
            Node nodeThree = new Node(6);
            Node nodeFour = new Node(8);
            Node nodeFive = new Node(555);
            Node nodeSix = new Node(12);
            Node nodeSeven = new Node(14);
            Node nodeEight = new Node(16);
            Node nodeNine = new Node(18);
            Node nodeTen = new Node(21);
            BinaryTree tree = new BinaryTree(root);
            tree.Root.LeftChild = nodeTwo;
            tree.Root.RightChild = nodeThree;
            tree.Root.LeftChild.LeftChild = nodeFour;
            tree.Root.LeftChild.RightChild = nodeFive;
            tree.Root.RightChild.LeftChild = nodeSix;
            tree.Root.RightChild.RightChild = nodeSeven;
            tree.Root.LeftChild.RightChild.LeftChild = nodeEight;
            tree.Root.LeftChild.RightChild.RightChild = nodeNine;
            tree.Root.RightChild.RightChild.RightChild = nodeTen;

            Console.WriteLine($"Max Value: {FindMaxValue(root)}");
            //FindMaxValue(root);
            Console.ReadLine();
        }

        public static int FindMaxValue(Node root)
        {
            Stacks stack = new Stacks();
            stack.Push(root);

            while (stack.Peek() != null)
            {
                if (root.LeftChild != null)
                {
                    if(root.LeftChild.Value > stack.Top.Value)
                    {
                        stack.Pop();
                        stack.Push(root.LeftChild);
                        FindMaxValue(root.LeftChild);
                    }                      
                }
                if (root.RightChild != null)
                {
                    if(root.RightChild.Value > stack.Top.Value)
                    {
                        stack.Pop();
                        stack.Push(root.RightChild);
                        FindMaxValue(root.RightChild);
                    } 
                }
                return stack.Peek().Value;
            }
            //Console.WriteLine($"Max: {stack.Peek().Value}");
            return stack.Peek().Value;
        }
    }
}
