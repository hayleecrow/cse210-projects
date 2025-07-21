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
    public string SaveList(List<Book> list)
    {
        string fullString = "";
        foreach (Book book in list)
        {
            fullString = $"{fullString}\n{book.SaveString()}";
        }

        return fullString;
    }
    public void LoadLists(string[] lists)
    {
        _toRead.Clear();
        _started.Clear();
        _finished.Clear();
        // clear reading history

        _toRead = MakeBookList(lists[0]);
        _started = MakeBookList(lists[1]);
        _finished = MakeBookList(lists[2]);
    }
    private List<Book> MakeBookList(string bookListStr)
    {
        string[] books = bookListStr.Split($"\n");

        List<Book> booklist = new List<Book> { };
        foreach (string book in books)
        {
            string[] parts = book.Split("||");
            string bookType = parts[0];

            if (bookType == "StandAlone")
            {
                string name = parts[1];
                string author = parts[2];
                string started = parts[3];
                string finished = parts[4];
                string review = parts[5];
                StandAlone newBook = new StandAlone(name, author, started, finished, review);
                booklist.Add(newBook);
            }
            else if (bookType == "Series")
            {
                string name = parts[1];
                string author = parts[2];
                string started = parts[3];
                string finished = parts[4];
                string review = parts[5];
                string seriesName = parts[6];
                int bookNum = int.Parse(parts[7]);
                Series newBook = new Series(name, author, seriesName, bookNum, started, finished, review);
                booklist.Add(newBook);
            }
        }

        return booklist;
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