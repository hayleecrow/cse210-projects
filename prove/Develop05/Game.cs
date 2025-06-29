using System;

class Game
{
    private List<Goal> _goals;
    private int _totalScore;
    public Game()
    {
        _totalScore = 0;
        _goals = new List<Goal>{ };
    }
    public int GetScore()
    {
        return _totalScore;
    }
    public void NewGoal()
    {
        Console.Write(@$"The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        if (choice == "1") // Simple Goal
        {
            Console.Write($"What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write($"What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write($"How many points is associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            Simple newGoal = new Simple("Simple Goal", name, description, points); // create new goal

            _goals.Add(newGoal); // add new goal to list

            Console.WriteLine();
            Console.WriteLine($"Your new goal was created!");
        }
        else if (choice == "2") // Eternal Goal
        {
            Console.Write($"What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write($"What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write($"How many points is associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            Eternal newGoal = new Eternal("Eternal Goal", name, description, points); // create new goal

            _goals.Add(newGoal); // add new goal to list

            Console.WriteLine();
            Console.WriteLine($"Your new goal was created!");
        }
        else if (choice == "3") // Checklist Goal
        {
            Console.Write($"What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write($"What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write($"How many points is associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            Console.Write($"How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write($"How many bonus will be awarded for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            Checklist newGoal = new Checklist("Checklist Goal", name, description, points, bonus, target); // create new goal

            _goals.Add(newGoal); // add new goal to list

            Console.WriteLine();
            Console.WriteLine($"Your new goal was created!");
        }
        else
        {
            Console.WriteLine("Sorry, that's not an option...");
        }
    }
    public void DisplayGoals()
    {
        //
    }
    public void SaveGoals()
    {
        //
    }
    public void LoadGoals()
    {
        // 1. for reading the file, indicate line[0] = total points and then remove it from the array, so you can iterate through the rest of the lines
        // 2. also for reading each line, first seperate based on the "colon" then seperate based on the "commas"
    }
    public void NewEvent()
    { 
        //
    }
}