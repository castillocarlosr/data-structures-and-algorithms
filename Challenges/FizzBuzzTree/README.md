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
Create a console application to traverse through a binary tree and change the values of nodes depenent on node value.

## Challenge
<!-- Description of the challenge -->
```
The challenge was to create a Method that would accept a binary tree and traverse throught the tree.  The nodes would change from integer to string depending on the value of the node.  Dependency below.
* If the value is divisible by 3, replace the value with “Fizz”
* If the value is divisible by 5, replace the value with “Buzz”
* If the value is divisible by 3 and 5, replace the value with “FizzBuzz”
```

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
- The approach I took was creating a method called FizzBuzzTree(BinaryTree treeinput).

- The method would traverse through the tree using the PreOrder method.

- A new tree is created and and filled with either the original values as string, or "Fizz", "Buzz", or "FizzBuzz".

- The tree will return a display as a list showing the results.
 
### Big O Notation.
```
The Big O of time: O(n)
The Big O of space: O(n) 
```

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository called FizzBuzzTree
- [x] On your branch, create a method named bool FizzBuzzTree() outside of Main() in your Program.cs file. 
- [x] Call Your newly created method in Main() once complete.
- [x] Create xUnit Tests (at least three per method).  Only one method.
- [x] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/FizzBuzzTree.jpg?raw=true)
![](../../assets/FizzBuzzTree.PNG?raw=true)

Lab started on January 28, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.
