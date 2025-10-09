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
        string choice = Console.ReadLine();
        int _choice = int.Parse(choice);
        string time;
        Console.Write($"How long Do you want the activity to last in seconds? ");
        time = Console.ReadLine();
        int _time = int.Parse(time);
        if (_choice == 1)
        {
            Breathing _breathing = new Breathing(_time); // Hard coded duration of 180 seconds ToDo: Implement user input for duration
            _breathing.Run();
        }
        else if (_choice == 2)
        {
            Reflection _reflection = new Reflection(_time);
            _reflection.Run();
        }
        else if (_choice == 3)
        {
            Listing _listing = new Listing(_time);
            _listing.Run();
        }
    }
}
