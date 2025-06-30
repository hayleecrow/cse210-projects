using System;

// Showing Creativity: The Eternal Goal class stores how many
// times the user accomplished the goal and how many points they earned.
// There are also a couple places where else statements display an invalid
// message when the user inputs something that is not an option.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Game game = new Game();

        string quit = "no";

        while (quit == "no")
        {
            // Console.Clear();
            Console.WriteLine($"You have {game.GetScore()} points.");
            Console.WriteLine();

            Console.Write(@$"Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                game.NewGoal();
            }
            else if (choice == "2")
            {
                game.DisplayGoals();
            }
            else if (choice == "3")
            {
                game.SaveGoals();
            }
            else if (choice == "4")
            {
                game.LoadGoals();
            }
            else if (choice == "5")
            {
                game.NewEvent();
            }
            else if (choice == "6")
            {
                quit = "yes";

                Console.WriteLine("Bye! Come again!");
            }
            else
            {
                Console.WriteLine($"Sorry, that's not a valid option.");
                Thread.Sleep(5000);
            }

            Console.WriteLine();
        }
    }
}