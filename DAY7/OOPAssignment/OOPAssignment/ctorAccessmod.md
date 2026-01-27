## Constructor Validation

Constructor validation ensures an object is always valid after creation.

Benefits:

* Prevents invalid objects
* Centralizes validation logic
* Improves reliability
* Enforces business rules early

##  Access Modifiers 
| Access Modifier        |  Where It Can Be Accessed                               |
| ---------------------- |  -------------------------------------------------------|
| **public**             |  Anywhere (same class, same project, other projects)    |
| **private**            |  Only within the same class                             |
| **protected**          |  Same class **and** derived classes                     |
| **internal**           |  Anywhere in the same assembly (project)                |
| **protected internal** |  Same assembly **or** derived class in another assembly |
**private protected**  |  Same class **and** derived classes **in same assembly**  |
