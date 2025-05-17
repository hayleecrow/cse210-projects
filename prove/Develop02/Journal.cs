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

        _entries.Clear(); // clears any entries currently in the journal

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            Entry newEntry = new Entry();
            newEntry._dateTime = parts[0];
            newEntry._prompt = parts[1];
            newEntry._entry = parts[2];

            _entries.Add(newEntry);
        }

        Console.WriteLine($"\nFile ({filename}) has been loaded.");
    }
}