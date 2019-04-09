using System;
using CyclicLList.Classes;

namespace CyclicLList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Linked List that maybe is cyclic or not!");

            Node node1 = new Node(10);
            Node node2 = new Node(12);
            Node node3 = new Node(13);
            Node node4 = new Node(14);
            Node node5 = new Node(15);
            Node node6 = new Node(16);
            Node node7 = new Node(17);
            Node node8 = new Node(18);

            LList normalList = new LList();
            normalList.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = node8;
            //node8.Next = node4;
            //circleList.Head.Next.Next.Next.Next.Next.Next.Next = node4;

            
            Console.WriteLine($"This linked list is not repeated.{normalList.IsCircular(normalList.Head)}");
            Console.WriteLine("");
            IsCircleList();


            Console.ReadLine();
        }

        public static void IsCircleList()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(12);
            Node node3 = new Node(13);
            Node node4 = new Node(14);
            Node node5 = new Node(15);
            Node node6 = new Node(16);
            Node node7 = new Node(17);
            Node node8 = new Node(18);

            LList circleList = new LList();
            circleList.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = node8;
            node8.Next = node4;
            Console.WriteLine($"This linked is in a circle from the last node to node four.{circleList.IsCircular(circleList.Head)}");
        }
    }
}
