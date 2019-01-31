using System;
using Xunit;
using FindMaxValueBinaryTree.Classes;
using FindMaxValueBinaryTree;
using System.Collections.Generic;

namespace FindMaxTDD
{
    public class UnitTest1
    {
        [Fact]
        public void FindMaxTestOne()
        {
            Node root = new Node(3);
            Node nodeTwo = new Node(4);
            Node nodeThree = new Node(6);
            BinaryTree tree = new BinaryTree(root);
            tree.Root.LeftChild = nodeTwo;
            tree.Root.RightChild = nodeThree;
            Assert.Equal(6, Program.FindMaxValue(root));
        }

        [Fact]
        public void FindMaxTestTwo()
        {
            Node root = new Node(99);
            Node nodeTwo = new Node(42);
            Node nodeThree = new Node(66);
            BinaryTree tree = new BinaryTree(root);
            tree.Root.LeftChild = nodeTwo;
            tree.Root.RightChild = nodeThree;
            Assert.Equal(99, Program.FindMaxValue(root));
        }

        [Fact]
        public void FindMaxTestThree()
        {
            Node root = new Node(3);
            Node nodeTwo = new Node(4);
            Node nodeThree = new Node(555);
            Node nodeFive = new Node(111);
            Node nodeSix = new Node(12);
            BinaryTree tree = new BinaryTree(root);
            tree.Root.LeftChild = nodeTwo;
            tree.Root.RightChild = nodeThree;
            tree.Root.LeftChild.LeftChild = nodeSix;
            tree.Root.LeftChild.RightChild = nodeFive;
            Assert.Equal(555, Program.FindMaxValue(root));
        }
    }
}
