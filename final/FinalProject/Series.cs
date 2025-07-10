using System;

class Series : Book
{
    // maybe create series list List<Series> _seriesBooks
    private string _seriesName;
    private int _bookNum;
    public Series(string name, string author, string genre) : base(name, author, genre)
    {
        //
    }
    public Series(string name, string author, string genre, string started, string finished, Review review) : base(name, author, genre, started, finished, review)
    {
        //
    }
    public override string SaveString()
    {
        return base.SaveString();
    }
    public override string DisplayString()
    {
        return base.DisplayString();
    }
}