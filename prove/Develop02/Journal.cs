using System;

class Journal
{
    public List<string> _entries = new List<string>();
    public string _fileName;
    public void AddEntry(string entry)
    {
        _entries.Add(entry);
        /// refer to this in Entry class at some point
    }
    public void DisplayAllEntries(string date, string entry) /// need to change parameter so it displays the whole list
    {
        /// Console.WriteLine($"Date: {date} - Prompt: {entry}");
        string test = $"Date: {date} - Prompt: {entry}\n{entry}";
        Console.WriteLine(test);
    }
    public void SaveToFile()
    {}
    public void LoadFromFile()
    {}
}