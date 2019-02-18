using System;
using Trees.Classes;
using System.Collections.Generic;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Trees");

            TreeCarlos();
            Console.ReadLine();
        }

        public static void TreeCarlos()
        {
            Node nodeOne = new Node(1);
            Node nodeTwo = new Node(2);
            Node nodeThree = new Node(3);
            Node nodeFour = new Node(4);
            Node nodeFive = new Node(5);
            Node nodeSix = new Node(6);
            Node nodeSeven = new Node(7);
            Node nodeEight = new Node(8);
            Node nodeNine = new Node(9);
            Node nodeTen = new Node(10);

            BinaryTree binaryTree = new BinaryTree(nodeOne);
            binaryTree.Root.LeftChild = nodeTwo;
            binaryTree.Root.RightChild = nodeThree;
            binaryTree.Root.LeftChild.LeftChild = nodeFour;
            binaryTree.Root.LeftChild.RightChild = nodeFive;
            binaryTree.Root.RightChild.LeftChild = nodeSix;
            binaryTree.Root.RightChild.RightChild = nodeSeven;
            
            Console.WriteLine(" ");
            Console.WriteLine("==========PreOrder=========");
            List<int> preOrder = binaryTree.PreOrder(binaryTree.Root);
            foreach (var item in preOrder)
            {
                Console.Write(item);
            }
            
            binaryTree.values.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("==========InOrder=========");
            List<int> inOrder = binaryTree.InOrder(binaryTree.Root);
            foreach (var item in inOrder)
            {
                Console.Write(item);
            }

            binaryTree.values.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("==========PostOrder=========");
            List<int> postOrder = binaryTree.PostOrder(binaryTree.Root);
            foreach (var item in postOrder)
            {
                Console.Write(item);
            }

            binaryTree.values.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("==========Add Binary Search Tree=========");
            Console.WriteLine("Added 2, 3, 4, 6, 7, 8, 10");
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(nodeSix, 3);
            binarySearchTree.Add(nodeSix, 2);
            binarySearchTree.Add(nodeSix, 4);
            binarySearchTree.Add(nodeSix, 8);
            binarySearchTree.Add(nodeSix, 7);
            binarySearchTree.Add(nodeSix, 10);
            Console.WriteLine("==========Contains Binary Search Tree=========");
            Console.WriteLine($"Contains 7: {binarySearchTree.Contains(nodeSix, 4)}");
            Console.WriteLine($"Contains 52: {binarySearchTree.Contains(nodeSix, 52)}");
        }
    }
}
