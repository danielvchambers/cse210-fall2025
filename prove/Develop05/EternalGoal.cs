public class EternalGoal : Goal
{
    public EternalGoal(string name, string info, int points) : base(name, info, points)
    {
        // Just to make sure this is always comes out as incomplete
        _complete = false;
        _goalType = "Eternal";
    }
}
