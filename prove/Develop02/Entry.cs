using System;

class Entry
{
    public string _dateTime;
    public string _entry;
    public void WriteEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _dateTime = theCurrentTime.ToShortDateString();

        
    }
}