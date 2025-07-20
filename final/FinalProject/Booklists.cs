using System;

class Booklists
{
    private List<Book> _toRead;
    private List<Book> _started;
    private List<Book> _finished;
    public Booklists()
    {
        _toRead = new List<Book> { };
        _started = new List<Book> { };
        _finished = new List<Book> { };
    }
    public Book NewBook()
    {
        Console.Write($"What is the name of the book? ");
        string name = Console.ReadLine();

        Console.Write($"Who is the author? ");
        string author = Console.ReadLine();

        int a = 0;
        Book newBook = new StandAlone("name", "author");
        while (a == 0)
        {
            Console.Write($"Is the book a standalone (1) or part of a series (2)? ");
            string type = Console.ReadLine();

            if (type == "1")
            {
                a = 3;

                newBook = new StandAlone(name, author);
            }
            else if (type == "2")
            {
                a = 4;

                Console.Write($"What is the name of the series? ");
                string seriesName = Console.ReadLine();

                Console.Write($"What book number is it (enter an integer)? ");
                int bookNum = int.Parse(Console.ReadLine());

                newBook = new Series(name, author, seriesName, bookNum);
            }
            else
            {
                Console.WriteLine("Sorry, that's not an option. Pick again.");
            }
        }

        return newBook;
    }
    public void AddToRead(Book book)
    {
        _toRead.Add(book);
    }
    public void AddStarted(Book book, string date)
    {
        book.SetDateStarted(date);
        _started.Add(book);
    }
    public void AddFinished(Book book, string date, Review review)
    {
        book.SetDateFinished(date);
        book.SetReview(review);
        _finished.Add(book);
    }
    public void RemoveFromToRead(int index)
    {
        _toRead.Remove(_toRead[index]);
    }
    public void RemoveFromStarted(int index)
    {
        _started.Remove(_started[index]);
    }
    public void DisplayList(List<Book> list)
    {
        int count = 0;
        foreach (Book book in list)
        {
            count++;
            Console.Write($"{count}. ");
            book.DisplayBook();
        }
    }
    public void SaveList(List<Book> list)
    {
        //
    }
    public void LoadList(List<Book> list)
    {
        //
    }
    public List<Book> GetToRead()
    {
        return _toRead;
    }
    public List<Book> GetStarted()
    {
        return _started;
    }
    public List<Book> GetFinished()
    {
        return _finished;
    }
}