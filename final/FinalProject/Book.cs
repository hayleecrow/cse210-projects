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
        //
    }
    public Book(string name, string author, string genre, string started, string finished, Review review)
    {
        //
    }
    public virtual string SaveString()
    {
        return "";
    }
    public virtual string DisplayString()
    {
        return "";
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