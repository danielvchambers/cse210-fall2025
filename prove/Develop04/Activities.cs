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

    protected void WaitingAnim()
    {
        List<string> animation = new List<string>
        {
            "5",
            "4",
            "3",
            "2",
            "1",
        };

        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(5);
        int i = 0;
        while (DateTime.Now < _endTime)
        {

            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= animation.Count())
            {
                i = 0;
            }
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
