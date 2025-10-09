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

    }

    public void Run()
    {

    }
}
