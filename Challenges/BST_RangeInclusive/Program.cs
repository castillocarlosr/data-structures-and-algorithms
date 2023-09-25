// See https://aka.ms/new-console-template for more information
using System;

namespace BST_RangeInclusive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DOG");
        }
        public class Node
        {
            int data;
            Node? left;
            Node? right;
            public Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }

        public class BST
        {
            public int RangeSum(Node head, int lower, int upper)
            {
                int answer = 0;
                Console.WriteLine("Hello, Carlos!");
                return answer;
            }
        }
    }
}

