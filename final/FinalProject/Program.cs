using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();
        Booklists booklists = new Booklists();
        ReadingHistory readingHistory = new ReadingHistory();

        Console.WriteLine($"Welcome to the Bookworm Reading Guide!");

        string quit = "no";

        while (quit == "no")
        {
            // Console.Clear();

            Console.WriteLine();
            Console.Write(@$"You can do the following?
    1. Add a Book to My TBR (To Be Read)
    2. Add a Book That I've Started
    3. Add a Book That I've Finished
    4. Display a List
    5. View Reading History
    6. Memorize a Quote
    7. Save Info
    8. Load Info
    9. Quit
What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1") // Add book to TBR list
            {
                Book book = booklists.NewBook();
                booklists.AddToRead(book);
            }
            else if (choice == "2") // Add book to Started list
            {
                Console.Write($"Is the book you started currently on your TBR list (yes or no)? ");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    List<Book> toReadList = booklists.GetToRead();

                    booklists.DisplayList(toReadList);
                    Console.Write($"What book did you start? ");
                    int index = int.Parse(Console.ReadLine()) - 1;

                    Console.Write($"What day did you start it (MM/DD)? ");
                    string date = Console.ReadLine();

                    booklists.AddStarted(toReadList[index], date); // add to start list
                    booklists.RemoveFromToRead(index); // remove from to read list
                }
                else if (answer.ToLower() == "no")
                {
                    Book book = booklists.NewBook();

                    Console.Write($"What day did you start it (MM/DD)? ");
                    string date = Console.ReadLine();

                    booklists.AddStarted(book, date);
                }
                else
                {
                    //
                }
            }
            else if (choice == "3") // Add book to Finished list
            {
                List<Book> startList = booklists.GetStarted();
                booklists.DisplayList(startList); // display start list and have them choose book

                Console.Write($"What book did you finish? ");
                int index = int.Parse(Console.ReadLine()) - 1;
                Book bookToAdd = startList[index];

                Console.Write($"What day did you finish it (MM/DD)? ");
                string date = Console.ReadLine();

                Console.Write($"Would you like to write a review for this book (yes or no)? ");
                string writeReview = Console.ReadLine();

                Review review = new Review();
                if (writeReview.ToLower() == "yes")
                {
                    review.WriteReview();
                }
                else if (writeReview.ToLower() == "no")
                {
                    // some message abt it being okay
                }

                booklists.AddFinished(bookToAdd, date, review); // add to finished list
                booklists.RemoveFromStarted(index); // remove from started list
                readingHistory.AddHistory(bookToAdd.GetBookName(), bookToAdd.GetAuthor(), bookToAdd.GetDateStarted(), date); // add to reading history
            }
            else if (choice == "4") // Display a list
            {
                Console.Write(@$"What list would you like to display? 
    1. To Be Read
    2. Started
    3. Finished
> ");
                string list = Console.ReadLine();

                if (list == "1")
                {
                    booklists.DisplayList(booklists.GetToRead());
                }
                else if (list == "2")
                {
                    booklists.DisplayList(booklists.GetStarted());
                }
                else if (list == "3")
                {
                    booklists.DisplayList(booklists.GetFinished());
                }

                // create pause with Console.ReadLine();
            }
            else if (choice == "5") // display reading history
            {
                readingHistory.DisplayHistory();
            }
            else if (choice == "6") // memorize quote activity
            {
                MemorizeQuote activity = new MemorizeQuote();

                activity.InputQuote();
                Console.WriteLine();

                while (activity.GetWordCount() > activity.GetHiddenWordCount())
                {
                    Console.Clear();
                    Console.WriteLine($"Here is your quote. Start Memorizing!\n");
                    activity.DisplayQuote();

                    Console.Write($"\n\nPress enter to hide 3 words.");
                    Console.ReadLine();

                    activity.HideRandomWords();

                    if (activity.GetWordCount() == activity.GetHiddenWordCount())
                    {
                        Console.Clear();
                        Console.WriteLine($"Last time. Here is your quote. Start Memorizing!\n");
                        activity.DisplayQuote();
                    }
                }

                Console.Write($"\n\nWhen you're done memorizing, press enter to go to menu.");
                Console.ReadLine();
            }
            else if (choice == "7") // save info
            {
                Console.Write("What is the name of your file? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.Write($"{booklists.SaveList(booklists.GetToRead())}%%");
                    outputFile.Write($"{booklists.SaveList(booklists.GetStarted())}%%");
                    outputFile.Write($"{booklists.SaveList(booklists.GetFinished())}%%");

                    List<string> history = readingHistory.GetHistory();
                    foreach (string line in history)
                    {
                        outputFile.Write($"\n{line}");// save reading history info
                    }
                }
            }
            else if (choice == "8") // load info
            {
                Console.Write("What is the name of your file? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);

                string full = "";
                foreach (string line in lines)
                {
                    full = $"{full}\n{line}";
                }

                string[] lists = full.Split("%%");
                booklists.LoadLists(lists);

                // Load reading history
                string stringHistory = lists[3];
                string[] arrayHistory = stringHistory.Split("\n");

                List<string> history = new List<string> { };
                foreach (string line in arrayHistory)
                {
                    history.Add(line);
                }
                history.Remove(history[0]); // remove extra line

                readingHistory = new ReadingHistory(history);

                Console.WriteLine("File loaded.");
            }
            else if (choice == "9") // quit
            {
                quit = "yes";
            }
            else
            {
                //
            }
        }
    }
}