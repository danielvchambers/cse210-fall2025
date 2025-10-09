public class Listing : Activities
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate? ",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the Holy Ghost this month? ",
        "Who are some of your personal heroes? "
    };

    private List<string> _responses = new List<string>();
    private string _response;

    public Listing(int time) : base(time)
    {
        base._activityName = "Listing Activity";
        base._activityInstr = "This Activity will help you reflect on some of the good things in your life by" +
                              "having you list good things based off a prompt given at the beginning of the activity";
    }

    public void Run()
    {
        base.DisplayRandIndex(_prompts);
        Console.WriteLine("List as many items as you can hitting enter after each one.");
        base.WaitingAnim();
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_activityRunTime);
        while (DateTime.Now <= _endTime)
        {
            _response = Console.ReadLine();
            _responses.Add(_response);
        }
        Console.WriteLine(_responses.Count());
    }
}
