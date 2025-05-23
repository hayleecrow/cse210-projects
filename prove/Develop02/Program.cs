using System;

class Program
{
    // Exceeded Requirements:
    // I added a way for users to have the option to
    // answer more than one prompt before returning
    // to the menu. The users can also see the date
    // displayed right before they write their journal entry.

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string i = "0";
        Journal journal = new Journal();

        while (i != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            i = Console.ReadLine();

            if (i == "1") /// Write a new entry
            {
                bool question = true;
                while (question == true)
                {
                    journal.AddEntry(); /// Prompts user to write a new entry

                    Console.WriteLine($"\nWould you like to respond to another prompt (yes or no)? ");
                    string answer = Console.ReadLine();

                    if (answer == "no")
                    {
                        question = false;
                    }
                    else if (answer == "yes")
                    {
                        Console.WriteLine($"Okay! Here you go!");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not a valid option. Returning to menu...");
                        question = false;
                    }
                }
            }
            else if (i == "2") /// Display all entries
            {
                journal.DisplayAllEntries();
            }
            else if (i == "3") /// Save a new file
            {
                journal.SaveToFile();
            }
            else if (i == "4") /// Load from a file
            {
                journal.LoadFromFile();
            }
            else if (i != "5")
            {
                Console.WriteLine($"\nSorry, that's not a valid option. Please try again.");
            }

            Console.WriteLine();
        }
    }
}