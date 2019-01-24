using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueue.Classes;

namespace FIFOAnilmalShelter.Classes
{
    public class AnimalShelter
    {
        public Queue animalQueue = new Queue();

        public Animal Front { get; set; }
        
        public Animal Rear { get; set; }

        public int totalAnimals = 0;

        //public string cat = "cat";
        //public string dog = "dog";
        /*
        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }
        */
        public void Enqueue(Animal animal)
        {
            if((animal.Type.ToLower() == "cat") || (animal.Type.ToLower() == "dog"))
            {
                if(Front == null)
                {
                    Front = animal;
                    Rear = animal;
                }
                else
                {
                    Animal temp = Rear;
                    temp.Next = animal;
                    Rear = animal;
                }
                totalAnimals++;
            }
        }

        public Animal Dequeue(Animal animal)
        {
            if(Front == null)
            {
                Console.WriteLine("Sorry.  Everyone seems to have adopted an animal.  We are empty which is good.");
                return Front;
            }
            else
            {
                Animal animalToAdopt = new Animal();

                for (int i = 0; i < totalAnimals - 1; i++)
                {
                    Animal x = new Animal(Front.Type);
                    Front = Front.Next;

                    if (Front.Type == animal.Type && animalToAdopt.Type == null)
                    {
                        animalToAdopt.Type = animal.Type;
                    }
                    else
                    {
                        Rear.Next = x;
                        Rear = x;
                    }
                }
                totalAnimals--;

                //stretch goal.  If animal does not exsist, please adopt one that's been there the longest.
                if (animalToAdopt.Type == null)
                    return Front;
                return animalToAdopt;
            }
        }
    }
}
