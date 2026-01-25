# Assignment
---

## Async programming vs Multithreading

### Async programming
Async programming is a non-blocking execution model that allows a thread to be released during I/O operations and resumed using continuations when the operation completes.

* Task-based model
* Designed for I/O-bound operations
* Uses async / await
* Does not create new threads (by default)
* Non-blocking execution
* Releases thread during wait
* Uses continuations
* High scalability
* Low resource consumption

### Multi-threading
Multithreading is a programming technique where multiple threads execute concurrently within a single process to perform parallel CPU-bound operations.
* Thread-based model
* Designed for CPU-bound operations
* Uses Thread, Parallel, Task.Run
* Creates multiple threads
* Blocking possible
* Threads share memory
* Requires synchronization
* Context switching overhead
* Lower scalability

---

## Common Async Pitfalls
Async pitfalls are errors that occur when async/await is used incorrectly, especially when async code is mixed with blocking or synchronous code.

* Blocking async code using .Wait() or .Result
* Sync-over-async causing deadlocks
* Using async void instead of async Task
* Forgetting to await an async method
* Assuming async creates new threads
* Using Task.Run for I/O-bound work
* Not handling exceptions from async methods
