# data-structures-and-algorithms

## Queue Line Bribes

#### Coding during covid

### Challenge
* Start by having a array act as a queue for a line to a famous roller coster ride.
* Each rider is given a number in sequential order starting from 1 to whatever the last person is.
* A rider standing in line can bribe a person ahead of the rider to get ahead.  Max of two bribes per rider.
* The numbers assigned to the rider in the begginning do NOT change.  (i.e. rider 4 will always have the number 4 as a badge.  Even if they bribe to move ahead of the line.)
* Determine the min number of bribes that took place looking at the new line.
* IF it appears someone bribed more than twice, return "Too chaotic".
* Otherwise return a number.

#### Example
- Input:  q = [1,2,3,4,5,6,7]
- Output: 0
The q line did not change.  So ZERO bribes.
-   
     


- Input:  q = [2,1,3,4,5,6,7]
- Output: 1
The q line changed.  2 did a bribe to get ahead of 1.
-   



- Input:  q = [1,2,3,7,4,5,6]
- Output: Too Chaotic
The q line changed.  7 bribed three or more times.
-     



- Input:  q = [2,1,5,3,4,8,6,7,10,9]
- Output: 6
The q line changed.  A minumim of 6 bribes took place.  2-once, 5-twice, 8-twice, 10-once
- 







```
Carlos Castillo
```
Challenge started on Sept 05, 2020