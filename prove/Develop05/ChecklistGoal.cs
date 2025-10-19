using System.Text.Json.Serialization;
using System.Text.Json;

public class ChecklistGoal : Goal
{
    [JsonInclude]
    private int _eventsOccured = 0;
    [JsonInclude]
    private int _totalEvents;
    [JsonInclude]
    private int _pointsPerComplete;

    public ChecklistGoal() : base() { }

    public ChecklistGoal(string name, string info, int points, int totalEvents, int pointsPerComplete) : base(name, info, points)
    {
        _totalEvents = totalEvents;
        _pointsPerComplete = pointsPerComplete;
    }

    public override string Display()
    {
        switch (_complete)
        {
            case true:
                return ($"[X] {_goalName}: {_goalInfo}, " +
                    $"Points: {_pointsPerComplete}, Bonus Points: {_goalPoints}, " +
                    $"Completed: {_eventsOccured}/{_totalEvents}"
                );

            default:
                return ($"[ ] {_goalName}: {_goalInfo}, " +
                    $"Points: {_pointsPerComplete}, Bonus Points: {_goalPoints}, " +
                    $"Completed: {_eventsOccured}/{_totalEvents}"
                );
        }
    }


}
