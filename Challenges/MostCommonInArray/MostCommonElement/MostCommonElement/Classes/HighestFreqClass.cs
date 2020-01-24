using System;
using System.Collections.Generic;
using System.Text;

namespace MostCommonElement.Classes
{
    public class HighestFreqClass
    {
        public int HighestNumber(int[] arr)
        {
            Dictionary<int, int> hashMap = new Dictionary<int, int>(); //could of called it hs for hashMap.  Keep in mind Java uses HashMap but not C#.
            //int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashMap.ContainsKey(arr[i]))
                {
                    int frequency = hashMap[arr[i]];  //gets the number from the value pair.
                    frequency++;                     //adds one more to that value.
                    hashMap[arr[i]] = frequency;    //returns that vaule to the key pair.
                }
                else
                {
                    hashMap.Add(arr[i], 1);
                }
            }

            //Now to find the highest int from all the values in the pairs.
            int min_count = 0;
            int result = -1;  //base case for edge cases.
            foreach (KeyValuePair<int, int> pair in hashMap)      
            {
                if(min_count < pair.Value)
                {
                    result = pair.Key;
                    min_count = pair.Value;

                }
            }
            return result;

        }

        public int HighestFrequencyCount(int[] arr)
        {
            Dictionary<int, int> hashMap = new Dictionary<int, int>(); //could of called it hs for hashMap.  Keep in mind Java uses HashMap but not C#.
            //int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashMap.ContainsKey(arr[i]))
                {
                    int frequency = hashMap[arr[i]];  //gets the number from the value pair.
                    frequency++;                     //adds one more to that value.
                    hashMap[arr[i]] = frequency;    //returns that vaule to the key pair.
                }
                else
                {
                    hashMap.Add(arr[i], 1);
                }
            }

            //Now to find the highest int from all the values in the pairs.
            int min_count = 0;
            int result = -1;  //base case for edge cases.
            foreach (KeyValuePair<int, int> pair in hashMap)
            {
                if (min_count < pair.Value)
                {
                    result = pair.Key;
                    min_count = pair.Value;

                }
            }
            return min_count;  //similar to previous object but returns the value instead of key.

        }
    }
}
