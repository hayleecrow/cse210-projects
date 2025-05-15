using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int i = 0;
        Entry entry1 = new Entry();

        while (i != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            i = choice;

            /// Write a new entry
            if (i == 1)
            {
                entry1.WriteEntry();
            }

            /// Display all entries
            else if (i == 2)
            {
                Console.WriteLine($"Date: {entry1._dateTime} - Prompt: {entry1._entry}");
            }

            /// Load a file
            else if (i == 3)
            {

            }
            
            /// Save a new file
            else if (i == 4)
            {

            }

            Console.WriteLine();
        }
    }
}