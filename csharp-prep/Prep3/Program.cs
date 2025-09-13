using System;

class Program
{
    static void Main(string[] args)
    {
        Random magicGenerator = new Random();
        int magicNumber = magicGenerator.Next(1, 101);
        bool quit = false;
        int numberGuesses = 0;
        bool restart = false;
        while (!restart)
        {
            while (!quit)
            {
                numberGuesses = numberGuesses + 1;
                Console.Write("What is Your guess? ");
                string numberGuess = Console.ReadLine();
                int guess = int.Parse(numberGuess);
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Greater");
                }
                else if (guess == magicNumber)
                {
                    Console.WriteLine("You Got it!!!");
                    Console.WriteLine($"The number of times you guessed: {numberGuesses}");
                    quit = true;
                }
            }
            Console.Write("Would you like to play again? (y, n) ");
            string cont = Console.ReadLine();
            quit = false;
            if (cont != "y")
            {
                Console.WriteLine("Bye");
                restart = true;
            }
        }
    }
}
