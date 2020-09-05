using System;
using BribeQueueLine.Classes;

namespace BribeQueueLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!  Here's a few Benjamins for to look the other way.");

            int[] test0 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] test1 = new int[] { 1, 2, 4, 3, 5, 6 };
            int[] testChaos = new int[] { 1, 2, 6, 3, 4, 5};
            int[] test6 = new int[] { 2, 1, 5, 3, 4, 8, 6, 7, 10, 9 };
            QueueClass queueObj = new QueueClass();
            queueObj.minimumBribes(test0);
            queueObj.minimumBribes(test1);
            queueObj.minimumBribes(testChaos);
            queueObj.minimumBribes(test6);
            Console.ReadLine();
        }
    }
}
