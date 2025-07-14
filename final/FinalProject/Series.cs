using System;

class Series : Book
{
    // maybe create series list List<Series> _seriesBooks
    private string _seriesName;
    private int _bookNum;
    public Series(string name, string author, string genre, string seriesName, int bookNum) : base(name, author, genre)
    {
        //
    }
    public Series(string name, string author, string genre, string seriesName, int bookNum, string started, string finished, string review) : base(name, author, genre, started, finished, review)
    {
        //
    }
    public override string SaveString()
    {
        return base.SaveString();
    }
    public override void DisplayBook()
    {
        base.DisplayBook();
        Console.WriteLine($"    {_seriesName} Book {_bookNum}");
    }
}