using System;

class Entry
{
    Prompt prompt = new Prompt();
    public string _dateTime;
    public string _entry;
    public string _prompt;
    public void WriteEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateTime = theCurrentTime.ToShortDateString();
        Console.WriteLine($"\nThe date is: {_dateTime}");

        _prompt = prompt.DisplayRandomPrompt();

        Console.Write($"> ");
        _entry = Console.ReadLine();
    }
}