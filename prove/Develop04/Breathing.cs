public class Breathing : Activities
{
    public Breathing(int time) : base(time)
    {
        base._activityName = "Breathing Exercise";
        base._activityInstr = "Clear Your mind and take deep breathes according to the Timeing in the activity.";
    }

    public void Run()
    {
        Console.WriteLine($"\n{base._activityName}");
        Console.WriteLine(base._activityInstr);
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_activityRunTime);
        Console.Write($"\nHow many seconds do you want between breaths? ");
        string breaths = Console.ReadLine();
        int _breaths = int.Parse(breaths);
        while (DateTime.Now <= _endTime)
        {
            Console.WriteLine("\nBreathe in\n");
            base.WaitingAnim(_breaths);
            Console.WriteLine("Breathe out\n");
            base.WaitingAnim(_breaths);
        }
    }
}
