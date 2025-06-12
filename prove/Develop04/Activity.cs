using System;

public class Activity
{
    private string _name;
    private string _startPrompt;
    private string _endPrompt;
    private int _time;
    public Activity(string name, string start, string end, int time)
    {
        _name = name;
        _startPrompt = start;
        _endPrompt = end;
        _time = time;
    }
    public void DisplayStartPrompt()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name} Activity.\n");
        Console.WriteLine(_startPrompt);
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...\n");
        Console.ReadLine(); // ShowSpinner();
    }
    public void DisplayEndPrompt()
    {
        Console.WriteLine("Well done!!");
        Console.ReadLine(); // ShowSpinner();

        Console.WriteLine($"You have completed {_time} seconds of the {_name} Activity.");
        Console.ReadLine(); // ShowSpinner();
    }
    public string ShowSpinner() // pass in a time
    {
        return "";
    }
    public string Countdown() // pass in a time
    {
        return "";
    }
}