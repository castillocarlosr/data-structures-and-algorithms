using System;
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

        public string compressRepeats(string s1)
        {
            //Could of used a List<string> as well.
            //StringBuilder answer = new StringBuilder();
            List<string> list = new List<string>();
            int s1Len = s1.Length;
            int i;
            for (i = 0; i < s1Len; i++)
            {
                //starting count.  Just realized maybe I should be commenting.
                int count = 1;
                while (i < s1Len && (s1.Substring(i) == s1.Substring(i + 1)))
                {
                    count += 1; 
                    //count++;
                    i++;
                }
                //answer.Append(count);
                //answer.Append(s1.Substring(i));
                list.Add(count.ToString());
                list.Add(s1.Substring(i));
            }
            //return answer.ToString();
            string answer = string.Join("", list);
            return answer;
        }

    }
}
