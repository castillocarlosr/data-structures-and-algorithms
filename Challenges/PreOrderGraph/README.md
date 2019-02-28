# Data-Structures-and-Algorithms
## Code Challenge: Breadth First on Graph

## Collaborators
```
Carlos Roberto Castillo
```

# Use Breadth-First on an Adjacency List representaion of a graph.
<!-- Short summary or background information -->
Given a graph object, use Depth-First  PreOrder traversal to return all nodes.

Return all the vertices/nodes.

## Challenge
<!-- Description of the challenge -->
The challenge was to create a Method that would accept an Adjecency List as a graph and return all the vertices using Breadth First.

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? --> 

I created a nethod that took in a root vertice.
 Instantiate a new List<Vertex> for the final output.
 I pass each vertice separately into their own List<Vertex> using the Depth-First method.
 Return the final output List.


### Big O Notation.
```
The Big O of time: O(n)  => has to traverse through all nodes in the graph.
The Big O of space: O(1)  => size stays the same during the method.
```

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described.
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a method called int DepthFirst()
- [x] Create a branch in your repository named depthFirst
- [x] Create xUnit Tests (at least three per method).
- [?] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/PreOrderGraph.jpg?raw=true)


Lab started on February 27, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.