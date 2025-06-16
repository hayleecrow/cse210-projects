using System;

public class Listing : Activity
{
    private List<string> _prompts;
    private List<string> _answers;
    private int _listNum;
    public Listing(string name, string start) : base(name, start)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        _answers = new List<string> { };

        _listNum = 0;
    }
    public void Run()
    {
        base.DisplayStartPrompt();

        DateTime now = DateTime.Now;
        DateTime target = now.AddSeconds(base.GetTime());

        DisplayPrompt();

        while (DateTime.Now < target)
        {
            CollectAnswer();
        }

        int count = _answers.Count();
        Console.WriteLine($"You listed {count} items!\n");

        base.DisplayEndPrompt();
    }
    private string GetRandPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count());
        return _prompts[index];
    }
    private void DisplayPrompt()
    {
        Console.WriteLine($"List as many responses as you can to the following prompt:\n");
        Console.WriteLine($"  --- {GetRandPrompt()} ---\n");
        Console.Write($"You many begin in:  ");
        base.Countdown(5);
    }
    private void CollectAnswer()
    {
        Console.Write($"> ");
        _answers.Add(Console.ReadLine());
    }
}