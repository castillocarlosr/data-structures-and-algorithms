using System;
using HashTables.Classes;

namespace HashTables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Hashtables");
            Console.WriteLine("");
            displayHashes();
            
            Console.ReadLine();
        }
        
        public static void displayHashes()
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add("abc", "Josie");
            hashTables.Add("Dog", "Woof");
            hashTables.Add("333", "ponies");
            hashTables.Add("moons", "44");
            hashTables.Add("cba", "Doctor"); //Collision abc same as cba
            Console.WriteLine($"Should return as 'True' for contains:  {hashTables.Contains("moons")}");
            Console.WriteLine($"Should return as 'False' for contains: {hashTables.Contains("planet")}");
            Console.WriteLine($"Should return the value 'Woof' from key:  {hashTables.GetValue("Dog")}");
            Console.WriteLine($"Should return the value 'Doctor' from collision: {hashTables.GetValue("cba")}");
        }
    }
}
