using System;
using ReverseLinkedList.Classes;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of Reverse Linked List");
            Console.WriteLine("\n");

            ReverseLL reverseLL = new ReverseLL();
            reverseLL.AddNodeToEnd(new Node(1));
            reverseLL.AddNodeToEnd(new Node(2));
            reverseLL.AddNodeToEnd(new Node(3));
            reverseLL.AddNodeToEnd(new Node(4));
            reverseLL.AddNodeToEnd(new Node(55));
            Console.WriteLine($"Starting order of Linked List:");
            reverseLL.Print();

            Console.WriteLine("\n");
            Console.WriteLine("Now to reverse the order:");
            reverseLL.ActionToReverseLL();
            reverseLL.Print();
        }
    }
}
