using System;

class Journal
{
    public List<string> _entries = new List<string>();
    public string _fileName;
    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAllEntries() /// need to change parameter so it displays the whole list
    {
        foreach (string i in _entries)
        {
            Console.WriteLine($"\n{i}");
        }
    }
    public void SaveToFile()
    {}
    public void LoadFromFile()
    {}
}