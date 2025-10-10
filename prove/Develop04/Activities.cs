public class Activities
{
    private string _startMessage = "Welcome to this Mindful activity!";
    private string _endMessage = "Well done and have a good rest of your day!!";
    protected string _activityName;
    protected string _activityInstr;
    private Random ran = new Random();
    protected int _activityRunTime;

    public Activities(int time)
    {
        _activityRunTime = time;
    }

    protected virtual void WaitingAnim(int _increment)
    {
        for (int i = _increment; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
    }

    protected void DisplayRandIndex(List<string> list)
    {
        int randInt = ran.Next(list.Count);
        Console.WriteLine(list[randInt]);
    }

    public void DisplayStartMess()
    {
        Console.WriteLine(_startMessage);
    }

    public void DisplayEndMess()
    {
        Console.WriteLine(_endMessage);
    }
}
