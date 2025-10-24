using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running running1 = new Running(120, "14 Jul 1992", 4);
        _activities.Add(running1);

        Cycling cycling1 = new Cycling(30, "28 Feb 2041", 7);
        _activities.Add(cycling1);

        Swimming swimming1 = new Swimming(45, "05 Sep 1980", 40);
        _activities.Add(swimming1);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine($"{activity.Display()}\n\n");
        }
    }
}
