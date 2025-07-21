using System;

class ReadingHistory
{
    private List<string> _history;
    public ReadingHistory()
    {
        _history = new List<string> { };
    }
    public ReadingHistory(List<string> history)
    {
        _history = history;
    }
    public void AddHistory(string book, string author, string start, string finish)
    {
        _history.Add($"{start}--{finish} : {book} by {author}");
    }
    public void DisplayHistory()
    {
        Console.WriteLine($"\nThis is your reading history:");
        foreach (string i in _history)
        {
            Console.WriteLine($"     {i}");
        }
    }
    public List<string> GetHistory()
    {
        return _history;
    }
}