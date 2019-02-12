using System;
using HeightBinaryTree.Classes;

namespace HeightBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max Height of Binary Tree");
            Console.WriteLine("");

            FindMaxHeight();
            Console.ReadLine();
        }

        public static void FindMaxHeight()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);

            Console.WriteLine($"Height of tree is: {tree.CalculateBinaryTreeHeight(tree.Root)}");
            Console.WriteLine($"Levels of tree is: {tree.Levels(tree.Root)}");
        }
    }
}
