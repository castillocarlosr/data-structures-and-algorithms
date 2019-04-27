using System;
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
    }
}
