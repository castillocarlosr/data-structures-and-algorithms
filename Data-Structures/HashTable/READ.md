# data-structures-and-algorithms
## Implementation Hash Tables
Code401 

## Collaborators
- Carlos Roberto Castillo

# Implement a Hashtable
<!-- Short summary or background information -->
Implement a Hashtable with following methods:
1. add
2. get
3. contains
4. hash

## Challenge
<!-- Description of the challenge -->
Create a Hashtable without using the pre built in HashTable.
- Create method for hash that takes in a key and returns the index in the collection,
- Create method for add that takes in a key and value.
- Create method for get that takes in a key and returns the value from the table.
- Create method for contains that takes in a key and returns a boolean.


## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was creating a Node list and Linked List class.  The Hashtable class would use Nodes and LinkedList when there is a collision for the same key.

## Big O Notation
* The method Add is: Big O(1) because the hash function provides the index.
* The method Find is: Big(1) because the key is known.  Worst case: O(n) is all values are in the same key/index.
* The method Contains is: Big(1) because the key is known.  Worst case: O(n) is all values are in the same key/index.
* The method GetHash is: O(1) because it takes in a key and calculates the index number.

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment
- [x] Do all your work in a public repository called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a class called HashTables
- [x] Create a branch in your repository called hashtable
- [x] Create xUnit Tests (at least three)
- [X] Pass all Tests.  Tests include AddKeyValue, GetValue, GetNull, GetCollision1, GetTrue, & GetFalse.

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/HashTable.PNG?raw=true)

Lab started on February 17, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle..