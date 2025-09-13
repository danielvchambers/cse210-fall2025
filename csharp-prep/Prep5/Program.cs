using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);
        int birthDate;
        PromptUserBirthYear(out birthDate);
        DisplayResult(userName, square, birthDate);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your fav Number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        return number;
    }

    static void PromptUserBirthYear(out int birthDate)
    {
        Console.Write("What year were you born in? ");
        birthDate = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int nsquare = number * number;
        return nsquare;
    }
    static void DisplayResult(string name, int number, int birthDate)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
        Console.WriteLine($"{name}, Your age will be {2025 - birthDate} this year");
    }
}
