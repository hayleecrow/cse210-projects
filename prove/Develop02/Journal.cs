using System;

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
    public void DisplayAllEntries() /// need to change parameter so it displays the whole list
    {
        foreach (string i in _entries)
        {
            Console.WriteLine($"\n{i}");
        }
    }
    public void SaveToFile()
    {
        Console.Write($"What is the name of your file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            /// when created, put the entry string to output into this file
            outputFile.WriteLine("first line of the file.");
        }
    }
    public void LoadFromFile()
    {
        /// this code is from assignment instructions
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
        ///
    }
}