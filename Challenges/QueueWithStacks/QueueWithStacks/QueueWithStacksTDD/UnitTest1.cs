using System;
using Xunit;
using StacksAndQueue.Classes;
using QueueWithStacks;

namespace QueueWithStacksTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Test for Enqueque where a node is added to the "Rear" of the PseudoQueue
        /// </summary>
        [Fact]
        public void EnqueueOne()
        {
            Node nodeOne = new Node(11);

            PseudoQueue testOne = new PseudoQueue();
            Assert.Equal(nodeOne, testOne.Enqueue(nodeOne));
        }
        [Fact]
        public void EnqueueTwo()
        {
            Node nodeOne = new Node(11);
            Node nodeTwo = new Node(22);

            PseudoQueue testTwo = new PseudoQueue();
            testTwo.Enqueue(nodeTwo);
            Assert.Equal(nodeTwo, testTwo.Enqueue(nodeTwo));
        }
        [Fact]
        public void EnqueueThree()
        {
            Node nodeOne = new Node(11);
            Node nodeTwo = new Node(22);
            Node nodeThree = new Node(33);
            Node nodeFour = new Node(44);

            PseudoQueue testThree = new PseudoQueue();
            testThree.Enqueue(nodeOne);
            testThree.Enqueue(nodeTwo);
            testThree.Enqueue(nodeThree);
            Assert.Equal(nodeFour, testThree.Enqueue(nodeFour));
        }

        /// <summary>
        /// Test for Dequeue where a node is removed from the "Front" PseudoQueue
        /// </summary>
        [Fact]
        public void DesqueueOne()
        {
            Node nodeOne = new Node(11);
            Node nodeTwo = new Node(22);
            Node nodeThree = new Node(33);

            PseudoQueue testOne = new PseudoQueue();
            testOne.Enqueue(nodeOne);
            testOne.Enqueue(nodeTwo);
            testOne.Enqueue(nodeThree);
            Assert.Equal(nodeOne, testOne.Desqueue());
        }
        [Fact]
        public void DesqueueTwo()
        {
            Node nodeOne = new Node(11);
            Node nodeTwo = new Node(22);
            Node nodeThree = new Node(33);

            PseudoQueue testTwo = new PseudoQueue();
            testTwo.Enqueue(nodeOne);
            testTwo.Enqueue(nodeTwo);
            testTwo.Enqueue(nodeThree);
            testTwo.Desqueue();
            
            Assert.Equal(nodeTwo, testTwo.Desqueue());
        }
        [Fact]
        public void DesqueueThree()
        {
            Node nodeOne = new Node(11);
            Node nodeTwo = new Node(22);
            Node nodeThree = new Node(33);
            Node nodeFour = new Node(44);

            PseudoQueue testThree = new PseudoQueue();
            testThree.Enqueue(nodeOne);
            testThree.Enqueue(nodeTwo);
            testThree.Enqueue(nodeThree);
            testThree.Enqueue(nodeFour);
            testThree.Desqueue();
            testThree.Desqueue();
            testThree.Desqueue();

            Assert.Equal(nodeFour, testThree.Desqueue());
        }
    }
}
