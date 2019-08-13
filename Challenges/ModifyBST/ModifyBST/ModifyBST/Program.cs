using System;
using ModifyBST.Classes;

namespace ModifyBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Modified Binary Search Tree!");

            Node tree = new Node(5);
            tree.RightChild = new Node(7);
            tree.RightChild.LeftChild = new Node(6);
            tree.RightChild.RightChild = new Node(8);
            tree.LeftChild = new Node(3);
            tree.LeftChild.RightChild = new Node(4);
            tree.LeftChild.LeftChild = new Node(2);

            Console.WriteLine("Initial Binary Search Tree example:");
            Console.WriteLine($"          {tree.Value}");
            Console.WriteLine($"         /  \\");
            Console.WriteLine($"        {tree.LeftChild.Value}     {tree.RightChild.Value}");
            Console.WriteLine($"       / \\   / \\");
            Console.WriteLine($"      {tree.LeftChild.LeftChild.Value}   {tree.LeftChild.RightChild.Value}  {tree.RightChild.LeftChild.Value}   {tree.RightChild.RightChild.Value}");

            Console.WriteLine("\n");
            Console.WriteLine("After modify on binary search tree");

            BSTmodifing bSTmodifing = new BSTmodifing();
            bSTmodifing.modifySum(tree);
            Console.WriteLine($"          {tree.Value}");
            Console.WriteLine($"         /  \\");
            Console.WriteLine($"        {tree.LeftChild.Value}     {tree.RightChild.Value}");
            Console.WriteLine($"       / \\   / \\");
            Console.WriteLine($"      {tree.LeftChild.LeftChild.Value}  {tree.LeftChild.RightChild.Value} {tree.RightChild.LeftChild.Value}  {tree.RightChild.RightChild.Value}");

            Console.ReadLine();
        }
    }
}
