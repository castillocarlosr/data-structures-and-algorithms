using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandNumbers
{
    public class RandomFive
    {
        /// <summary>
        /// Classic method for random generation
        /// </summary>
        /// <param name="minInput"></param>
        /// <param name="maxInput"></param>
        /// <returns></returns>
        public int[] FiveNumbers(int minInput, int maxInput)
        {
            int[] results = new int[5];
            Random randomNum = new Random();
            for(int i = 0; i < results.Length; i++)
            {
                results[i] = randomNum.Next(minInput, maxInput);
            }
            return results;
        }

        /// <summary>
        /// Using LINQ for the random number selection
        /// </summary>
        /// <param name="minInput"></param>
        /// <param name="maxInput"></param>
        /// <returns></returns>
        public int[] SixNumbers(int minInput, int maxInput)
        {
            Random randomNum = new Random();
            int[] results = Enumerable.Repeat(0, 6).Select(i => randomNum.Next(minInput, maxInput)).ToArray();
            return results;
        }
    }

    
}
