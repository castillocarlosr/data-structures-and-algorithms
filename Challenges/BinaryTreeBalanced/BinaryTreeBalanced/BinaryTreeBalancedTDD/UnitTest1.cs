using System;
using Xunit;
using BinaryTreeBalanced.Classes;

namespace BinaryTreeBalancedTDD
{
    public class UnitTest1
    {
        [Fact]
        public void BalancedTrueTest1()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);

            Assert.True(tree.IsBinaryTreeBalanced(tree.Root));
        }
        [Fact]
        public void BalancedTrueTest2()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);

            Assert.True(tree.IsBinaryTreeBalanced(tree.Root));
        }
        [Fact]
        public void BalancedTrueTest3()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);
            tree.Root.RightChild.LeftChild = new Node(7);
            tree.Root.LeftChild.LeftChild.LeftChild = new Node(8);
            tree.Root.RightChild.LeftChild.LeftChild = new Node(9);

            Assert.True(tree.IsBinaryTreeBalanced(tree.Root));
        }

        [Fact]
        public void BalancedFalseTest1()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.RightChild = new Node(2);
            tree.Root.RightChild.RightChild = new Node(3);

            Assert.False(tree.IsBinaryTreeBalanced(tree.Root));
        }
        [Fact]
        public void BalancedFalseTest2()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.LeftChild = new Node(4);
            tree.Root.LeftChild.LeftChild.RightChild = new Node(5);

            Assert.False(tree.IsBinaryTreeBalanced(tree.Root));
        }
        [Fact]
        public void BalancedFalseTest3()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.LeftChild = new Node(2);
            tree.Root.RightChild = new Node(3);
            tree.Root.LeftChild.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(5);
            tree.Root.RightChild.RightChild = new Node(6);
            tree.Root.RightChild.LeftChild = new Node(7);
            tree.Root.LeftChild.LeftChild.LeftChild = new Node(8);
            tree.Root.LeftChild.LeftChild.LeftChild.LeftChild = new Node(9);

            Assert.False(tree.IsBinaryTreeBalanced(tree.Root));
        }
    }
}
