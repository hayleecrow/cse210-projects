using System;

class Review
{
    private List<string> _prompts;
    private string _review;
    // private int _stars;
    public Review()
    {
        _prompts = new List<string>
        {"What did you like most about the book?",
        "What did you like the least?",
        "Who do you think would like this book?"};
        _review = "n/a";
    }
    public Review(string review)
    {
        _prompts = new List<string>
        {"What did you like most about the book?",
        "What did you like the least?",
        "Who do you think would like this book?"};
        _review = review;
    }
    public void WriteReview()
    {
        Console.WriteLine($"\nUse these prompt questions to help you review this book. It can be long or short.");
        foreach (string i in _prompts)
        {
            Console.WriteLine($"-- {i}");
        }
        Console.Write("> ");
        _review = Console.ReadLine();
    }
    public string GetReview()
    {
        return _review;
    }
}