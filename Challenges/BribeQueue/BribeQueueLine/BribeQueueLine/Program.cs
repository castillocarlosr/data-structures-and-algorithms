using System;
using BribeQueueLine.Classes;

namespace BribeQueueLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!  Here's a few Benjamins for to look the other way.");

            int[] test1 = new int[] { 1, 2, 3, 4, 6, 5 };
            QueueClass queueObj = new QueueClass();
            queueObj.minimumBribes(test1);

            Console.ReadLine();
        }
    }
}
