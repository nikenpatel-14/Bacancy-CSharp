
## 🔹 Assignment 2 – Theory (Research-Based)

### What is .NET?

.NET is a free, open-source developer platform by Microsoft used to build web, desktop, mobile, cloud, IoT, and enterprise applications.
It provides:

* A runtime (CLR)
* Base Class Library (BCL)
* Multiple programming languages (C#, F#, VB.NET)

---

### Difference between .NET Framework, .NET Core, and .NET (Latest)

| Feature     | .NET Framework | .NET Core      | .NET (Latest)      |
| ----------- | -------------- | -------------- | ------------------ |
| Platform    | Windows only   | Cross-platform | Cross-platform     |
| Performance | Moderate       | High           | Very High          |
| Deployment  | System-wide    | Side-by-side   | Side-by-side       |
| Open Source |  No            | Yes            | Yes                |
| Status      | Legacy         | Discontinued   | Actively developed |


### Role of C# in the .NET Ecosystem

* Primary programming language for .NET
* Used for **ASP.NET, Web APIs, Desktop apps, Microservices**
* Strongly typed, object-oriented, modern language
* Deep integration with .NET libraries and tools

---

## 🔹 Assignment 5 – Theory

### Why Nullable Types Were Introduced

* To **avoid null reference exceptions**
* To make **null handling explicit**
* To improve **code safety and readability**
* To catch null-related bugs at compile time

---

### Scenarios Where Nullable Types Are Preferred

* Database fields that can be NULL
* Optional method parameters
* API responses where values may be missing
* Safer enterprise-level applications



## 🔹 Assignment 7 – Comparison Table

### `const` vs `readonly`

| Feature          | `const`                     | `readonly`                 |
| ---------------- | --------------------------- | -------------------------- |
| Initialization   | At declaration only         | Declaration or constructor |
| Runtime Behavior | Compile-time constant       | Runtime value              |
| Use Cases        | Fixed values (PI, MaxLimit) | Values known at runtime    |

