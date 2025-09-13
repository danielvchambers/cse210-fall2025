using System;

class Program
{
    static void Main(string[] args)
    {
        String letter = "";
        Console.Write("What is your Grade percentage: ");
        String userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your Grade is {letter}");
        if (percentage >= 70)
        {
            Console.WriteLine("You Passed!!!!!");
        }
        else
        {
            Console.WriteLine("You Failed this class. You Can do better next time :)");
        }
    }
}
