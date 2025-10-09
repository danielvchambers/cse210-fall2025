public class Breathing : Activities
{
    public Breathing(int time) : base(time)
    {
        base._activityName = "Breathing Exercise";
        base._activityInstr = "Clear Your mind and take deep breathes according to the Timeing in the activity.";
    }

    public void Run()
    {
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_activityRunTime);
        while (DateTime.Now <= _endTime)
        {
            Console.WriteLine("Breathe in");
            base.WaitingAnim();
            Console.WriteLine("Breathe out");
        }
    }
}
