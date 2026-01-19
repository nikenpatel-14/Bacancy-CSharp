
# C# Assignments – Theory

---

## Assignment 2 – Theory



==
Operator
Checks value or reference equality
Faster for primitive types
Cannot be overridden

Equals()
Method
Checks object content
Used for logical equality
Can be overridden

###  Short-Circuit Behavior in Logical Operators

Short-circuiting means **the second condition is not evaluated** if the result is already determined.

| Operator | Behavior                          |   |                                  |
| -------- | --------------------------------- | - | -------------------------------- |
| '&&'     | Stops if first condition is false |   |                                  |
| '||'     | Stops if first condition is true  |                                 | 


**Advantages:**

* Improves performance
* Prevents runtime errors

---

## Assignment 4 – Theory

###  When `switch` Is Preferable

`switch` is preferred when:

* Comparing a single variable with multiple values
* Replacing long `if-else` ladders
* Working with menus or enums
* Improving readability



###  Modern `switch` Enhancements (C# 7+)

Modern C# introduced **pattern matching** and **switch expressions**.

pattern matching:
 case int m when (m >= 90):

switch expression:
  >= 90 => "Excellent",

**Features:**

* Range checks
* Cleaner syntax
* Less boilerplate code



##  Assignment 6 – Theory

### Parameter Passing Mechanisms in C#

| Mechanism | Keyword | Description                   |
| --------- | ------- | ----------------------------- |
| Value     | Default | Passes a copy of value        |
| Reference | `ref`   | Modifies original value       |
| Output    | `out`   | Returns value via parameter   |

ref Parameter
The ref keyword is used when you want to pass an already initialized variable to a method and allow the method to modify it.
Key points:
Variable must be initialized before passing
Method may or may not modify the value
Changes affect the original variable
Data flows into and out of the method

Example explanation:
A value is passed to a method using ref, modified inside the method, and the updated value is reflected in the calling method.

out Parameter
The out keyword is used when you want a method to return multiple values or assign a value inside the method.
Key points:
Variable does NOT need to be initialized before passing
Method must assign a value before returning
Used only for output
Data flows out of the method
Example explanation:
A variable is passed using out, the method assigns a value, and the calling method receives it.

### Difference between Returning Values and `void`

| Feature             | Return Value              | `void`              |
| ------------------- | -------------------------   | ------------------- |
| Returns data        |  Yes                     |  No                |
| Used in expressions |  Yes                     |  No                |
| Purpose             | Compute and return result   | Perform action only |
