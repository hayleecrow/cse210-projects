using System;
using System.IO;
using System.Collections.Generic; // might make it so List can be a list of Entries: List<Entry>

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileName;
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry.WriteEntry();
        _entries.Add(newEntry); // then change list data type to Entry, how will it store each entry?
    }
    public void DisplayAllEntries()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"\nDate: {e._dateTime} - Prompt: {e._prompt}\n{e._entry}");
        }
    }
    public void SaveToFile()
    {
        Console.Write($"What is the name of your file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                // outputFile.WriteLine($"{entry}\n");
                outputFile.WriteLine($"{e._dateTime}~~{e._prompt}~~{e._entry}");
            }
        }
    }
    public void LoadFromFile()
    {
        Console.Write($"What is the name of the file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        Console.WriteLine();

        foreach (string line in lines)
        {
            Console.WriteLine(line);
            //_entries.Add(line); // won't display quite right, yet, when use display all method
            // string[] parts = entry.Split("~~");
        }
    }
}