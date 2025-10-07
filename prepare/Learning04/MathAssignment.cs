public class MathAssignment : Assignment
{
    protected string _textbookSection;
    protected string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string homework = $"Section: {_textbookSection} Problems: {_problems}";
        return homework;
    }
}
