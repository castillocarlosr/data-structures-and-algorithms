using System;
using ClosestNodeBinaryTree.Classes;

namespace ClosestNodeBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Binary Tree World!");

            Node root = new Node(10);
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node fifteen = new Node(15);
            Node twentyTwo = new Node(20);
            Node thirtyThree = new Node(33);
            Node forty = new Node(40);

            root.LeftChild = three;
            root.RightChild = twentyTwo;

            three.LeftChild = two;
            three.RightChild = four;

            twentyTwo.LeftChild = fifteen;
            twentyTwo.RightChild = thirtyThree;

            two.LeftChild = one;

            thirtyThree.RightChild = forty;

            ClosestInTree closest = new ClosestInTree();

            Console.WriteLine($"What's closest to 14: {closest.ClosestNumber(root, 14)}");

            Console.ReadLine();
        }
    }
}
