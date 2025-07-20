using System;

class Series : Book
{
    // maybe create series list List<Series> _seriesBooks
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
        return base.SaveString();
    }
    public override void DisplayBook()
    {
        Console.WriteLine(@$"{_name} by {_author} ({_seriesName} Book {_bookNum})
     Started: {_dateStarted} -- Finished: {_dateFinished}");
    }
}