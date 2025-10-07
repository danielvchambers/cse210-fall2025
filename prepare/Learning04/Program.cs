using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment _assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(_assignment.GetSummary());
        MathAssignment _math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine($"{_math.GetSummary()}\n{_math.GetHomeworkList()}");
        WritingAssignment _writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine($"{_writing.GetSummary()}\n{_writing.GetWritingInfo()}");
    }
}
