using System.Text.Json.Serialization;
using System.Text.Json;
public class Goal
{
    private string _fileName;
    [JsonInclude]
    protected string _goalName;
    [JsonInclude]
    protected string _goalInfo;
    [JsonInclude]
    protected int _goalPoints;
    [JsonInclude]
    private int _totalPoints;
    [JsonInclude]
    protected bool _complete = false;

    public Goal(string name, string info, int points)
    {
        _goalName = name;
        _goalInfo = info;
        _goalPoints = points;
        _complete = false;
    }

    public virtual void Save()
    {
        string jsonString = JsonSerializer.Serialize(this);
        Console.WriteLine(jsonString);
    }

    public virtual void Display()
    {
        switch (_complete)
        {
            case true:
                Console.WriteLine($"[X] {_goalName}: {_goalInfo}, Value: {_goalPoints}");
                break;
            default:
                Console.WriteLine($"[ ] {_goalName}: {_goalInfo}, Value: {_goalPoints}");
                break;
        }
    }

    public virtual void Load(string fileName)
    {
        //Load Method
    }

    protected void AddPoints(int totalPoints, int goalPoints)
    {
        _totalPoints = totalPoints + goalPoints;
    }

    public int GetPoints()
    {
        return _totalPoints;
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    public void SetComplete()
    {
        _complete = true;
    }
}
