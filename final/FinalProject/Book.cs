using System;

class Book
{
    protected string _name;
    protected string _author;
    protected string _dateStarted;
    protected string _dateFinished;
    protected Review _review;
    public Book(string name, string author)
    {
        _name = name;
        _author = author;
        _dateStarted = "n/a";
        _dateFinished = "n/a";
        _review = new Review();
    }
    public Book(string name, string author, string started, string finished, string review)
    {
        _name = name;
        _author = author;
        _dateStarted = started;
        _dateFinished = finished;
        _review = new Review(review);
    }
    public virtual string SaveString()
    {
        return $"{_name}||{_author}||{_dateStarted}||{_dateFinished}||{_review.GetReview()}";
    }
    public virtual void DisplayBook()
    {
        Console.WriteLine(@$"{_name} by {_author}
     Started: {_dateStarted} -- Finished: {_dateFinished}
     Review: {_review.GetReview()}");
    }
    // public virtual void DisplayReview()
    // {
    //     Console.WriteLine(@$"Review: {_review.GetReview()}");
    // }
    public void SetDateStarted(string start)
    {
        _dateStarted = start;
    }
    public void SetDateFinished(string finished)
    {
        _dateFinished = finished;
    }
    public void SetReview(Review review)
    {
        _review = review;
    }
}