﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringSubString.Classes
{
    public class MatchSubString
    {
        public bool MatchSubStringBool(string s1, string s2)
        {
            int s1Len = s1.Length;
            int s2Len = s2.Length;

            int i;
            for (i = 0; i <= s2Len - s1Len; i++)
            {
                int j;
                for (j = 0; j < s1Len; j++)
                {
                    if (s2[i + j] != s1[j])
                        break;
                }
                if (j == s1Len)
                    return true;
            }
            return false;
        }

    }
}
