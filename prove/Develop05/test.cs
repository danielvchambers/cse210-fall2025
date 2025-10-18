public class Tests
{
    static Goal _simpleGoal = new Goal("me", "do stuff", 3);
    static EternalGoal _eternalGoal = new EternalGoal("Mikayla", "do more stuff", 4);
    static ChecklistGoal _checklistGoal = new ChecklistGoal("Jarom", "do even more stuff", 5, 10, 7);
    public static void RunAllTest()
    {
        Console.WriteLine("running all tests");
        Test_Save_Goal();
        Test_Save_EternalGoal();
        Test_Save_ChecklistGoal();
    }

    public static void Test_Goal_Save()
    {

    }

    public static void Test_Save_Goal()
    {
        _simpleGoal.Save();
    }

    public static void Test_Save_EternalGoal()
    {
        _eternalGoal.Save();
    }

    public static void Test_Save_ChecklistGoal()
    {
        _checklistGoal.Save();
    }
}
