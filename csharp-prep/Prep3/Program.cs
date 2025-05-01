using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int m = int.Parse(magic);

        int g = 0;

        while (g != m)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            g = int.Parse(guess);

            if (g > m)
            {
                Console.WriteLine("Lower");
            }
            else if (g < m)
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("You guessed it!");
    }
}