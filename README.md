# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property before it has been initialized.  Uninitialized properties will have their default value (0 for integers, null for references etc.), which might not be what the code expects, leading to unexpected results or exceptions.

The `bug.cs` file contains the code with the error. The `bugSolution.cs` file shows the corrected code.

## How to reproduce the error:
1. Compile and run `bug.cs`
2. Observe the output (0).  The code did not throw an exception, but the default value is used.

## How to fix it (see `bugSolution.cs`):
1. Initialize the property within the class declaration or constructor.
2. Ensure proper value assignment before using the property.