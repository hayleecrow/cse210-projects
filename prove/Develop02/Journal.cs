using System;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileName;
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        /// refer to this in Entry class at some point
    }
    public void DisplayAllEntries(string date, string entry) /// need to change parameter so it displays the whole list
    {
        Console.WriteLine($"Date: {date} - Prompt: {entry}");
    }
    public void SaveToFile()
    {}
    public void LoadFromFile()
    {}
}