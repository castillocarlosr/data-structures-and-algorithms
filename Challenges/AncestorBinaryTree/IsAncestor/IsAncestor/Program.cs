using System;
using IsAncestor.Classes;

namespace IsAncestor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ancenstry Tree!");

            AnectryTreeTrue();
            Console.ReadLine();
        }

        public static void AnectryTreeTrue()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);

            Console.Write($"Tree true: {tree.IsAncestor(3, 5, tree.Root)}");
        }
    }
}
