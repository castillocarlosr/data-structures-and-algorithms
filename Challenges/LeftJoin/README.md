# Data-Structures-and-Algorithms
## Code Challenge: Tree Intersection

## Collaborators
```
Carlos Roberto Castillo
```

# Find the height of a binary tree.
<!-- Short summary or background information -->
Given two hashtables, find the common keys on both tables.

Add the values of the second table to the key of the first table.
## Challenge
<!-- Description of the challenge -->
The challenge was to create a Method that would accept two hashtables.

Find the keys in the second table that match the first table.  

Add the values of the second table to the key of the first table.  

Return the result in any data structure.

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was to bring in the HashTable class used in a previously code challenge.  

I created a mnethod that took in two hashtables.
 Instantiate a new List<string> for the final output.
 I pass the first hashtable into the List<string>.
 While passing in table1, I check table 2 if any keys match table 1.
 If it does, add the value only to the List<string> after the value of table one.
 Return the final output List.


### Big O Notation.
```
The Big O of time: O(n)  
The Big O of space: O(n)  
```

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described.
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a method called int LeftJoin()
- [x] Create a branch in your repository named left_join
- [x] Create xUnit Tests (at least three per method).
- [?] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/LeftJoin.jpg?raw=true)


Lab started on February 20, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.