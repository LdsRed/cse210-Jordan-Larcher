namespace Develop05;
using Newtonsoft.Json;
public class GoalFile
{
private string _fileName;

public GoalFile() { }

public void SaveGoalsToFile(List<Goal> goals, int points, string fileName)
{
    try
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {   
            outputFile.WriteLine(points);
            foreach (var line in goals)
            {
                outputFile.WriteLine(line.TextToBeDisplayedAtFileLvl());
            }

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error saving goals: " + ex.Message);
    }
}


public List<Goal> LoadGoalsFromFile(string fileName)
{
    List<Goal> loadedGoals = new List<Goal>();
    Menu menu = new();

    try
    {
        using (StreamReader inputFile = new StreamReader(fileName))
        {
            string line = inputFile.ReadLine();
            var points = int.Parse(line);
            menu.SetPointsEarned(points);

            while ((line = inputFile.ReadLine()) != null)
            {
                
                Goal goal = ParseGoalFromFile(line);

                if (goal != null)
                {
                    loadedGoals.Add(goal);
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error loading goals: " + ex.Message);
    }

    return loadedGoals;
}
private Goal ParseGoalFromFile(string line)
{
    
    string[] parts = line.Split(':');

    if (parts.Length >= 2)
    {
        var type = parts[0].Trim().ToLower();

        var details = parts[1].Split(',');

        switch (type)
        {
            case "simplegoal":
                return ParseSimpleGoal(details);
            case "eternalgoal":
                return ParseEternalGoal(details);
            case "checklistgoal":
                return ParseCheckListGoal(details);
            default:
                return null;
        }
        
    }

    return null;
}

private Goal ParseSimpleGoal(string[] details)
{
    
    string name = details[0];
    string description = details[1];
    int points = int.Parse(details[2]);
    bool isCompleted = bool.Parse(details[3]);

    return new SimpleGoal(name, description, points, isCompleted);
}


private Goal ParseEternalGoal(string[] details)
{
    var name = details[0];
    var description = details[1];
    var points = int.Parse(details[2]);

    return new EternalGoal(name, description, points);
}


private Goal ParseCheckListGoal(string[] details)
{
  

    var name = details[0];
    var description = details[1];
    var points = int.Parse(details[2]);
    var timesToComplete = int.Parse(details[4]);
    var bonusAmount = int.Parse(details[3]);
    var timesCompleted = int.Parse(details[5]);
    
    return new CheckListGoal(name, description, points, timesToComplete, bonusAmount, timesCompleted);;
}

public void SetFileName(string fileName)
{
    this._fileName = fileName;
} 

public string GetFileName()
{
    return this._fileName;
}
}