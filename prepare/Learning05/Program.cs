using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // store shapes in a list
        List<Shape> shapes = new List<Shape>
        {
            new Square("Pink", 5),
            new Rectangle("Purple", 4, 10),
            new Circle("Yellow", 3),
        };

        // iterate through them and display area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} -- Area: {shape.GetArea()}");
        }
    }
}