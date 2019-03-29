using System;
using System.Collections.Generic;
using HeightBinaryTree.Classes;

namespace HeightBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max Height of Binary Tree");
            Console.WriteLine("");

            //FindMaxHeight();
            //IsLeafPathWeight();
            ClosestValue();
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

        public static void IsLeafPathWeight()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);
            tree.Root.RightChild.LeftChild = new Node(7);
            tree.Root.RightChild.RightChild.RightChild = new Node(8);
            List<int> result = new List<int>();

            //Console.WriteLine($"should be true:  {tree.RootToLeafsSum(tree.Root, 18, result)}");
            //Console.WriteLine($"should be true:  {tree.RootToLeafsSum(tree.Root, 10, result)}");
            Console.WriteLine($"should be true:  {tree.TreeInt(tree.Root, 7)}");
            Console.WriteLine($"should be false:  {tree.TreeInt(tree.Root, 3)}");
            Console.WriteLine($"should be false:  {tree.TreeInt(tree.Root, 2)}");
            Console.WriteLine($"should be true:  {tree.TreeInt(tree.Root, 18)}");
        }

        public static void ClosestValue()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(55);
            tree.Root.LeftChild = new Node(44);
            tree.Root.RightChild = new Node(70);
            tree.Root.LeftChild.RightChild = new Node(50);
            tree.Root.LeftChild.LeftChild = new Node(22);
            tree.Root.RightChild.RightChild = new Node(75);
            tree.Root.RightChild.LeftChild = new Node(60);
            //tree.Root.RightChild.RightChild.RightChild = new Node(88);
            

            Console.WriteLine($"should be 60:  {tree.Closest(tree.Root, 60)}");
            //Console.WriteLine($"should be 88:  {tree.Closest(tree.Root, 82)}");
        }
    }
}
