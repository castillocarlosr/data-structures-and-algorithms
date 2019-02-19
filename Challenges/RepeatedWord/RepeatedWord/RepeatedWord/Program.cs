using System;
using HashTables.Classes;
using HashTables;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Repeated Word!");
            Console.WriteLine(" ");

            Console.WriteLine("Repeated first upon once repeated time two two ok more repeat two two two two.");
            string input = "Repeated first upon once repeated time two two ok more repeat two two two two.";

            Console.WriteLine($"First repeated word:  {RepeatedWord(input)}");

            Console.ReadLine();
        }
        
        public static string RepeatedWord(string input)
        {
            string[] listOfWord = input.ToLower().Split(',',' ','.');
            Hashtables hashWords = new Hashtables();

            for (int i = 0; i < listOfWord.Length; i++)
            {
                string temp = listOfWord[i];

                if (hashWords.Contains(temp))
                {
                    return temp;
                }
                else
                {
                    hashWords.Add(temp, temp);
                }
            }
            return "No repeated word found.";             
        } 
    }
}
