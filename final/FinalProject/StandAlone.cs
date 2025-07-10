using System;

class StandAlone : Book
{
    public StandAlone(string name, string author, string genre) : base(name, author, genre)
    {
        //
    }
    public StandAlone(string name, string author, string genre, string started, string finished, Review review) : base(name, author, genre, started, finished, review)
    { 
        //
    }
}