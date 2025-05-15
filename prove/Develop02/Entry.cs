using System;

class Entry
{
    Prompt prompt = new Prompt();
    public string _dateTime;
    public string _entry;
    public string _prompt;
    public string WriteEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateTime = theCurrentTime.ToShortDateString();

        _prompt = prompt.DisplayRandomPrompt();

        Console.Write($"> ");
        _entry = Console.ReadLine();

        string fullEntry = $"Date: {_dateTime} - Prompt: {_prompt}\n{_entry}";
        return fullEntry;
    }
}