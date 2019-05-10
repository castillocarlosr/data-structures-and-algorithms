using System;

namespace ProductArray.Classes
{
    public class ProductClassArray
    {
        public int[] ProductArrayExceptIndex(int[] input)
        {
            int[] leftArr = new int[input.Length];
            int[] rightArr = new int[input.Length];
            int[] productArr = new int[input.Length];

            leftArr[0] = 1;
            rightArr[input.Length - 1] = 1;

            for (int i = 0; i < input.Length - 1; i++)
            {
                leftArr[i + 1] = leftArr[i] * input[i];
            }
            for(int j = input.Length-1; j>0; j--)
            {
                rightArr[j - 1] = rightArr[j] * input[j];
            }
            for (int k = 0; k < input.Length; k++)
            {
                productArr[k] = rightArr[k] * leftArr[k];
            }
            return productArr;
        }
    }
}
