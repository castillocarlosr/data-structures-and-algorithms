using System;
using System.Collections.Generic;
using StacksAndQueue.Classes;
using Trees.Classes;

namespace BreadthFirstTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Breadth First Traversal");
            Trees.Classes.Node root = new Trees.Classes.Node(2);
            Trees.Classes.Node nodeTwo = new Trees.Classes.Node(4);
            Trees.Classes.Node nodeThree = new Trees.Classes.Node(6);
            Trees.Classes.Node nodeFour = new Trees.Classes.Node(8);
            Trees.Classes.Node nodeFive = new Trees.Classes.Node(10);
            Trees.Classes.Node nodeSix = new Trees.Classes.Node(12);
            Trees.Classes.Node nodeSeven = new Trees.Classes.Node(14);
            Trees.Classes.Node nodeEight = new Trees.Classes.Node(16);
            Trees.Classes.Node nodeNine = new Trees.Classes.Node(18);
            Trees.Classes.Node nodeTen = new Trees.Classes.Node(21);
            BinaryTree breadthTree = new BinaryTree(root);
            breadthTree.Root.LeftChild = nodeTwo;
            breadthTree.Root.RightChild = nodeThree;
            breadthTree.Root.LeftChild.LeftChild = nodeFour;
            breadthTree.Root.LeftChild.RightChild = nodeFive;
            breadthTree.Root.RightChild.LeftChild = nodeSix;
            breadthTree.Root.RightChild.RightChild = nodeSeven;
            breadthTree.Root.LeftChild.RightChild.LeftChild = nodeEight;
            breadthTree.Root.LeftChild.RightChild.RightChild = nodeNine;
            breadthTree.Root.RightChild.RightChild.RightChild = nodeTen;

            BreadthFirst(root);
            Console.ReadLine();
        }

        /// <summary>
        /// List is used for testing xUnit only.
        /// Takes a binary tree through breadthFirst approach.
        /// </summary>
        /// <param name="Root">Node root</param>
        /// <returns>values in breadthFirst order</returns>
        public static List<int> BreadthFirst(Trees.Classes.Node Root)
        {
            List<int> testList = new List<int>();
            Queue<Trees.Classes.Node> breadthQueue = new Queue<Trees.Classes.Node>();
            breadthQueue.Enqueue(Root);

            try
            {
                while (breadthQueue.Peek() != null)
                {
                    //BinaryTree front = new BinaryTree();
                    Trees.Classes.Node front = breadthQueue.Dequeue();
                    Console.WriteLine($"{front.Value}");
                    testList.Add(front.Value);
                    if (front.LeftChild != null)
                    {
                        breadthQueue.Enqueue(front.LeftChild);
                    }
                    if (front.RightChild != null)
                    {
                        breadthQueue.Enqueue(front.RightChild);
                    }
                }
                return testList;
            }
            catch (Exception error)
            {

                Console.WriteLine($"Now the Queue is empty: {error.Message}");
            }
            return testList;

        }     
    }
}
