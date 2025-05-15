using System;

class Entry
{
    public string _dateTime;
    public string _entry;
    public void WriteEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateTime = theCurrentTime.ToShortDateString();

        /// get a prompt
        /// var randomString = strings.PickRandom();
        
        Console.Write($"> ");
        _entry = Console.ReadLine();
    }
}