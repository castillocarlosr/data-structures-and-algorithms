using System;
using HashTables.Classes;
using HashTables;

namespace RepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Repeated Word!");
            Console.WriteLine(" ");

            string input = "Once A upon a time two two ok";

            Console.WriteLine($"First repeated word:  {firstRepeatedWord(input)}");

            Console.ReadLine();
        }
        
        public static string firstRepeatedWord(string input)
        {
            
            string[] listOfWord = input.ToLower().Split(' ');
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
