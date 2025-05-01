using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int m = randomGenerator.Next(1,101);

        int g = 102;

        while (g != m)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            g = int.Parse(guess);

            // simplify by using g = int.Parse(Console.ReadLine());

            if (g > m)
            {
                Console.WriteLine("Lower");
            }
            else if (g < m)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
    }
}