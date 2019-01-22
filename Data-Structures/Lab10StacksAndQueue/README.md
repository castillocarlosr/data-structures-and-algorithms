# data-structures-and-algorithms
## Code Challenge 10 Stacks and Queue
Code401 

# Create a Stacks and Queue with all its features.
<!-- Short summary or background information -->
Create a Stack that contains a method for Push, Pop, and Peek.
Create a Queue that contains a method for Enqueque, Desqueque, and Peek.

## Challenge
<!-- Description of the challenge -->
Stacks:
- Be able to create a stack with a default of null.
- Define a Top property for the new stack.
- Define a method Push() which takes any value and adds a new node to the Top of the stack.
- Define a method Pop() which removes the node from the Top of the stack and returns that value.  New Top is assigned.
- Define a method Peek() which returns the Top value.  
Queue:
- Be able to create an empty (null) queue without returning an exception.
- Define a Front & Rear property for the new queue.
- Define a method Enqueue() which takes any value and adds a new node to the Rear of the queue.
- Define a method Desqueue() which removes the node from the front of the queue and returns that value.  New Front is assigned.
- Define a method Peek() which returns the Front value.  

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was creating a three classes.  Node class, Stack class, and Queue class.
- Created properties in the Node class for value and next.  Created method Node.
- Created property in the Stack class for Top.  Created methods for Push, Pop, and Peek.
- Created properties in the Queue class for Front and Rear.  Created methods for Enqueque, Desqueue, and Peek.

## Big O Notation
* The method "Push" is:  Big O(1).
* The method "Pop" is:  Big O(1).
* The method "Peek" in stack is:  Big O(1).
* The method "Enqueque" is:  Big O(1).
* The method "Desqueue" is:  Big O(1).
* The method "Peek" in queue is:  Big O(1).


### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described.
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository called stacks_and_queue
- [x] Create xUnit Tests, at least three per method
- [X] Pass all Tests.

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/StacksAndQueue.PNG?raw=true)

Lab started on January 20, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle..
