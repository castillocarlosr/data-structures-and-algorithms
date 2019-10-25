using System;
namespace PreserveSpaceReverseString.Classes
{
    public class PreservingSpaceClass
    {
        public string ReverseInputStr(string input)
        {
            char[] inputArr = new char[input.Length];
            char[] result = new char[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                if(inputArr[i] == '$')
                {
                    result[i] = '$';
                }
            }
            int j = inputArr.Length - 1;
            for (int i = 0; i < input.Length; i++)
            {
                if(inputArr[i] != '$')
                {
                    result[j] = inputArr[i];
                    j--;
                }
                j--;
            }
            return result.ToString();
        }
    }
}
