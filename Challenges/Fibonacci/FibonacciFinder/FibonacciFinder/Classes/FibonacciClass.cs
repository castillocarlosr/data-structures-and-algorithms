using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciFinder.Classes
{
    public class FibonacciClass
    {
        public int FindSpecificIterative(int input)
        {
            List<int> fibSequence = new List<int>() { 0, 1};
            for (int i = 2; i < input + 1; i++)
            {
                fibSequence.Add(fibSequence[i-2] + fibSequence[i-1]);
            }
            return fibSequence[input];
        }

        public int FindSpecificRecursive(int input)
        {
            if(input < 2)
            {
                return input;
            }
            return FindSpecificRecursive(input - 1) + FindSpecificRecursive(input - 2);
        }

        //Fibonacci Sequence is 0, 1,1,2,3,5,8,13,21,34,55,89,144
        public int[] PrintSequence(int input)
        {
            int num = input - 1;
            int[] arrayFib = new int[input + 1];
            arrayFib[0] = 0;
            arrayFib[1] = 1;
            for (int i = 2; i <= num; i++)
            {
                arrayFib[i] = arrayFib[i - 2] + arrayFib[i - 1];
            }
            return arrayFib;
        }
        
    }
}
