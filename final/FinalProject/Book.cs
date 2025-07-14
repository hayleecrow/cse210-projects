using System;

class Book
{
    private string _name;
    private string _author;
    private string _genre;
    private string _dateStarted;
    private string _dateFinished;
    private Review _review;
    public Book(string name, string author, string genre)
    {
        _name = name;
        _author = author;
        _genre = genre;
        _dateStarted = "n/a";
        _dateFinished = "n/a";
        _review = new Review();
    }
    public Book(string name, string author, string genre, string started, string finished, string review)
    {
        _name = name;
        _author = author;
        _genre = genre;
        _dateStarted = started;
        _dateFinished = finished;
        _review = new Review(review);
    }
    public virtual string SaveString()
    {
        return "";
    }
    public virtual void DisplayBook()
    {
        Console.WriteLine(@$"{_name} by {_author} (Genre: {_genre})
    Started: {_dateStarted} -- Finished: {_dateFinished}");
    }
    public virtual void DisplayReview()
    {
        Console.WriteLine(@$"{_review.GetReview()}");
    }
    public void SetDateStarted(string start)
    {
        _dateStarted = start;
    }
    public void SetDateFinished(string finished)
    {
        _dateFinished = finished;
    }
}