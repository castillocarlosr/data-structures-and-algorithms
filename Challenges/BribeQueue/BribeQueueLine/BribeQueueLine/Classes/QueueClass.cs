using System;
namespace BribeQueueLine.Classes
{
    public class QueueClass
    {
        public void minimumBribes(int[] q)
        {
            bool chaos = false;
            int bribes = 0;
            for (int i = 0; i < q.Length; i++)
            {
                if(q[i] - (i + 1) > 2)
                {
                    chaos = true;
                }
                else
                {
                    for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    {
                        if (q[j] > q[i])
                        {
                            bribes++;
                        }
                    }
                }
            }
            if(chaos == true)
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                Console.WriteLine($"{bribes}");
            }
        }
    }
}
