# Collections in C#

This document explains the difference between Array and List, and also describes how Dictionary works internally in a simple way.

---

## Array vs List

Both Array and List are used to store multiple values in C#, but they work differently.

---

### Array

An array is a collection that stores a fixed number of elements of the same type.

Once an array is created, its size cannot be changed.

Example:
csharp
int[] numbers = { 10, 20, 30 };


---

### Key points about Array:

*   Size is fixed
*   Faster access to elements
*   Uses less memory
*   Stored in continuous memory
*	Arrays are useful when we know the number of elements in advance.

---
## List


 List is a dynamic collection provided by .NET.
It can grow or shrink during program execution.

### Example:

List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);


### Key points about List:

   * Size can change dynamically
   * Easy to add and remove elements
   * Internally uses an array
   * More flexible than array
   * List is commonly used in real applications.
	
## Internal Working of Dictionary

When we add a value to a dictionary, the following steps happen:

* The key generates a hash code.
* The hash code decides where the value will be stored.
* Dictionary stores the value in a bucket.
* If two keys go to the same bucket, dictionary handles it safely.

When searching for a key:

* Dictionary calculates the hash code again
* Finds the correct bucket
* Returns the value quickl 

## Working of Dictionary

   When we add a value to a dictionary, the following steps happen:

* The key generates a hash code.
* The hash code decides where the value will be stored.
* Dictionary stores the value in a bucket.
* If two keys go to the same bucket, dictionary handles it safely.

When searching for a key:

Dictionary calculates the hash code again
Finds the correct bucket
Returns the value quickly


## Why Dictionary Is Fast
* It does not search all elements
* It directly finds data using the key
* Average search time is very fast

Conclusion

Array is best when size is fixed.
List is better when size can change.
Dictionary is useful for fast key-based searching.