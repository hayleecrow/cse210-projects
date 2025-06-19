using System;

class Circle : Shape
{
    // color and radius
    private double _radius;
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}