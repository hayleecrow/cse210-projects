using System;

public class Activity
{
    private string _name;
    private string _startPrompt;
    private int _time;
    public Activity(string name, string start)
    {
        _name = name;
        _startPrompt = start;
        _time = 0;
    }
    public void DisplayStartPrompt()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name} Activity.\n");
        Console.WriteLine(_startPrompt);
        Console.Write($"\nHow long, in seconds, would you like for your session? ");

        _time = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.Write("Get ready... ");
        ShowSpinner(4);

        Console.WriteLine();
    }
    public void DisplayEndPrompt()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(4);

        Console.WriteLine($"You have completed {_time} seconds of the {_name} Activity.");
        ShowSpinner(4);
    }
    public void ShowSpinner(int repeats) // pass in a time
    {
        for (int i = 0; i < repeats; i++)
        {
            Console.Write($"\b-");
            Thread.Sleep(200);

            Console.Write("\b\\");
            Thread.Sleep(200);

            Console.Write($"\b|");
            Thread.Sleep(200);

            Console.Write($"\b/");
            Thread.Sleep(200);
        }
        Console.WriteLine($"\b ");
    }
    public void Countdown(int seconds) // pass in a time
    {
        DateTime now = DateTime.Now;
        DateTime target = now.AddSeconds(seconds);

        int countdown = seconds;

        while (DateTime.Now < target)
        {
            Console.Write($"\b{countdown}");

            Thread.Sleep(1000);

            countdown--;
        }
        Console.WriteLine($"\b ");
    }
    public int GetTime()
    {
        return _time;
    }
}