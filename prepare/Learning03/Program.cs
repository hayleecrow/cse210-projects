using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetTop());
        // Console.WriteLine(fraction1.SetTop(4));
        Console.WriteLine(fraction1.GetBottom());
        Console.WriteLine(fraction1.GetTop());

        Fraction fraction2 = new Fraction(6);


        Fraction fraction3 = new Fraction(6, 7);

    }
}