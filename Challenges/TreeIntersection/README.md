# Data-Structures-and-Algorithms
## Code Challenge: Tree Intersection

## Collaborators
```
Carlos Roberto Castillo
```

# Find the height of a binary tree.
<!-- Short summary or background information -->
Given two binary trees, find the common values.

Return the common values.

## Challenge
<!-- Description of the challenge -->
The challenge was to create a Method that would accept two binary trees.  Traverse through the tree nodes.    Find all the common node values that exsist in both trees.

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was to bring in the HashTable class used in a previously code challenge.
 I also brought in the Tree class used in a much earlier code challenge.  Used to create the binary trees.  

I created a nethod that took in two binary trees.
 Instantiate a new HashTable.
 Instantiate a new List<int> for the final output.
 I pass each binary tree separately into their own List<int> using the PreOrder method.
 I add all the values of the first binary tree into the HashTable.
 Using a for loop, I use the second binary tree List to check if the HashTable contains that item.
 If it does add it to the final output List<int>.
 Return the final output List.


### Big O Notation.
```
The Big O of time: O(n)  => has to traverse through all nodes in both binary tree.
The Big O of space: O(n)  => size stays the same during the method.
```

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described.
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a method called int TreeIntersection()
- [x] Create a branch in your repository named tree_intersection
- [x] Create xUnit Tests (at least three per method).
- [x] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/TreeIntersection.jpg?raw=true)
![](../../assets/TreeIntersection.PNG?raw=true)

Lab started on February 19, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.