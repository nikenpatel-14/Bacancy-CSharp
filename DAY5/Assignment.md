# Assignment

## Performance impact of boxing

### Boxing :

It means to convert value type to oject type.

Example:-

```
int n = 10;
object o = n;
```

Above mentioned is boxing concept.

### Unboxing :

it means convert object type to value type.

Example:-

```
int n = (int)o;
```

Above mentioned is unboxing concept.

### Impact on performance.

- Allocates memory on heap
- Causes extra copying
- Slows down loops & high-frequency code
- when process of boxing and unboxing happens then it create overhead for the compiler system.many times it happen in repeated manner which cause slower execution.
  \*Boxed value is wrapped inside an object
- Uses more memory than raw value
- Large structs ? bigger memory cost
- Boxed objects must be garbage collected
- Frequent boxing ? frequent GC runs
- Causes application slowdowns / pauses

---

## Delegates vs Interfaces

### Delegate

- Represents a method / function
- Used to pass behavior
- Supports only one method signature
- Points to one or more methods (multicast)
- Provides loose coupling
- Best suited for callbacks and events

### Interface

- Represents a contract (set of behaviors)
- Used to define capability
- Can contain multiple methods, properties, and events
- Implemented by classes or structs
- A class can implement multiple interfaces
- Provides structured and scalable design
- Commonly used in Strategy / Contract-based architecture
