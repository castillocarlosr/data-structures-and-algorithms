using System;
using HashTables.Classes;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Left Join");
            Console.WriteLine("");

            Hashtables tableOne = new Hashtables();
            tableOne.Add("abc", "enamored");
            tableOne.Add("abcd", "anger");
            tableOne.Add("qwerty", "employed");
            tableOne.Add("outfit", "garb");
            tableOne.Add("guide", "usher");
            tableOne.Add("extremetomax", "end");

            Hashtables tableTwo = new Hashtables();
            tableTwo.Add("abc", "averse");
            tableTwo.Add("abcd", "delight");
            tableTwo.Add("qwerty", "idle");
            tableTwo.Add("empty", "gone");
            tableTwo.Add("nope", "never");
            tableTwo.Add("extremetomax", "jam");
            
            List<string> result = LeftJoin(tableOne, tableTwo);
            Console.WriteLine($"[{string.Join(",", result)}]");

            Console.ReadLine();
        }

        public static List<string> LeftJoin(Hashtables tableOne, Hashtables tableTwo)
        {
            List<string> listTableOne = new List<string>();
            List<string> listTableTwo = new List<string>();
            List<string> output = new List<string>();
            
            for (int i = 0; i < tableOne.Bucket.Length; i++)
            {
                if (tableOne.Bucket[i] != null)
                {                                    
                    listTableOne.Add(tableOne.Bucket[i].Head.Key.ToString());
                    listTableOne.Add(tableOne.Bucket[i].Head.Value.ToString());
                }
            }

            for (int i = 0; i < tableTwo.Bucket.Length; i++)
            {
                if (tableTwo.Bucket[i] != null)
                {
                    listTableTwo.Add(tableTwo.Bucket[i].Head.Key.ToString());
                    listTableTwo.Add(tableTwo.Bucket[i].Head.Value.ToString());
                }
            }

            string[] tableOneArr = listTableOne.ToArray();
            string[] tableTwoArr = listTableOne.ToArray();

            for (int i = 0; i < tableOneArr.Length; i++)
            {
                for (int m = 0; m < tableTwoArr.Length; m++)
                {
                    if(tableOneArr[i] == tableTwoArr[m])
                    {
                        output.Add(tableOneArr[i]);
                        output.Add(tableOneArr[i + 1]);
                        output.Add(tableTwoArr[m + 1]);
                    }
                }
            }

            return output;
        }
    }
}
