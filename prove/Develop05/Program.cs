using System;

class Program
{
    static void Main(string[] args)
    {
        bool end = false;
        int choice;
        List<Goal> goals = new List<Goal>();
        string goalName;
        string goalInfo;
        int points;
        while (!end)
        {
            Console.Write("\nMenu" +
                "\n1. Create new goal" +
                "\n2. Display goals" +
                "\n3. Save goals" +
                "\n4. Load goals" +
                "\n5. Record Event" +
                "\n6. Quit" +
                "\n7. test program" +
                "\nSelect a number from the menu: "
            );

            string v = Console.ReadLine();
            choice = int.Parse(v);
            switch (choice)
            {
                case 1:
                    Console.Write("\nWhat kind of goal would you like to create?" +
                        "\n1. Simple Goal" +
                        "\n2. Eternal Goal" +
                        "\n3. Checklist Goal" +
                        "\nPick a number from the above list: "
                    );
                    v = Console.ReadLine();
                    choice = int.Parse(v);
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("What is the name of your goal: ");
                            goalName = Console.ReadLine();
                            Console.WriteLine("What is a Short Description of your goal: ");
                            goalInfo = Console.ReadLine();
                            Console.WriteLine("How many points is this goal worth: ");
                            v = Console.ReadLine();
                            points = int.Parse(v);
                            Goal simple = new Goal(goalName, goalInfo, points);
                            goals.Add(simple);
                            break;
                        case 2:
                            Console.WriteLine("What is the name of your goal: ");
                            goalName = Console.ReadLine();
                            Console.WriteLine("What is a Short Description of your goal: ");
                            goalInfo = Console.ReadLine();
                            Console.WriteLine("How many points is this goal worth: ");
                            v = Console.ReadLine();
                            points = int.Parse(v);
                            EternalGoal eternal = new EternalGoal(goalName, goalInfo, points);
                            goals.Add(eternal);
                            break;
                        case 3:
                            Console.WriteLine("What is the name of your goal: ");
                            goalName = Console.ReadLine();
                            Console.WriteLine("What is a Short Description of your goal: ");
                            goalInfo = Console.ReadLine();
                            Console.WriteLine("How many times do you want to complete this goal: ");
                            v = Console.ReadLine();
                            int totalEvents = int.Parse(v);
                            Console.WriteLine("How many points is this goal worth each time it is completed: ");
                            v = Console.ReadLine();
                            int pointsPerComplete = int.Parse(v);
                            Console.WriteLine($"How many points do you get when your complete this goal all {totalEvents}: ");
                            v = Console.ReadLine();
                            points = int.Parse(v);
                            ChecklistGoal checklist = new ChecklistGoal(goalName, goalInfo, points, totalEvents, pointsPerComplete);
                            goals.Add(checklist);
                            break;
                    }
                    break;
                case 2:
                    foreach (Goal goal in goals)
                    {
                        goal.Display();
                    }
                    break;
                case 3:
                    foreach (Goal goal in goals)
                    {
                        goal.Save();
                    }
                    break;
                case 4:
                    //Load goals
                    break;
                case 5:
                    //Record Event
                    break;
                case 6:
                    end = true;
                    break;
                case 7:
                    Tests.RunAllTest();
                    break;
            }

        }
    }
}
