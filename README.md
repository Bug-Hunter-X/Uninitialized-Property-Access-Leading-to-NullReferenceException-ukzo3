# Uninitialized Property Access Leading to NullReferenceException

This repository demonstrates a common C# error: a `NullReferenceException` occurring when accessing a property of a class that hasn't been initialized.

The `bug.cs` file contains the problematic code. The `bugSolution.cs` file shows how to avoid the error.

## How to reproduce the bug

1.  Compile and run `bug.cs`.
2.  Observe the `NullReferenceException`.

## How to fix the bug

Refer to the code in `bugSolution.cs` for the solution. This involves ensuring that the property is initialized before being accessed, either through constructor initialization, or explicit assignment before use.