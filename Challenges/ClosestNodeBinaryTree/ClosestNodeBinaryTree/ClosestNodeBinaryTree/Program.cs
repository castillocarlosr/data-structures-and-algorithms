using System;
using ClosestNodeBinaryTree.Classes;

namespace ClosestNodeBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Binary Tree World!");

            Node root = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node ten = new Node(10);
            Node eleven = new Node(11);
            Node fifteen = new Node(15);
            Node twentyTwo = new Node(20);
            Node thirtyThree = new Node(33);

            root.LeftChild = two;
            root.RightChild = three;

            two.LeftChild = thirtyThree;
            two.RightChild = twentyTwo;

            three.LeftChild = four;
            three.RightChild = ten;

            thirtyThree.LeftChild = eleven;

            ten.RightChild = fifteen;

            ClosestInTree closest = new ClosestInTree();

            Console.WriteLine($"What's closest to 21: {closest.ClosestNumber(root, 21)}");

            Console.ReadLine();
        }
    }
}
