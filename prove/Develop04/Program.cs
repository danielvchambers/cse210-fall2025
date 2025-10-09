using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Pick A Mindful Activity by typing the number infront of the activity");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        string _choice = Console.ReadLine();
        int choice = int.Parse(_choice);
        if (choice == 1)
        {
            Breathing _breathing = new Breathing(30); // Hard coded duration of 180 seconds ToDo: Implement user input for duration
            _breathing.Run();
        }
        else if (choice == 2)
        {
            Reflection _reflection = new Reflection(30);
            _reflection.Run();
        }
        else if (choice == 3)
        {
            Listing _listing = new Listing(30);
            _listing.Run();
        }
    }
}
