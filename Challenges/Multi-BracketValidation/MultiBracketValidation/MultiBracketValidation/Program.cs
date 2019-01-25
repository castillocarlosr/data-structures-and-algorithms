using System;
using StacksAndQueue.Classes;
using System.Linq;
using System.Collections.Generic;

namespace MultiBracketValidate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Multi-Brackets Validation!");
            Console.WriteLine("\n");

            Console.WriteLine("Matching bracket input:  (){}[]");
            Console.WriteLine(MultiBracketValidation("(){}[]"));

            Console.WriteLine("");
            Console.WriteLine("NON-Matching bracket input:  (}){[]");
            Console.WriteLine(MultiBracketValidation("(}){[]"));

            Console.WriteLine("");
            Console.WriteLine("Matching bracket input with string text: First (Second){third}[frouth]Fifth");
            Console.WriteLine(MultiBracketValidation("First (Second){third}[frouth]Fifth"));
            Console.ReadLine();
        }

        /// <summary>
        /// Takes in a string and checks for "brackets" making sure there are matching opening and closing.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>boolean</returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack<char> stack = new Stack<char>();
            char[] inputChar = input.ToCharArray();

            char[] eventCharacters = { '[', '{', '(', ']', '}', ')' };
            var bracket = (open: '[', close: ']');
            var curled = (open: '{', close: '}');
            var parenthesis = (open: '(', close: ')');

            for (int i = 0; i < inputChar.Length; i++)
            {
                if (!eventCharacters.Contains(inputChar[i]))
                    continue;
                else if (inputChar[i] == bracket.close)
                {
                    char x = stack.Peek();
                    if (x == bracket.open)
                        stack.Pop();
                }
                else if (inputChar[i] == curled.close)
                {
                    char x = stack.Peek();
                    if (x == curled.open)
                        stack.Pop();
                }
                else if (inputChar[i] == parenthesis.close)
                {
                    char x = stack.Peek();
                    if (x == parenthesis.open)
                        stack.Pop();
                }
                else
                    stack.Push(inputChar[i]);
            }
            try
            {
                stack.Pop();
            }
            catch (Exception)
            {
                //works
                return true;
            }
            return false;
        }
    }
}
