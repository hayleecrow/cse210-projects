using System;

class Series : Book
{
    private string _seriesName;
    private int _bookNum;
    public Series(string name, string author, string seriesName, int bookNum) : base(name, author)
    {
        _seriesName = seriesName;
        _bookNum = bookNum;
    }
    public Series(string name, string author, string seriesName, int bookNum, string started, string finished, string review) : base(name, author, started, finished, review)
    {
        _seriesName = seriesName;
        _bookNum = bookNum;
    }
    public override string SaveString()
    {
        return $"Series||{base.SaveString()}||{_seriesName}||{_bookNum}";
    }
    public override void DisplayBook()
    {
        Console.WriteLine(@$"{_name} by {_author} ({_seriesName} Book {_bookNum})
     Started: {_dateStarted} -- Finished: {_dateFinished}
     Review: {_review.GetReview()}");
    }
}