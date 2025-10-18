public class ChecklistGoal : Goal
{
    private int _eventsOccured = 0;
    private int _totalEvents;
    private int _pointsPerComplete;

    public ChecklistGoal(string name, string info, int points, int totalEvents, int pointsPerComplete) : base(name, info, points)
    {
        _totalEvents = totalEvents;
        _pointsPerComplete = pointsPerComplete;
    }

    public override void Display()
    {
        switch (_complete)
        {
            case true:
                Console.WriteLine($"[X] {_goalName}: {_goalInfo}, " +
                    $"Points: {_pointsPerComplete}, Bonus Points: {_goalPoints}, " +
                    $"Completed: {_eventsOccured}/{_totalEvents}"
                );
                break;
            default:
                Console.WriteLine($"[ ] {_goalName}: {_goalInfo}, " +
                    $"Points: {_pointsPerComplete} Bonus Points: {_goalPoints} " +
                    $"Completed: {_eventsOccured}/{_totalEvents}"
                );
                break;
        }
    }
}
