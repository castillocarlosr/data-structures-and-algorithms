using System;
using Trees.Classes;
using System.Collections.Generic;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fizz Buzz Tree!");
            Node root = new Node(15);
            Node nodeTwo = new Node(3);
            Node nodeThree = new Node(4);
            Node nodeFour = new Node(5);
            Node nodeFive = new Node(9);
            Node nodeSix = new Node(2);
            Node nodeSeven = new Node(20);
            Node nodeEight = new Node(30);
            Node nodeNine = new Node(32);
            BinaryTree fizzBuzz = new BinaryTree(root);
            fizzBuzz.Root.LeftChild = nodeTwo;
            fizzBuzz.Root.RightChild = nodeThree;
            fizzBuzz.Root.LeftChild.LeftChild = nodeFour;
            fizzBuzz.Root.LeftChild.RightChild = nodeFive;
            fizzBuzz.Root.RightChild.LeftChild = nodeSix;
            fizzBuzz.Root.RightChild.RightChild = nodeSeven;
            fizzBuzz.Root.LeftChild.LeftChild.LeftChild = nodeEight;
            fizzBuzz.Root.RightChild.RightChild.RightChild = nodeNine;
            FizzBuzzTree(fizzBuzz);
            Console.ReadLine();
        }

        public static void FizzBuzzTree(BinaryTree tree)
        {
            TraversePreOrder(tree.Root);
        }

        public static List<string> TraversePreOrder(Node node)
        {
            List<string> listTree = new List<string>();
            if (node.Value % 15 == 0)
            {
                listTree.Add("FizzBuzz");
                Console.WriteLine($"{node.Value}: FizzBuzz");
            }
            else if (node.Value % 5 == 0)
            {
                listTree.Add("Buzz");
                Console.WriteLine($"{ node.Value}: Buzz");
            }
            else if (node.Value % 3 == 0)
            {
                listTree.Add("Fizz");
                Console.WriteLine($"{ node.Value}: Fizz");
            }
            else
            {
                listTree.Add($"{node.Value}");
                Console.WriteLine($"{node.Value}");
            }
            if(node.LeftChild != null)
            {
                TraversePreOrder(node.LeftChild);
            }
            if(node.RightChild != null)
            {
                TraversePreOrder(node.RightChild);
            }
            return listTree;
        }
    }
}
