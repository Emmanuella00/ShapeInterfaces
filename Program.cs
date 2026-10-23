using System;


public class InterfaceTestScript
{
    static void Main()
    {
        InterfaceTestScript test = new InterfaceTestScript();
        test.Start();
    }

    public void Start()
    {
        IShape shape1 = new Trapezium();
        Console.WriteLine("Trapezium area: " + shape1.CalculateArea());
        Console.WriteLine("Trapezium perimeter: " + shape1.CalculatePerimeter());

        IShape shape2 = new Circle();
        Console.WriteLine("Circle area: " + shape2.CalculateArea());
        Console.WriteLine("Circle perimeter: " + shape2.CalculatePerimeter());

        IShape shape3 = new Nonagon();
        Console.WriteLine("Nonagon area: " + shape3.CalculateArea());
        Console.WriteLine("Nonagon perimeter: " + shape3.CalculatePerimeter());

        Trapezium trapezium = new Trapezium();
        Console.WriteLine("Trapezium unknown side: " + trapezium.CalculateUnknownSides(9.7));

        Circle circle = new Circle();
        Console.WriteLine("Circle radius: " + circle.CalculateRadius());

        Nonagon nonagon = new Nonagon();
        Console.WriteLine("Nonagon number of sides: " + nonagon.CalculateNumberOfSides());
    }
}