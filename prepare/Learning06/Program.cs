using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");
        Console.WriteLine();

        Square square = new Square("green", 2);
        // Console.WriteLine("SQUARE");
        // Console.WriteLine($"Color: {square.GetColor()}");
        // Console.WriteLine($"Area: {square.GetArea()}");
        // Console.WriteLine();

        Rectangle rectangle = new Rectangle("red", 2, 4);
        // Console.WriteLine("RECTANGLE");
        // Console.WriteLine($"Color: {rectangle.GetColor()}");
        // Console.WriteLine($"Area: {rectangle.GetArea()}");
        // Console.WriteLine();

        Circle circle = new Circle("yellow", 1);
        // Console.WriteLine("CIRCLE");
        // Console.WriteLine($"Color: {circle.GetColor()}");
        // Console.WriteLine($"Area: {circle.GetArea()}");
        // Console.WriteLine();

        List<Shape> shapes = new List<Shape>()
        {
            square,
            rectangle,
            circle
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType()} - Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }
    }
}