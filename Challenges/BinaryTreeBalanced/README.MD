# Data-Structures-and-Algorithms
## Code Challenge Snow Day DSA: Binary Tree Balanced

## Collaborators
```
Carlos Roberto Castillo
```

# Find the height of a binary tree.
<!-- Short summary or background information -->
Given a binary tree, determine if the tree is balanced.

Return as true or false.

## Challenge
<!-- Description of the challenge -->
The challenge was to create a Method that would accept a binary tree and determine if the tree is balanced or not.
A proper definition of a balnced binary tree as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.


## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was creating a Node class that accepts an integer.  

I created a BinaryTree-Class with two methods.
Method CalculateBinaryTreeHeight would accept a tree and find the height of that tree.
Method IsBinaryTreeBalanced would accept that same tree and determine if the leftDepth subtree and rightDepth subtree are within the absolute value of each other to 1 or less.
Return true if so or else return false.

### Big O Notation.
```
The Big O of time: O(n)  => has to traverse through every node.
The Big O of space: O(h)  => h for the height of the tree.
```

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment 
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a method called bool IsBinaryTreeBalanced(Node root)
- [x] Create a branch in your repository with appropriate name of SnowDayDSA
- [x] Create xUnit Tests (at least three per method).  IsBinaryTreeBalanced method for true and false.
- [x] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/BalancedTree.jpg?raw=true)
![](../../assets/BalancedTree.PNG?raw=true)

Lab started on February 11, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.