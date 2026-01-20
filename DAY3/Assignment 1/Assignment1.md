


# Loops Control in C#

---

## Infinite Loops

An **infinite loop** is a loop that runs continuously and never stops because its terminating condition is never met.

---

###  Causes of Infinite Loops
- Loop condition is always true
- Loop variable is not updated
- Logical error in condition
- Missing `break` statement

---

###  Examples

#### Infinite `while` loop
```csharp
while (true)
{
    Console.WriteLine("This loop never ends");
}
````

#### Infinite `for` loop

```csharp
for (;;)
{
    Console.WriteLine("Infinite loop");
}
```



###  How to Stop an Infinite Loop

* Use `break`
* Correct loop condition
* Properly update loop variables



## `break` vs `continue`

Both `break` and `continue` are loop control statements in C#.



### break

* Terminates the loop completely
* Control moves outside the loop
* Used to exit a loop early

#### Example

```csharp
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
        break;

    Console.WriteLine(i);
}
```

**Output:**

```
1
2
```

---

### continue

* Skips the current iteration
* Control moves to the next iteration
* Loop continues execution

#### Example

```csharp
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
        continue;

    Console.WriteLine(i);
}
```

**Output:**

```
1
2
4
5
```



## Difference Between `break` and `continue`

Both `break` and `continue` are loop control statements used in C#.

| Feature | `break` | `continue` |
|------|--------|------------|
| Purpose | Terminates the loop completely | Skips the current iteration |
| Loop execution | Loop stops immediately | Loop continues to next iteration |
| Control flow | Moves outside the loop | Moves to next loop cycle |
| Usage | Used to exit loop early | Used to skip a specific condition |
| Common use case | Stop searching when result is found | Skip unwanted values |
