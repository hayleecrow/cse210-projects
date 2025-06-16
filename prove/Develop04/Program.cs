using System;

// To show creativity, I made the second set of prompts
// in the reflection activity not select the same prompt
// twice until all the prompts were used.

class Program
{
    static void Main(string[] args)
    {
        string quit = "continue";
        while (quit == "continue")
        {
            Console.Clear();

            Console.Write(@"Menu Options:
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. Quit
Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string name = "Breathing";
                string start = @"This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Breathing breathes = new Breathing(name, start);
                breathes.Run();
            }
            else if (choice == 2)
            {
                string name = "Reflection";
                string start = @"This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Reflection reflection = new Reflection(name, start);
                reflection.Run();
            }
            else if (choice == 3)
            {
                string name = "Listing";
                string start = @"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                Listing listing = new Listing(name, start);
                listing.Run();
            }
            else if (choice == 4)
            {
                quit = "quit";
            }
        }
    }
}