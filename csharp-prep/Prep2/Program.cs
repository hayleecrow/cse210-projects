using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string prec = Console.ReadLine();
        int x = int.Parse(prec);

        if (x >= 90)
        {
            string grade = "A";
            Console.WriteLine($"{grade}");
        }
        else if (x >= 80)
        {
            string grade = "B";
            Console.WriteLine($"{grade}");
        }
        else if (x >= 70)
        {
            string grade = "C";
            Console.WriteLine($"{grade}");
        }
        else if (x >= 60)
        {
            string grade = "D";
            Console.WriteLine($"{grade}");
        }
        else
        {
            string grade = "F";
            Console.WriteLine($"{grade}");
        }
    }
}