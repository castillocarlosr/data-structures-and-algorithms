using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedStringLongA.Classes
{
    public class StringRepeatA
    {
        public long repeatedString(string s, long n)
        {
            long strLength = s.Length;
            char[] strChar = s.ToCharArray();
            if (strLength == 1 && strChar[0] == 'a')
            {
                return n;
            }

            long counter = 0;
            long remainderS = n % strLength;
            long repeatedS = n / strLength;
            for (long i = 0; i < strLength; i++)
            {
                if (strChar[i] == 'a')
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                return 0;
            }
            else
            {

                long multiplyRepeatedS = repeatedS * counter;
                if (remainderS == 0)
                {
                    return multiplyRepeatedS;
                }
                else
                {
                    for (long j = 0; j < remainderS; j++)
                    {
                        if (strChar[j] == 'a')
                        {
                            multiplyRepeatedS++;
                        }
                    }
                    return multiplyRepeatedS;
                }

            }

        }
    }
}
