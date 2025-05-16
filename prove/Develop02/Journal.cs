using System;
using System.IO;

class Journal
{
    public List<string> _entries = new List<string>();
    public string _fileName;
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        string fullEntry = newEntry.WriteEntry();
        _entries.Add(fullEntry);
    }
    public void DisplayAllEntries()
    {
        foreach (string i in _entries)
        {
            Console.WriteLine($"\n{i}");
        }
    }
    public void SaveToFile()
    {
        Console.Write($"What is the name of your file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine($"{entry}\n");
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
        }
    }
}