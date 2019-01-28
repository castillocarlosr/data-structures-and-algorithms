using System;
using Xunit;
using Trees.Classes;
using System.Collections.Generic;

namespace TreesTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Test for PreOrder Binary Tree
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        /// <param name="valueThree"></param>
        [Theory]
        [InlineData (11, 22, 33)]
        [InlineData (44, 55, 66)]
        [InlineData (77, 88, 99)]
        public void PreOrderTest(int valueOne, int valueTwo, int valueThree)
        {
            List<int> expected = new List<int> { valueOne, valueTwo, valueThree };
            BinaryTree testTree = new BinaryTree(new Node(valueOne));
            testTree.Root.LeftChild = new Node(valueTwo);
            testTree.Root.RightChild = new Node(valueThree);

            Assert.Equal(expected, testTree.PreOrder(testTree.Root));
        }

        /// <summary>
        /// Test for InOrder Binary Tree
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        /// <param name="valueThree"></param>
        [Theory]
        [InlineData(11, 22, 33)]
        [InlineData(44, 55, 66)]
        [InlineData(77, 88, 99)]
        public void InOrderTest(int valueOne, int valueTwo, int valueThree)
        {
            List<int> expected = new List<int> { valueTwo, valueOne, valueThree };
            BinaryTree testTree = new BinaryTree(new Node(valueOne));
            testTree.Root.LeftChild = new Node(valueTwo);
            testTree.Root.RightChild = new Node(valueThree);

            Assert.Equal(expected, testTree.InOrder(testTree.Root));
        }

        /// <summary>
        /// Test for PostOder Binary Tree
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        /// <param name="valueThree"></param>
        [Theory]
        [InlineData(11, 22, 33)]
        [InlineData(44, 55, 66)]
        [InlineData(77, 88, 99)]
        public void PostOrderTest(int valueOne, int valueTwo, int valueThree)
        {
            List<int> expected = new List<int> { valueTwo, valueOne, valueThree };
            BinaryTree testTree = new BinaryTree(new Node(valueOne));
            testTree.Root.LeftChild = new Node(valueTwo);
            testTree.Root.RightChild = new Node(valueThree);

            Assert.Equal(expected, testTree.InOrder(testTree.Root));
        }

        /// <summary>
        /// Contains and Add test for Binary search tree to return true
        /// </summary>
        /// <param name="value"></param>
        [Theory]
        [InlineData(11)]
        [InlineData(44)]
        [InlineData(77)]
        public void AddBinarySearchTreeTrue(int value)
        {
            Node nodeSix = new Node(6);
            BinarySearchTree testBinarySearchTree = new BinarySearchTree(nodeSix);
            testBinarySearchTree.Add(nodeSix, value);
            testBinarySearchTree.Add(nodeSix, value);
            testBinarySearchTree.Add(nodeSix, value);

            Assert.True(testBinarySearchTree.Contains(nodeSix, value));
        }
        
        /// <summary>
        /// Contains and Add test for Binary search tree to return FALSE
        /// </summary>
        [Fact]
        public void AddBinarySearchTreeFalse1()
        {
            Node nodeSix = new Node(6);
            BinarySearchTree testBinarySearchTree = new BinarySearchTree();
            testBinarySearchTree.Add(nodeSix, 23);
            testBinarySearchTree.Add(nodeSix, 34);
            testBinarySearchTree.Add(nodeSix, 55);
            Assert.False(testBinarySearchTree.Contains(nodeSix, 66));
        }
        [Fact]
        public void AddBinarySearchTreeFalse2()
        {
            Node nodeSix = new Node(6);
            BinarySearchTree testBinarySearchTree = new BinarySearchTree();
            testBinarySearchTree.Add(nodeSix, 2);
            testBinarySearchTree.Add(nodeSix, 4);
            testBinarySearchTree.Add(nodeSix, 9);
            Assert.False(testBinarySearchTree.Contains(nodeSix, 5));
        }
        [Fact]
        public void AddBinarySearchTreeFalse3()
        {
            Node nodeSix = new Node(6);
            BinarySearchTree testBinarySearchTree = new BinarySearchTree();
            testBinarySearchTree.Add(nodeSix, 23);
            testBinarySearchTree.Add(nodeSix, 34);
            testBinarySearchTree.Add(nodeSix, 55);
            Assert.False(testBinarySearchTree.Contains(nodeSix, 77));
        }

    }
}
