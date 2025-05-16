using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int i = 0;
        Journal journal = new Journal();

        while (i != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            i = choice;

            if (i == 1) /// Write a new entry
            {
                journal.AddEntry();
            }
            else if (i == 2) /// Display all entries
            {
                journal.DisplayAllEntries();
            }
            else if (i == 3) /// Save a new file
            {
                journal.SaveToFile();
            }
            else if (i == 4) /// Load from a file
            {
                journal.LoadFromFile();
            }
            else if (i != 5)
            {
                Console.WriteLine($"Sorry, that's not a valid option. Please try again.");
            }

            Console.WriteLine();
        }
    }
}