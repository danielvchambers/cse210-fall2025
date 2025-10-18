public class ChecklistGoal : Goal
{
    private int _eventsOccured = 0;
    private int _totalEvents;

    public ChecklistGoal(string name, string info, int points, int totalEvents) : base(name, info, points)
    {
        _totalEvents = totalEvents;
    }

    public override void Display()
    {
        //todo
    }
}
