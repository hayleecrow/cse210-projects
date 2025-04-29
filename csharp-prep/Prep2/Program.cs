using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string perc = Console.ReadLine();
        int x = int.Parse(perc);
        string letter;

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine("");
        
        Console.WriteLine($"Your grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congrats! You passed.");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. Better luck next time.");
        }
        Console.WriteLine("");
    }
}