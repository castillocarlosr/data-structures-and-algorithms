using System;
using System.Linq;
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
            StringBuilder stringRever = new StringBuilder();
            string[] words = input.Split(' ');
            for (int i = words.Length-1; i>-1; i--)
            {
                stringRever.Append(words[i]);
                stringRever.Append(" ");
            }
            return stringRever.ToString();
        }

        public string ReverseLettersInEachWord(string input)
        {
            string resultString = string.Join(" ",
                 input.Split(' ')
                .Select(x => new String(x.Reverse()
                .ToArray())));
            return resultString;
        }

        public string ReverseAllLetters(string input)
        {
            char[] inputArr = input.ToCharArray();
            int a = 0;
            int b = inputArr.Length - 1;
            while(a < b)
            {
                char temp = inputArr[a];
                inputArr[a] = inputArr[b];
                inputArr[b] = temp;
                a++;
                b--;
            }
            string result = new string(inputArr);
            return result;
        }
    }
}
