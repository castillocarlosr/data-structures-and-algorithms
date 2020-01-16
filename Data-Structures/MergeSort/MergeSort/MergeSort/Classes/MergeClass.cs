using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort.Classes
{
    public class MergeClass
    {
        public int[] MergeSortInput(int[] arr)
        {
            if(arr.Length <= 1)
            {
                return arr;
            }
            
            int midPoint = arr.Length / 2;

            int[] leftArr = new int[midPoint];
            int[] rightArr;
            int[] resultArr;

            if(arr.Length % 2 == 0)
            {
                rightArr = new int[midPoint];
            }
            else
            {
                rightArr = new int[midPoint + 1];
            }
            for (int i = 0; i < midPoint; i++)
            {
                leftArr[i] = arr[i];
            }
            int x = 0;
            for (int i = midPoint; i < arr.Length; i++)
            {
                rightArr[x] = arr[i];
                x++;
            }
            leftArr = MergeSortInput(leftArr);
            rightArr = MergeSortInput(rightArr);
            resultArr = MergeUtility(leftArr, rightArr);
            return resultArr;
        }

        public int[] MergeUtility(int[] leftArr, int[] rightArr)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            int[] resultArr = new int[leftArr.Length + rightArr.Length];
            while(leftIndex < leftArr.Length || rightIndex < rightArr.Length)
            {
                if(leftIndex < leftArr.Length && rightIndex < rightArr.Length)
                {
                    if(leftArr[leftIndex] <= rightArr[rightIndex])
                    {
                        resultArr[resultIndex] = leftArr[leftIndex];
                        resultIndex++;
                        leftIndex++;
                    }
                    else
                    {
                        resultArr[resultIndex] = rightArr[rightIndex];
                        resultIndex++;
                        rightIndex++;
                    }
                }
                else if(leftIndex < leftArr.Length)
                {
                    resultArr[resultIndex] = leftArr[leftIndex];
                    resultIndex++;
                    leftIndex++;
                }
                else if(rightIndex < rightArr.Length)
                {
                    resultArr[resultIndex] = rightArr[rightIndex];
                    resultIndex++;
                    rightIndex++;
                }
            }
            return resultArr;
        }
    }
}
