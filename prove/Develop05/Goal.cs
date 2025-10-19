using System.Text.Json.Serialization;
using System.Text.Json;

public class Goal
{
    [JsonInclude]
    protected string _goalName;
    [JsonInclude]
    protected string _goalInfo;
    [JsonInclude]
    protected int _goalPoints;
    [JsonInclude]
    protected bool _complete = false;

    public Goal()
    { }

    public Goal(string name, string info, int points)
    {
        _goalName = name;
        _goalInfo = info;
        _goalPoints = points;
        _complete = false;
    }

    public virtual string Display()
    {
        switch (_complete)
        {
            case true:
                return ($"[X] {_goalName}: {_goalInfo}, Value: {_goalPoints}");

            default:
                return ($"[ ] {_goalName}: {_goalInfo}, Value: {_goalPoints}");
        }
    }

    public virtual int AddPoints(int totalPoints, int goalPoints)
    {
        return totalPoints + goalPoints;
    }

    public virtual void SetComplete()
    {
        _complete = true;
    }

    public int GetPoints()
    {
        return _goalPoints;
    }
}
