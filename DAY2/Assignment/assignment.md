
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
| '||'        |                                   | ` | Stops if first condition is true |


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



### Difference between Returning Values and `void`

| Feature             | Return Value              | `void`              |
| ------------------- | -------------------------   | ------------------- |
| Returns data        |  Yes                     |  No                |
| Used in expressions |  Yes                     |  No                |
| Purpose             | Compute and return result   | Perform action only |
