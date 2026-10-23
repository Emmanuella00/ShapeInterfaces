using System;
public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Trapezium : IShape
{
    double height = 2;
    double a = 3;
    double b = 2.5;
    double c = 3.2;
    double d = 1;

    public double CalculateArea()
    {
        return (a + b) / 2 * height;
    }

    public double CalculatePerimeter()
    {
        return a + b + c + d;
    }

    public double CalculateUnknownSides(double p)
    {
        return p - a - b - c;
    }
}


public class Circle : IShape
{
    double diameter = 10;

    public double CalculateArea()
    {
        return Math.PI * diameter / 2 * diameter / 2;
    }

    public double CalculatePerimeter()
    {
        return Math.PI * diameter;
    }

    public double CalculateRadius()
    {
        return diameter / 2;
    }
}


public class Nonagon : IShape
{
    int numberOfSides = 9;
    double sideLength = 4;

    public double CalculateArea()
    {
        return 6.18 * sideLength * sideLength;
    }

    public double CalculatePerimeter()
    {
        return numberOfSides * sideLength;
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}



