using System;
using System.Text;

namespace ReverseIntString.Classes
{
    public class ReverseTypes
    {
        public int ReverseIntegers(int input)
        {
            int a = input;
            int b;
            int rev = 0;
            while (a != 0)
            {
                b = a % 10;
                rev = (rev * 10) + b;
                a = a / 10;
            }
            return rev;
        }

        public string ReverseWord(string input)
        {
            //char[] charArr = input.ToCharArray();
            //Array.Reverse(charArr);
            //return new string(charArr);
            StringBuilder stringRever = new StringBuilder();
            string[] words = input.Split(' ');
            for (int i = words.Length-1; i>-1; i--)
            {
                stringRever.Append(words[i]);
                stringRever.Append(" ");
            }
            return stringRever.ToString();
            /*
            string[] strArr = input.Split(" ");
            int i = 0;
            int j = strArr.Length - 1;
            while(i < j)
            {
                string temp = strArr[i];
                strArr[i] = strArr[j];
                strArr[j] = temp;
                i++;
                j--;
            }
            //string input2 = strArr.ToString();
            //return input2;
            return new string( strArr );
            */
        }
    }
}
