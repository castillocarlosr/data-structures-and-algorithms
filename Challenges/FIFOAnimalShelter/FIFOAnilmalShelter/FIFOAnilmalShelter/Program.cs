using System;
using FIFOAnilmalShelter.Classes;
using StacksAndQueue.Classes;

namespace FIFOAnilmalShelter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dogs & Cats");

          
            FIFOAnimalShelter();
            Console.ReadLine();
        }

        public static void FIFOAnimalShelter()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal cat = new Animal("cat");
            Animal dog = new Animal("dog");
            Animal turtle = new Animal("turtle");

            Console.WriteLine("");
            Console.WriteLine("=============brand new empty shelter=========");
            shelter.Dequeue(dog);
            Console.WriteLine("");
            Console.WriteLine("=============adding animals to shelter=========");
            Console.WriteLine("===adding dog, dog, cat, dog, cat, turtle======");
            shelter.Enqueue(dog);
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);
            shelter.Enqueue(dog);
            shelter.Enqueue(cat);
            shelter.Enqueue(turtle);

            Console.WriteLine("");
            Console.WriteLine("=============adopting a cat=========");
            Console.WriteLine(shelter.Dequeue(cat).Type);

            Console.WriteLine("");
            Console.WriteLine("=============adopting a dog=========");
            Console.WriteLine(shelter.Dequeue(dog).Type);

            Console.WriteLine("");
            Console.WriteLine("=============adopting a turtle=========");
            Console.WriteLine($"Sorry.  We only have cats and dogs.  So you get to adopt the longest animal that's been here.  {shelter.Dequeue(turtle).Type}");
        }
    }
}
