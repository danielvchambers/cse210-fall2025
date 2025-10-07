public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        string summary = $"Topic: {_topic} Name: {_studentName}";
        return summary;
    }
}
