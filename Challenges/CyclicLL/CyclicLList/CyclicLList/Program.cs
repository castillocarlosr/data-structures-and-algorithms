using System;
using CyclicLList.Classes;

namespace CyclicLList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Linked List that maybe is cyclic or not!");

            Node node = new Node(1);
            /*
            LList circleList = new LList();
            circleList.Head = new Node(10);
            circleList.Head.Next = new Node(12);
            circleList.Head.Next.Next = new Node(13);
            circleList.Head.Next.Next.Next = new Node(14);
            circleList.Head.Next.Next.Next.Next = new Node(15);
            circleList.Head.Next.Next.Next.Next.Next = new Node(16);
            circleList.Head.Next.Next.Next.Next.Next.Next = new Node(17);
            */


            Console.ReadLine();
        }

        public static void IsCircleList()
        {
            LList circleList = new LList();
            circleList.Head = new Node(10);
            circleList.Head.Next = new Node(12);
            circleList.Head.Next.Next = new Node(13);
            circleList.Head.Next.Next.Next = new Node(14);
            circleList.Head.Next.Next.Next.Next = new Node(15);
            circleList.Head.Next.Next.Next.Next.Next = new Node(16);
            circleList.Head.Next.Next.Next.Next.Next.Next = new Node(17);

            if(circleList.Head != null && circleList.Head.Next != null)
            {

            }
        }
    }
}
