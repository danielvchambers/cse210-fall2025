public class Activities
{
    private string _startMessage = "Welcome to this Mindful activity!";
    private string _endMessage = "Well done and have a good rest of your day!!";
    protected string _activityName;
    protected string _activityInstr;
    private int _increment;
    private Random ran = new Random();
    protected int _activityRunTime;

    public Activities(int time)
    {

    }

    protected virtual void WaitingAnim()
    {

    }

    protected void DisplayRandIndex(List<string> list)
    {

    }

    public void DisplayStartMess()
    {

    }

    public void DisplayEndMess()
    {

    }
}
