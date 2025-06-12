using System;

public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _secondPrompts;
    public Reflection(string name, string start, string end, int time) : base(name, start, end, time)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        }; // add my own prompts

        _secondPrompts = new List<string>
        { 
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        }; // add my own prompts
    }
    public void Run()
    {
        base.DisplayStartPrompt();

        DisplayPrompt();
        Console.WriteLine($"Now ponder on each of the following questions as they relate to this experience.");
        Console.Write($"You may begin in: ");
        Console.ReadLine(); // base.Countdown(5);

        // loop until time is up
        DisplaySecondPrompt();
        Console.ReadLine(); // base.ShowSpinner();

        base.DisplayEndPrompt();
    }
    private string GetRandPrompt()
    {
        return "prompt?";
    }
    private string GetSecondRandPrompt()
    {
        return "prompt 2.0?";
    }
    private void DisplayPrompt()
    {
        string prompt = GetRandPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {prompt} ---"); // display prompt
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        // to avoid using the same prompt twice, subtract the used prompt from the list of prompts
    }
    private void DisplaySecondPrompt()
    {
        string prompt2 = GetSecondRandPrompt();
        Console.Write($"> {prompt2} ");
    }
}