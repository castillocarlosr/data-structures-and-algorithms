using System;

namespace PascalTriangle.Classes
{
    public class TriangleClass
    {
        /// <summary>
        /// Very ineffiecient.
        /// Big O(n^2) for time.
        /// Big O(n^2) for space.
        /// </summary>
        /// <returns>The array slow.</returns>
        /// <param name="k">K.</param>
        public int[,] TriangleArraySlow(int k)
        {
            int[,] arr = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if(i == j || j == 0)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, i];
                    }
                }
            }
            return arr;
        }

        public void PrintPascal(int k)
        {
            int[,] arr = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == j || j == 0)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, i];
                        Console.Write(arr[i, j]);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
