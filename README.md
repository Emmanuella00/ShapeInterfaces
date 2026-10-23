# ShapeDemo

C# console project using an IShape interface, implemented by Trapezium, Circle and Nonagon, and tested in Program.cs.


## Run
Open a terminal in the project folder and run `dotnet run`.

## Interface
`IShape` has only the methods all three shapes share: `CalculateArea()` and `CalculatePerimeter()`. 
## SOLID principle: Dependency Inversion
- **What it says:** Code should depend on an abstraction (an interface), not on specific classes.
- **Where applied:** In `Start()`, each shape is stored as an `IShape` (e.g. `IShape shape1 = new Trapezium();`) and the shared methods are called through it.
- **Why:** Without it, the test code would be tied to each concrete class, and adding a new shape would mean changing that code.

