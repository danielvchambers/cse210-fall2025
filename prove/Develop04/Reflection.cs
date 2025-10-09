public class Reflection : Activities
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };

    public Reflection(int time) : base(time)
    {
        // ActivityName
        // Activity Instruction
    }

    protected void WaitingAnim(int duration)
    {
        List<string> animation = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(duration);
        int i = 0;
        while (DateTime.Now < _endTime)
        {

            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animation.Count())
            {
                i = 0;
            }
        }
    }

    public void Run()
    {
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_activityRunTime);
        base.DisplayRandIndex(_prompts);
        while (DateTime.Now <= _endTime)
        {
            WaitingAnim(5);
            base.DisplayRandIndex(_questions);
            Console.ReadLine();
        }
    }
}
