using System;

class Entry
{
    Prompt _randPrompt = new Prompt();
    public string _dateTime;
    public string _entry;
    public string _prompt;
    public void WriteEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateTime = theCurrentTime.ToShortDateString();
        Console.WriteLine($"\nThe date is: {_dateTime}");

        _prompt = _randPrompt.DisplayRandomPrompt();

        Console.Write($"> ");
        _entry = Console.ReadLine();
    }
}