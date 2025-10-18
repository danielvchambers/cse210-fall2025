public class Goal
{
    private string _fileName;
    private string _goalName;
    private string _goalInfo;
    private string _goalType;
    private int _goalPoints;
    private int _totalPoints;
    protected bool _complete = false;

    public Goal(string name, string info, int points)
    {
        _goalName = name;
        _goalInfo = info;
        _goalPoints = points;
        _complete = false;
    }

    public virtual void Save(Goal goal)
    {
        //save method
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

    public virtual void LoadFile()
    {
        //Load Method
    }

    public void AddPoints(int totalPoints, int goalPoints)
    {
        _totalPoints = totalPoints + goalPoints;
    }
}
