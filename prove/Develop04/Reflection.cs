using System;

public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _secondPrompts;
    private List<string> _originalSecondPrompts;
    public Reflection(string name, string start) : base(name, start)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

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
        };

        _originalSecondPrompts = new List<string> { };
        foreach (string prompt in _secondPrompts)
        {
            _originalSecondPrompts.Add(prompt);
        }
    }
    public void Run()
    {
        base.DisplayStartPrompt();

        DateTime now = DateTime.Now;
        DateTime target = now.AddSeconds(base.GetTime());

        DisplayPrompt();

        if (DateTime.Now < target)
        {
            Console.WriteLine($"Now ponder on each of the following questions as they relate to this experience.");
            Console.Write($"You may begin in:  ");
            base.Countdown(5);

            Console.Clear();

            while (DateTime.Now < target)
            {
                DisplaySecondPrompt();
                base.ShowSpinner(12);
                
                if (_secondPrompts.Count() == 0)
                {
                    _secondPrompts = _originalSecondPrompts;
                }
            }
        }

        Console.WriteLine();
        base.DisplayEndPrompt();
    }
    private string GetRandPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count());
        return _prompts[index];
    }
    private string GetSecondRandPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _secondPrompts.Count());
        string prompt = _secondPrompts[index];

        _secondPrompts.Remove(_secondPrompts[index]); // to avoid using the same prompt twice, subtract the used prompt from the list of prompts

        return prompt;
    }
    private void DisplayPrompt()
    {
        string prompt = GetRandPrompt();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {prompt} ---\n"); // display prompt
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    private void DisplaySecondPrompt()
    {
        string prompt = GetSecondRandPrompt();
        Console.Write($"> {prompt}  ");
        _secondPrompts.Remove(prompt);
    }
}