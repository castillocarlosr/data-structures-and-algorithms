using System;
using Xunit;
using HeightBinaryTree.Classes;

namespace HeightBinaryTreeTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to find the max height in a tree
        /// </summary>
        [Fact]
        public void HeightTest1()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);

            Assert.Equal(2, tree.CalculateBinaryTreeHeight(tree.Root));
        }
        //Test for same height but different number of nodes
        [Fact]
        public void HeightTest2()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);
            tree.Root.RightChild.LeftChild = new Node(7);

            Assert.Equal(2, tree.CalculateBinaryTreeHeight(tree.Root));
        }
        [Fact]
        public void HeightTest3()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);
            tree.Root.RightChild.LeftChild = new Node(7);
            tree.Root.RightChild.LeftChild.LeftChild = new Node(8);

            Assert.Equal(3, tree.CalculateBinaryTreeHeight(tree.Root));
        }

        /// <summary>
        /// Test for number of levels in a tree
        /// </summary>
        [Fact]
        public void LevelsTest1()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);

            Assert.Equal(3, tree.Levels(tree.Root));
        }
        //Test for same number of levels but different number of nodes.
        [Fact]
        public void LevelsTest2()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);
            tree.Root.RightChild.LeftChild = new Node(7);

            Assert.Equal(3, tree.Levels(tree.Root));
        }
        [Fact]
        public void LevelsTest3()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);
            tree.Root.RightChild.LeftChild = new Node(7);
            tree.Root.RightChild.LeftChild.LeftChild = new Node(8);

            Assert.Equal(4, tree.Levels(tree.Root));
        }
    }
}
