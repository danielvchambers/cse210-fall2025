public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string info, int points) : base(name, info, points)
    {
        //uses base constructor
        _goalType = "Simple";
    }

    public void SetComplete()
    {
        _complete = true;
    }
}
