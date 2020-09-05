using System;
namespace BribeQueueLine.Classes
{
    public class QueueClass
    {
        public void minimumBribes(int[] q)
        {
            Console.WriteLine("Cool beans");
            int bribes = 0;
            for (int i = 0; i < q.Length; i++)
            {
                if(q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                }
            }
        }
    }
}
