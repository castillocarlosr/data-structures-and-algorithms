using System;
using Xunit;
using StacksAndQueue.Classes;

namespace StacksAndQueueTDD
{
    public class UnitTest1
    {
        //******************Stack***************
        /// <summary>
        /// Stack Test Push
        /// </summary>
        [Fact]
        public void PushStackOne()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Stack testStack = new Stack(null);

            Assert.Equal(nodeTestOne, testStack.Push(nodeTestOne));
        }
        [Fact]
        public void PushStackTwo()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Stack testStack = new Stack(nodeTestOne);

            Assert.Equal(nodeTestTwo, testStack.Push(nodeTestTwo));
        }
        [Fact]
        public void PushStackThree()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Node nodeTestFour = new Node(4);
            Stack testStack = new Stack(nodeTestOne);
            testStack.Push(nodeTestTwo);
            testStack.Push(nodeTestThree);

            Assert.Equal(nodeTestFour, testStack.Push(nodeTestFour));
        }

        /// <summary>
        /// Test stack Pop
        /// </summary>
        [Fact]
        public void PopStackOne()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Node nodeTestFour = new Node(4);
            Stack testStack = new Stack(null);
            testStack.Push(nodeTestOne);
            testStack.Push(nodeTestTwo);

            Assert.Equal(nodeTestTwo, testStack.Pop());
        }
        [Fact]
        public void PopStackTwo()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Node nodeTestFour = new Node(4);
            Stack testStack = new Stack(nodeTestOne);
            testStack.Push(nodeTestTwo);
            testStack.Push(nodeTestThree);
            testStack.Push(nodeTestFour);

            Assert.Equal(nodeTestFour, testStack.Pop());
        }
        [Fact]
        public void PopStackThree()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Node nodeTestFour = new Node(4);
            Stack testStack = new Stack(nodeTestOne);
            testStack.Push(nodeTestTwo);
            testStack.Push(nodeTestThree);
            testStack.Push(nodeTestFour);
            testStack.Pop();

            Assert.Equal(nodeTestThree, testStack.Pop());
        }

        /// <summary>
        /// Test stack Peek
        /// </summary>
        [Fact]
        public void PeekOne()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Node nodeTestFour = new Node(4);
            Stack testStack = new Stack(nodeTestOne);
            testStack.Push(nodeTestTwo);

            Assert.Equal(nodeTestTwo, testStack.Peek());
        }
        [Fact]
        public void PeekTwo()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Node nodeTestFour = new Node(4);
            Stack testStack = new Stack(nodeTestOne);
            testStack.Push(nodeTestTwo);
            testStack.Push(nodeTestThree);
            testStack.Push(nodeTestFour);
            testStack.Pop();

            Assert.Equal(nodeTestThree, testStack.Peek());
        }
        [Fact]
        public void PeekThree()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Node nodeTestFour = new Node(4);
            Stack testStack = new Stack(nodeTestOne);
            testStack.Push(nodeTestTwo);
            testStack.Push(nodeTestThree);
            testStack.Pop();
            testStack.Push(nodeTestFour);
            testStack.Pop();

            Assert.Equal(nodeTestTwo, testStack.Peek());
        }

        //******************Queue***************
        /// <summary>
        /// Test for Enqueue
        /// </summary>
        [Fact]
        public void EnqueueOne()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Queue testQueue = new Queue(nodeTestOne);
            //testQueue.Enqueque(nodeTestOne);

            Assert.Equal(nodeTestTwo, testQueue.Enqueque(nodeTestTwo));
        }
        [Fact]
        public void EnqueueThree()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Node nodeTestFour = new Node(4);
            Queue testQueue = new Queue(nodeTestOne);
            testQueue.Enqueque(nodeTestTwo);
            testQueue.Enqueque(nodeTestThree);

            Assert.Equal(nodeTestFour, testQueue.Enqueque(nodeTestFour));
        }
        [Fact]
        public void EnqueueTwo()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Queue testQueue = new Queue(nodeTestOne);
            testQueue.Enqueque(nodeTestTwo);

            Assert.Equal(nodeTestThree, testQueue.Enqueque(nodeTestThree));
        }

        /// <summary>
        /// Test for Dequeue
        /// </summary>
        [Fact]
        public void DequeueOne()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Queue testQueue = new Queue(nodeTestOne);
            testQueue.Enqueque(nodeTestTwo);

            Assert.Equal(nodeTestOne, testQueue.Dequeque());
        }
        [Fact]
        public void DequeueTwo()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Queue testQueue = new Queue(nodeTestOne);
            testQueue.Enqueque(nodeTestTwo);
            testQueue.Enqueque(nodeTestThree);

            Assert.Equal(nodeTestOne, testQueue.Dequeque());
        }
        [Fact]
        public void DequeueThree()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Queue testQueue = new Queue(nodeTestOne);
            testQueue.Enqueque(nodeTestTwo);
            testQueue.Enqueque(nodeTestThree);
            testQueue.Dequeque();

            Assert.Equal(nodeTestTwo, testQueue.Dequeque());
        }

        [Fact]
        public void PeekQueueOne()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Queue testQueue = new Queue(nodeTestOne);
            testQueue.Enqueque(nodeTestTwo);

            Assert.Equal(nodeTestOne, testQueue.Peek());
        }
        [Fact]
        public void PeekQueueTwo()
        {
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Queue testQueue = new Queue(nodeTestTwo);
            testQueue.Enqueque(nodeTestThree);

            Assert.Equal(nodeTestTwo, testQueue.Peek());
        }
        [Fact]
        public void PeekQueueThree()
        {
            Node nodeTestOne = new Node(1);
            Node nodeTestTwo = new Node(2);
            Node nodeTestThree = new Node(3);
            Queue testQueue = new Queue(nodeTestOne);
            testQueue.Enqueque(nodeTestTwo);
            testQueue.Enqueque(nodeTestThree);
            testQueue.Dequeque();

            Assert.Equal(nodeTestTwo, testQueue.Peek());
        }

    }
}
