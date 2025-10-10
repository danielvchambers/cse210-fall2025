public class Reflection : Activities
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you learned a new skill.",
        "Think of a time when someone helped you."
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
        "How can you keep this experience in mind in the future? ",
        "How can you share what you learned to others?",
        "What is something you can do better when a similar situation arrises?"
    };

    public Reflection(int time) : base(time)
    {
        base._activityName = "Reflection Activity";
        base._activityInstr = "This Activity will help you relfect on moments in your life and how you can find " +
                              "moments of strength in those moments that you can use in the future.";
    }

    protected override void WaitingAnim(int duration)
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
        Console.WriteLine($"\n{base._activityName}");
        Console.WriteLine(base._activityInstr);
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_activityRunTime);
        Console.Write($"\nHow many seconds do you want to think between questions? ");
        string think = Console.ReadLine();
        int _think = int.Parse(think);
        base.DisplayRandIndex(_prompts);
        while (DateTime.Now <= _endTime)
        {
            WaitingAnim(_think);
            base.DisplayRandIndex(_questions);
        }
    }
}
