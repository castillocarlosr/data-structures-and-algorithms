using System;
using Xunit;
using BreadthFirstTraversal;
using Trees.Classes;
using System.Collections.Generic;

namespace BreadthFirstTDD
{
    public class UnitTest1
    {
        [Fact]
        public void BreadthTestOne()
        {
            Node root = new Node(2);
            Node nodeTwo = new Node(4);
            Node nodeThree = new Node(6);
            Node nodeFour = new Node(8);
            Node nodeFive = new Node(10);
            BinaryTree breadthTree = new BinaryTree(root);
            breadthTree.Root.LeftChild = nodeTwo;
            breadthTree.Root.RightChild = nodeThree;
            breadthTree.Root.LeftChild.LeftChild = nodeFour;
            breadthTree.Root.LeftChild.RightChild = nodeFive;
            List<int> testList = new List<int>() { 2, 4, 6, 8, 10};

            Assert.Equal(testList, Program.BreadthFirst(root));
        }

        [Fact]
        public void BreadthTestTwo()
        {
            Node root = new Node(1);
            Node nodeTwo = new Node(3);
            Node nodeThree = new Node(5);
            Node nodeFour = new Node(7);
            Node nodeFive = new Node(9);
            BinaryTree breadthTree = new BinaryTree(root);
            breadthTree.Root.LeftChild = nodeTwo;
            breadthTree.Root.RightChild = nodeThree;
            breadthTree.Root.LeftChild.LeftChild = nodeFour;
            breadthTree.Root.LeftChild.RightChild = nodeFive;
            List<int> testList = new List<int>() { 1, 3, 5, 7, 9 };

            Assert.Equal(testList, Program.BreadthFirst(root));
        }

        [Fact]
        public void BreadthTestThree()
        {
            Node root = new Node(2);
            Node nodeTwo = new Node(4);
            Node nodeThree = new Node(6);
            Node nodeFour = new Node(8);
            Node nodeFive = new Node(10);
            Node nodeSix = new Node(12);
            Node nodeSeven = new Node(14);
            Node nodeEight = new Node(16);
            Node nodeNine = new Node(18);
            Node nodeTen = new Node(21);
            BinaryTree breadthTree = new BinaryTree(root);
            breadthTree.Root.LeftChild = nodeTwo;
            breadthTree.Root.RightChild = nodeThree;
            breadthTree.Root.LeftChild.LeftChild = nodeFour;
            breadthTree.Root.LeftChild.RightChild = nodeFive;
            breadthTree.Root.RightChild.LeftChild = nodeSix;
            breadthTree.Root.RightChild.RightChild = nodeSeven;
            breadthTree.Root.LeftChild.RightChild.LeftChild = nodeEight;
            breadthTree.Root.LeftChild.RightChild.RightChild = nodeNine;
            breadthTree.Root.RightChild.RightChild.RightChild = nodeTen;
            List<int> testList = new List<int>() {2, 4, 6, 8, 10, 12, 14, 16, 18, 21 };

            Assert.Equal(testList, Program.BreadthFirst(root));
        }
    }
}
