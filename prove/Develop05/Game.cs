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
        int counter = 0;

        foreach (Goal goal in _goals)
        {
            counter++;

            Console.WriteLine($"The goals are:");
            Console.WriteLine($"{counter}. {goal.DisplayString()}");
        }
    }
    public void SaveGoals()
    {
        Console.Write($"What is the name of your file? ");
        string filename = Console.ReadLine();

        // will create new file if file doesn't already exist
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalScore);

            foreach (Goal goal in _goals)
            {
                // writes the entries onto the file
                outputFile.WriteLine(goal.SaveString());
            }
        }

        Console.WriteLine($"File saved.");
    }
    public void LoadGoals()
    {
        // 1. for reading the file, indicate line[0] = total points and then remove it from the array, so you can iterate through the rest of the lines
        // 2. also for reading each line, first seperate based on the "colon" then seperate based on the "commas"
        Console.Write($"What is the name of the file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        Console.WriteLine();

        _goals.Clear(); // clears any current goals

        // _totalScore = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] first = line.Split("|"); // first split to get goal type

            if (first.Count() == 1)
            {
                _totalScore = int.Parse(line);
            }
            else if (first.Count() > 1)
            {
                if (first[0] == "Simple Goal")
                {
                    string[] second = first[1].Split("~~");

                    string name = second[0];
                    string description = second[1];
                    int points = int.Parse(second[2]);
                    bool completion = bool.Parse(second[3]);

                    Simple goal = new Simple("Simple Goal", name, description, points, completion);
                    _goals.Add(goal);
                }
                else if (first[0] == "Eternal Goal")
                {
                    string[] second = first[1].Split("~~");

                    string name = second[0];
                    string description = second[1];
                    int points = int.Parse(second[2]);
                    int total = int.Parse(second[3]);
                    int times = int.Parse(second[4]);

                    Eternal goal = new Eternal("Eternal Goal", name, description, points, total, times);
                    _goals.Add(goal);
                }
                else if (first[0] == "Checklist Goal")
                {
                    string[] second = first[1].Split("~~");

                    string name = second[0];
                    string description = second[1];
                    int points = int.Parse(second[2]);
                    int bonus = int.Parse(second[3]);
                    int target = int.Parse(second[4]);
                    int current = int.Parse(second[5]);

                    Checklist goal = new Checklist("Checklist Goal", name, description, points, bonus, target, current);
                    _goals.Add(goal);
                }
            }
        }

        Console.WriteLine($"The file {filename} has been loaded.");
    }
    public void NewEvent()
    { 
        //
    }
}