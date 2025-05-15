using System;

class Prompt
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "What was a difficult part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "Who was the most interesting person I interacted with today?",
        "What's a meaningful lesson I learned today?",
        "What can I do better tomorrow?",
    };

    public string DisplayRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randIndex = randomGenerator.Next(0, _prompts.Count);
        string prompt = _prompts[randIndex];
        Console.WriteLine(prompt);
        return prompt;
    }
}