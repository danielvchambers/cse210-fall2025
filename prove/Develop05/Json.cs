using System.Text.Json.Serialization;
using System.Text.Json;

class QuestFileFormat
{
    [JsonPropertyName("Total Points")]
    public string TotalPoints { get; set; }

    [JsonPropertyName("Simple Goals")]
    public List<Goal> SimpleGoals { get; set; }

    [JsonPropertyName("Eternal Goals")]
    public List<EternalGoal> EternalGoals { get; set; }

    [JsonPropertyName("Checklist Goals")]
    public List<ChecklistGoal> ChecklistGoals { get; set; }

    public static void SaveToJson(string fileName, int totalPoints, List<Goal> goals)
    {
        List<Goal> simpleGoals = new List<Goal>();
        List<EternalGoal> eternalGoals = new List<EternalGoal>();
        List<ChecklistGoal> checklistGoals = new List<ChecklistGoal>();

        foreach (Goal goal in goals)
        {
            if (goal is ChecklistGoal checklist)
            {
                checklistGoals.Add(checklist);
            }
            else if (goal is EternalGoal eternal)
            {
                eternalGoals.Add(eternal);
            }
            else
            {
                simpleGoals.Add(goal);
            }
        }

        Dictionary<string, object> quest = new Dictionary<string, object>();

        quest["Total Points"] = totalPoints.ToString();

        quest["Simple Goals"] = simpleGoals;
        quest["Eternal Goals"] = eternalGoals;
        quest["Checklist Goals"] = checklistGoals;

        string questJSON = JsonSerializer.Serialize(quest, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, questJSON);
    }

    public static Tuple<int, List<Goal>> LoadFromJson(string fileName)
    {
        string questJSON = System.IO.File.ReadAllText(fileName);

        QuestFileFormat questData = JsonSerializer.Deserialize<QuestFileFormat>(questJSON);

        int totalPoints = int.Parse(questData.TotalPoints);

        List<Goal> goals = new List<Goal>();

        // Simple Goals
        if (questData.SimpleGoals != null)
        {
            goals.AddRange(questData.SimpleGoals);
        }
        // Eternal Goals
        if (questData.EternalGoals != null)
        {
            goals.AddRange(questData.EternalGoals);
        }
        // Checklist Goals
        if (questData.ChecklistGoals != null)
        {
            goals.AddRange(questData.ChecklistGoals);
        }

        return new Tuple<int, List<Goal>>(totalPoints, goals);
    }
}
