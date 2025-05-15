using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int i = 0;
        Entry entry1 = new Entry();
        Journal journal = new Journal();

        while (i != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
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
                /// Console.WriteLine($"Date: {entry1._dateTime} - Prompt: {entry1._entry}");
                journal.DisplayAllEntries(entry1._dateTime, entry1._entry);
            }

            /// Load a file
            else if (i == 3)
            {
                /// this code is from assignment instructions
                string filename = "myFile.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string firstName = parts[0];
                    string lastName = parts[1];
                }
                ///
            }

            /// Save a new file
            else if (i == 4)
            {
                Console.Write($"What is the name of your file?");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    /// when created, put the entry string to output into this file
                    outputFile.WriteLine("first line of the file.");
                }
            }
            else if (i != 5)
            {
                Console.WriteLine($"Sorry, that's not a valid option. Please try again.");
            }

            Console.WriteLine();
        }
    }
}