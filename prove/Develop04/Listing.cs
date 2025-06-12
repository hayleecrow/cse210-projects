using System;

public class Listing : Activity
{
    private List<string> _prompts;
    private List<string> _answers;
    private int _listNum;
    public Listing(string name, string start, string end, int time) : base(name, start, end, time)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "",
        }; // add my own prompts

        _answers = new List<string> { };

        _listNum = 0;
    }
    public void Run()
    {
        base.DisplayStartPrompt();

        DisplayPrompt();
        CollectAnswers();

        base.DisplayEndPrompt();
    }
    private string GetRandPrompt()
    {
        return "prompt?";
    }
    private void DisplayPrompt()
    {
        Console.WriteLine($"List as many responses as you can to the following prompt:");
        Console.WriteLine($"  --- {GetRandPrompt()} ---");
        Console.Write($"You many begin in: ");
        Console.ReadLine(); // base.Countdown(5);
    }
    private void CollectAnswers()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"> ");
            _answers.Add(Console.ReadLine());
        }
        int count = _answers.Count();

        Console.WriteLine($"You listed {count} items!\n");
    }
}