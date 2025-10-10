// I used Polymorphism to override the WaitingAnim method in activities class and reflection class as my showing creativity

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
        int _time;

        switch (_choice)
        {
            case 1:
                Console.Write($"How long Do you want the activity to last in seconds? ");
                time = Console.ReadLine();
                _time = int.Parse(time);
                Breathing _breathing = new Breathing(_time);
                _breathing.Run();
                break;

            case 2:
                Console.Write($"How long Do you want the activity to last in seconds? ");
                time = Console.ReadLine();
                _time = int.Parse(time);
                Reflection _reflection = new Reflection(_time);
                _reflection.Run();
                break;

            case 3:
                Console.Write($"How long Do you want the activity to last in seconds? ");
                time = Console.ReadLine();
                _time = int.Parse(time);
                Listing _listing = new Listing(_time);
                _listing.Run();
                break;

            default:
                Console.WriteLine("The End");
                break;
        }
        //if (_choice == 1)
        //{
        //    Console.Write($"How long Do you want the activity to last in seconds? ");
        //    time = Console.ReadLine();
        //    _time = int.Parse(time);
        //    Breathing _breathing = new Breathing(_time);
        //    _breathing.Run();
        //}
        //else if (_choice == 2)
        //{
        //    Console.Write($"How long Do you want the activity to last in seconds? ");
        //    time = Console.ReadLine();
        //    _time = int.Parse(time);
        //    Reflection _reflection = new Reflection(_time);
        //    _reflection.Run();
        //}
        //else if (_choice == 3)
        //{
        //    Console.Write($"How long Do you want the activity to last in seconds? ");
        //    time = Console.ReadLine();
        //    _time = int.Parse(time);
        //    Listing _listing = new Listing(_time);
        //    _listing.Run();
        //}
        //else
        //{
        //    Console.WriteLine("The End");
        //}
    }
}
