# data-structures-and-algorithms
## Code Challenge 12 First-in, First out Animal Shelter.
Code401 

## Collaborators
```
- Carlos Roberto Castillo
- Sean Miller
```


# Create a PseudoQueue class
<!-- Short summary or background information -->
Create a new Queue for Animal Shelter that dequeue specific animals.

Return that value.

## Challenge
<!-- Description of the challenge -->
```
The challenge was to create a Queue for an animal shelter that accepts a "dog" or "cat" on a first-in, first-out FIFO implementation.
```

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was creatinan Animal class and a new Node to accept strings instead of int.  The Animal class would accept a type of animal.

I created a Animal Shelter class that would accept any type of animal.  However, the shelter would only accept a "dog" or "cat" into the shelter with Enqueue.

The Animal Shelter class would also allow to "adopt" an animal from the class queue.  Only possible animals would be a "cat" or "dog".  If another animal is requested, the Dequeue would give the animal that's been there the longest.

The Queue order would stay the same accept for any animal that is requested to be adopted.  That one is taken out of the queue.  If multiple animals of the same type are in the queue, it's the cklosest one to the front.


### Big O Notation.
```
Enqueue
The Big O of time: O(1)
The Big O of space: O(1) 

Dequeue
The Big O of time: O(n)
The Big O of space: O(1) 
```

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository called fifo_animal_shelter
- [x] On your branch, create a method named FIFOAnimalShelter() outside of Main() in your Program.cs file. - [x] Call Your newly created method in Main() once complete.
- [x] Create xUnit Tests (at least three per method).  Enqueue method and Dequeue method
- [x] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/FIFOAnimal.jpg?raw=true)
![](../../assets/FIFOShelter.PNG?raw=true)

Lab started on January 23, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.
