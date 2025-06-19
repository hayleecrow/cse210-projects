using System;

class Shape
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public virtual double GetArea() // don't store as member variable
    {
        return 0;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
}