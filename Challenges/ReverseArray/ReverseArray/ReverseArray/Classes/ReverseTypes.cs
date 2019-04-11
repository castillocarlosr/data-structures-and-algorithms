using System;
namespace ReverseArray.Classes
{
    public class ReverseTypes
    {
        public int[] ReverseInputArray(int[] input)
        {
            int i = 0;
            int j = input.Length - 1;
            while (i<j)
            {
                int temp = input[i];
                input[i] = input[j];
                input[j] = temp;
                i++;
                j--;
            }
            return input;
        }

        public string ReverseInputString(string input)
        {
            char[] stringArr = input.ToCharArray();
            int i = 0;
            int j = stringArr.Length - 1;
            while (i < j)
            {
                char temp = stringArr[i];
                stringArr[i] = stringArr[j];
                stringArr[j] = temp;
                i++;
                j--;
            }
            input = string.Join("", stringArr);
            return input;
        }
    }
}
