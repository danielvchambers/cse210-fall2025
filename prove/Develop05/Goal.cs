using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
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

    public Goal()
    { }

    public Goal(string name, string info, int points)
    {
        _goalName = name;
        _goalInfo = info;
        _goalPoints = points;
        _complete = false;
    }

    public void Save()
    {
        Console.Write("What is the name of the file you want to save to: ");
        _fileName = Console.ReadLine();
        string jsonString = JsonSerializer.Serialize(this);
        using (StreamWriter file = new StreamWriter($"{_fileName}.json"))
        {
            file.WriteLine(jsonString);
        }
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
        Console.Write("What is the name of the file you want to load from: ");
        _fileName = Console.ReadLine();
        string[] file = System.IO.File.ReadAllLines(_fileName);
        foreach (line in file)
        {
            Goal _goal = JsonSerializer.Deserialize<Goal>();
        }
    }

    protected void AddPoints(int totalPoints, int goalPoints)
    {
        _totalPoints = totalPoints + goalPoints;
    }

    //public int GetPoints()
    //{
    //    return _totalPoints;
    //}
    //
    //public int GetGoalPoints()
    //{
    //    return _goalPoints;
    //}

    public virtual void SetComplete()
    {
        _complete = true;
    }
}
