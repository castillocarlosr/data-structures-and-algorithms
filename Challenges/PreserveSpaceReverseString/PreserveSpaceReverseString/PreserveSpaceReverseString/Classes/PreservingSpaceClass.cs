using System;
namespace PreserveSpaceReverseString.Classes
{
    public class PreservingSpaceClass
    {
        public string ReverseInputStr(string input)
        {
            char[] inputArr = input.ToCharArray();
            char[] result = new char[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                if(inputArr[i] == '$')
                {
                    result[i] = '$';
                }
            }
            int j = result.Length - 1;
            for (int i = 0; i < inputArr.Length; i++)
            {
                if(inputArr[i] != '$')
                {
                    if(result[j] == '$')
                    {
                        j--;
                    }
                    result[j] = inputArr[i];
                    j--;
                }
            }
            string sendResults = new string(result);
            return sendResults;
        }
    }
}
