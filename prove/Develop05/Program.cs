using System;

class Program
{
    static void Main(string[] args)
    {
        EternalGoal _Eternal = new EternalGoal("myGoal", "stuff", 200);
        Console.WriteLine($"Total Points: {_Eternal.GetPoints()} ");
        _Eternal.Display();
    }
}
