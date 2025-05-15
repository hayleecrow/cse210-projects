using System;

class Entry
{
    Prompt prompt = new Prompt();
    public string _dateTime;
    public string _entry;
    public void WriteEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateTime = theCurrentTime.ToShortDateString();

        prompt.DisplayRandomPrompt();
        
        Console.Write($"> ");
        _entry = Console.ReadLine();
    }
}