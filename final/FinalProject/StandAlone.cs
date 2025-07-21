using System;

class StandAlone : Book
{
    public StandAlone(string name, string author) : base(name, author)
    {
        // passes info to base class
    }
    public StandAlone(string name, string author, string started, string finished, string review) : base(name, author, started, finished, review)
    {
        // passes info to base class
    }
    public override string SaveString()
    {
        return $"StandAlone||{base.SaveString()}";
    }
}