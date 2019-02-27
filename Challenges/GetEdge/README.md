# Data-Structures-and-Algorithms
## Code Challenge: Get Edge

## Collaborators
```
Carlos Roberto Castillo
```

# Use Breadth-First on an Adjacency List representaion of a graph.
<!-- Short summary or background information -->
Given a graph object and string array or cities, return if a trip is possible.
If so, how much?


## Challenge
<!-- Description of the challenge -->
The challenge was to create a Method that would accept an Adjecency List as a graph and a string array of city names for nodes.

Return a Tuple of boolean and integer.

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? --> 

I created a nethod that took in a graph and string array.
 Instantiate a new Tuple fot the output.
 Instantiate a new Dictionary to get the Neighbors to the string input.
 traverse through the string array cities.
 Compare the string cities with the neighbors.
 If true, add true and weight to the Tuple.
 Return the final output of the Tuple..


### Big O Notation.
```
The Big O of time: O(n)  => has to traverse through all nodes in the graph.
The Big O of space: O(n)  => size stays the same during the method.
```

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described.
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a method called int BreadthFirst()
- [x] Create a branch in your repository named breadth-first-graph
- [x] Create xUnit Tests (at least three per method).
- [?] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/GetEdge.jpg?raw=true)


Lab started on February 26, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.