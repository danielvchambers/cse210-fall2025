public class Entry
{
    List<string> prompts = new List<string>();
    Random r = new Random();
    public string _entry = "";
    public string _location = "";
    public string _dateText = "";
    public string _prompt;
    public Entry()
    {
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What was my favorite activity I did today?");
        prompts.Add("Did I play my favorite game today? What happened during it?");
        prompts.Add("Have I seen any blessings today?");
        prompts.Add("What did I eat today was my favorite?");
        prompts.Add("Did I do anything new today?");
        prompts.Add("Have I achieved all my goals for today?");
        prompts.Add("What are my goals for tomorrow?");
        prompts.Add("Are there any goals from yesterday I can do today?");
    }
    public void GivePrompt()
    {
        int index = r.Next(prompts.Count);
        _prompt = prompts[index];
        Console.WriteLine($"prompt: {_prompt}");
    }
    public void GetTime()
    {
        DateTime date = DateTime.Now;
        _dateText = date.ToShortDateString();
    }
    public void GetEntry()
    {
        Console.Write("> ");
        _entry = Console.ReadLine();
    }
    public void GetLocation()
    {
        Console.Write("What is your Location? ");
        _location = Console.ReadLine();
    }
}
