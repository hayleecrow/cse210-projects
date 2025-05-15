using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int i = 0;

        while (i != 5)
        {
            Console.WriteLine("Please select one of the following choices:",
            "x");
            int choice = int.Parse(Console.ReadLine());
            i = choice;
        }
    }
}