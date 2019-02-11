using BinaryTreeBalanced.Classes;
using System;

namespace BinaryTreeBalanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Balanced Tree");
            Console.WriteLine("");

            ThisTreeIsBalanced();
            NotBalanced();
            Console.ReadLine();
        }

        public static void ThisTreeIsBalanced()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);
            tree.Root.RightChild.LeftChild = new Node(7);
            Console.WriteLine($"This tree is balanced: {tree.IsBinaryTreeBalanced(tree.Root)}");
        }

        public static void NotBalanced()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);
            tree.Root.RightChild.RightChild.RightChild = new Node(7);
            tree.Root.RightChild.RightChild.RightChild.RightChild = new Node(8);
            Console.WriteLine($"This tree is NOT balanced.  Thus  shown as : {tree.IsBinaryTreeBalanced(tree.Root)}");
        }
    }
}
