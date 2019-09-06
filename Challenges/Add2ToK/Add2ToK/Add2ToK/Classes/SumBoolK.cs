using System;
namespace Add2ToK.Classes
{
    public class SumBoolK
    {
        public bool TwoNumInK(int[] intArr, int k)
        {
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                for (int j = i+1; j < intArr.Length; j++)
                {
                    int tempAnswer;
                    tempAnswer = intArr[i] + intArr[j];
                    if(tempAnswer == k)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
