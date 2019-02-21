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
            tableOne.Add("fond", "enamored");
            tableOne.Add("wrath", "anger");
            tableOne.Add("diligent", "employed");
            tableOne.Add("outfit", "garb");
            tableOne.Add("guide", "usher");
            tableOne.Add("last", "end");

            Hashtables tableTwo = new Hashtables();
            tableTwo.Add("fond", "averse");
            tableTwo.Add("wrath", "delight");
            tableTwo.Add("diligent", "idle");
            tableTwo.Add("empty", "gone");
            tableTwo.Add("nope", "never");
            tableTwo.Add("last", "jam");
            
            List<string> result = LeftJoin(tableOne, tableTwo);
            Console.WriteLine($"[{string.Join(",", result)}]");

            Console.ReadLine();
        }

        public static List<string> LeftJoin(Hashtables tableOne, Hashtables tableTwo)
        {
            List<string> output = new List<string>();

            var keys = tableOne.Bucket.ToString();

            //foreach (KeyValuePair<string, object> kv in tableOne.ToString())
            //{
                //output.Add(tableOne.GetValue(kv));
            //}

            //Yeah.  I'm stuck and google is of no help.
            //Not sure how to read the keys without already knowing the keys.
            
            while (tableOne.Bucket != null)
            {
                for (int i = 0; i < tableOne.Bucket.Length; i++)
                {
                    while(tableOne.Bucket[i] != null)
                    {
                        output.Add(tableOne.Bucket[i].Head.Value.ToString());
                    }              
                }
                if(tableOne.Bucket == tableTwo.Bucket)
                {
                    output.Add(tableOne.Bucket.ToString());
                    //output.Add(tableTwo.GetValue(tableOne.Bucket.ToString());
                }
            }
            
            return output;
        }
    }
}
