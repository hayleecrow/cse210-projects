using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(num)}");
    }
}