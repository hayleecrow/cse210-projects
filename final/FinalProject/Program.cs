using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Booklists booklists = new Booklists();

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

            if (choice == "1")
            {
                Book book = booklists.NewBook();
                booklists.AddToRead(book);
            }
            else if (choice == "2")
            {
                Console.WriteLine($"Is the book you started currently on your TBR list (yes or no)? ");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    List<Book> toReadList = booklists.GetToRead();

                    booklists.DisplayList(toReadList);
                    Console.Write($"What book did you start? ");
                    int index = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine($"What day did you start it (MM/DD)");
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
            else if (choice == "3")
            {
                List<Book> startList = booklists.GetStarted();
                booklists.DisplayList(startList); // display start list and have them choose book

                Console.Write($"What book did you finish? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                Console.Write($"What day did you finish it (MM/DD)? ");
                string date = Console.ReadLine();

                booklists.AddFinished(startList[index], date); // add to finished list
                booklists.RemoveFromStarted(index); // remove from started list
            }
            else if (choice == "4") // display a list
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
            }
            else if (choice == "5") // display reading history
            {
                //
            }
            else if (choice == "6") // memorize quote activity
            {
                //
            }
            else if (choice == "7") // save info
            {
                //
            }
            else if (choice == "8") // load info
            {
                //
            }
            else if (choice == "9")
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