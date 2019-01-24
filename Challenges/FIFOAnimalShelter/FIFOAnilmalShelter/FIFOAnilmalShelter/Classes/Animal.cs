using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueue.Classes;

namespace FIFOAnilmalShelter.Classes
{
    public class Animal
    {
        public string Type { get; set; }

        public Animal Next { get; set; }

        public Animal()
        {

        }
        
        public Animal (string type)
        {
            Type = type;
        }
        
    }
}
