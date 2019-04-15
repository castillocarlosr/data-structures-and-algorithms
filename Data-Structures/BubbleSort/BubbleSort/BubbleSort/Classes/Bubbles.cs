using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort.Classes
{
    public class Bubbles
    {
        public int[] numArrSort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if(input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    } 
                }
            }
            return input;
        }

        public static void printEveryLine(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
                Console.Write($"This is pass {i}:");
                Console.WriteLine($"{string.Join(" ", input)}");
            }
        }
    }
}
