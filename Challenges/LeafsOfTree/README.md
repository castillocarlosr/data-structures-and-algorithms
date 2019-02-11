# data-structures-and-algorithms
## Code Challenge EC2: Mock Interview Implementation
Code401 

## Collaborators
```
Carlos Roberto Castillo
```

# Compare two file directories structures.
<!-- Short summary or background information -->
Comparing two different file directories, create a method that takes in 2 directory structures and compares both and determines whether or not they have the same number of individual files.

Return as true or false.

## Challenge
<!-- Description of the challenge -->
The challenge was to create a Method that would accept two trees that contain folders/files (directories) and count the number of individual files for both trees.  If the same number of files on both trees, return true.  Else, return false.


## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was creating a Node class that accepts a string.  The string can be used as a pathway for directories.  

I created a File Structure-Tree-Class that would take in a Tree and count the number of **leafs** that tree had.  What was in the individual Nodes was irrelevent.

I created a Compare-Two-Trees-Class and method Leafs-In-Two-Trees that would take in two seperate trees and compare the number of leafs each tree has using the Total-Leaf-Count method from the Structure-Tree-Class.  If the number of leafs of both trees are the same, the method Leafs-In-Two-Trees would return true.  Else it would return false.

### Big O Notation.
```
The Big O of time: O(n)
The Big O of space: O(n) 
```
Both are O(n) beacuse the structure of the tree is unknown and has to traverse through every node to determine if that node is a leaf or has more children.

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository with appropriate name of EC2: Interview 02:
- [x] Create xUnit Tests (at least three per method).  TotalLeafsCount method and CompareTwoTrees method.
- [x] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/Jan31WhiteBoard.jpg?raw=true)
![](../../assets/EC2.PNG?raw=true)

Lab started on February 10, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.