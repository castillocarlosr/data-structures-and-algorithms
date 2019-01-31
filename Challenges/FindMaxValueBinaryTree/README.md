# data-structures-and-algorithms
## Code Challenge 13 Multi-bracket Validation.
Code401 

## Collaborators
```
- Carlos Roberto Castillo
- Xia Liu
```


# Create a Multi-bracket Validation
<!-- Short summary or background information -->
Create a console application to traverse through a binary tree and returns the maximum value.

## Challenge
<!-- Description of the challenge -->
```
The challenge was to create a Method that would accept a binary tree and traverse through the tree using any method and return to the console the max value in the tree.
```

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
- The approach I took was creating a method called FindMaxValueInTree().
- Create a stack to push the nodes from the tree into the stack.
- If a node is greater than the top of the node, it would push into the stack.
- When complete, return the top of the node which is the maximum value.

 
### Big O Notation.
```
The Big O of time: O(n)
The Big O of space: O(h)  h=height
```

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository called find-maximum-value-binary-tree
- [x] On your branch, create a method named FindMaxValue() outside of Main() in your Program.cs file. 
- [x] Call Your newly created method in Main() once complete.
- [x] Create xUnit Tests (at least three per method).  Only one method.
- [x] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/MaxValueTree.jpg?raw=true)

Lab started on January 30, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.
