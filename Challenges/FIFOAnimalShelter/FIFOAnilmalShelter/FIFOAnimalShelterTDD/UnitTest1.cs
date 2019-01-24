using System;
using Xunit;
using FIFOAnilmalShelter.Classes;

namespace FIFOAnimalShelterTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Enqueue Tests
        /// </summary>
        [Fact]
        public void EnqueueCatToShelterEmpty()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal cat = new Animal("cat");
            shelter.Enqueue(cat);

            Assert.Equal("cat", shelter.Front.Type);
        }
        [Fact]
        public void EnqueueTestDog()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal cat = new Animal("cat");
            Animal dog = new Animal("dog");
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);

            Assert.Equal("dog", shelter.Rear.Type);
        }
        [Fact]
        public void EnqueueTestTutle()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal cat = new Animal("cat");
            Animal dog = new Animal("dog");
            Animal turtle = new Animal("turtle");
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);
            shelter.Enqueue(turtle);

            Assert.Equal("dog", shelter.Rear.Type);
        }

        [Fact]
        public void DequeueCat()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal cat = new Animal("cat");
            Animal dog = new Animal("dog");
            Animal turtle = new Animal("turtle");
            shelter.Enqueue(dog);
            shelter.Enqueue(dog);
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);
            shelter.Enqueue(cat);
            shelter.Enqueue(turtle);

            Assert.Equal("cat", shelter.Dequeue(cat).Type);

        }
        [Fact]
        public void DequeueDog()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal cat = new Animal("cat");
            Animal dog = new Animal("dog");
            Animal turtle = new Animal("turtle");
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);
            shelter.Enqueue(dog);
            shelter.Enqueue(turtle);
            shelter.Enqueue(dog);
            shelter.Enqueue(cat);

            Assert.Equal("dog", shelter.Dequeue(dog).Type);

        }
        [Fact]
        public void DequeueTurtle()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal cat = new Animal("cat");
            Animal dog = new Animal("dog");
            Animal turtle = new Animal("turtle");
            shelter.Enqueue(dog);
            shelter.Enqueue(dog);
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);
            shelter.Enqueue(cat);
            shelter.Enqueue(turtle);

            Assert.Equal("dog", shelter.Dequeue(turtle).Type);
        }
    }
}
