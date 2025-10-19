// I used the base class as the simple goals as it was the base function
// Then I set up the load and save functions in a separate Json Class
// to save to a .json file and load from a .json file
// This is something we haven't been taught so here are some of my source files
// https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/overview
// https://learn.microsoft.com/en-us/dotnet/api/system.text.json?view=net-9.0
// https://stackoverflow.com/questions/4980500/literal-notation-for-dictionary-in-c
// https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer.serialize?view=net-9.0#system-text-json-jsonserializer-serialize(system-object-system-text-json-serialization-metadata-jsontypeinfo)
// I did a lot of research and trial and error I learned a lot and Realized by the end of this
// that I could have done something a lot simpler but in the end I am glad i did this because
// I learned a lot in how csharp works as a language.

using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

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
        int totalPoints = 0;
        string fileName;
        while (!end)
        {
            Console.Write($"\nYour Points: {totalPoints}\n\n" +
                "\nMenu" +
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
                            Console.Write("What is the name of your goal: ");
                            goalName = Console.ReadLine();
                            Console.Write("What is a Short Description of your goal: ");
                            goalInfo = Console.ReadLine();
                            Console.Write("How many points is this goal worth: ");
                            v = Console.ReadLine();
                            points = int.Parse(v);
                            Goal simple = new Goal(goalName, goalInfo, points);
                            goals.Add(simple);
                            break;
                        case 2:
                            Console.Write("What is the name of your goal: ");
                            goalName = Console.ReadLine();
                            Console.Write("What is a Short Description of your goal: ");
                            goalInfo = Console.ReadLine();
                            Console.Write("How many points is this goal worth: ");
                            v = Console.ReadLine();
                            points = int.Parse(v);
                            EternalGoal eternal = new EternalGoal(goalName, goalInfo, points);
                            goals.Add(eternal);
                            break;
                        case 3:
                            Console.Write("What is the name of your goal: ");
                            goalName = Console.ReadLine();
                            Console.Write("What is a Short Description of your goal: ");
                            goalInfo = Console.ReadLine();
                            Console.Write("How many times do you want to complete this goal: ");
                            v = Console.ReadLine();
                            int totalEvents = int.Parse(v);
                            Console.Write("How many points is this goal worth each time it is completed: ");
                            v = Console.ReadLine();
                            int pointsPerComplete = int.Parse(v);
                            Console.Write($"How many points do you get when your complete this goal all {totalEvents}: ");
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
                        Console.WriteLine(goal.Display());
                    }
                    break;
                case 3:
                    Console.Write("What is the name of the file you want to save to: ");
                    fileName = $"{Console.ReadLine()}.json";
                    QuestFileFormat.SaveToJson(fileName, totalPoints, goals);
                    break;
                case 4:
                    Console.Write("What is the name of the file you want to load from: ");
                    fileName = Console.ReadLine();
                    Tuple<int, List<Goal>> data = QuestFileFormat.LoadFromJson($"{fileName}.json");
                    totalPoints = data.Item1;
                    goals = data.Item2;
                    break;
                case 5:
                    if (goals.Count == 0)
                    {
                        Console.WriteLine("You have no goals to record.");
                    }

                    else
                    {
                        Console.WriteLine("Your goals are:");
                        for (int i = 0; i < goals.Count(); i++)
                        {
                            Console.WriteLine($"{i + 1}. {goals[i].Display()}");
                        }

                        Console.Write("Which goal do you want to record an event for? ");
                        string r = Console.ReadLine();
                        choice = int.Parse(r);
                        choice = choice - 1;
                        totalPoints = goals[choice].AddPoints(totalPoints, goals[choice].GetPoints());
                        goals[choice].SetComplete();
                    }
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
