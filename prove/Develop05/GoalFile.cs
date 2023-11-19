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
    
    var parts = line.Split(',');

    if (parts.Length < 1)
    {
        
        var type = parts[0].Trim().ToLower();

        switch (type)
        {
            case "simplegoal":
                return ParseSimpleGoal(parts);
            case "eternalgoal":
                return ParseEternalGoal(parts);
            case "checklistgoal":
                return ParseCheckListGoal(parts);
            default:
                return null;
        }
    }

    return null;
}

private Goal ParseSimpleGoal(string[] parts)
{
    
    var name = parts[1];
    var description = parts[2];
    var points = int.Parse(parts[3]);
    var isCompleted = bool.Parse(parts[4]);

    return new SimpleGoal(name, description, points, isCompleted);
}


private Goal ParseEternalGoal(string[] parts)
{
    var name = parts[1];
    var description = parts[2];
    var points = int.Parse(parts[3]);

    return new EternalGoal(name, description, points);
}


private Goal ParseCheckListGoal(string[] parts)
{
  

    var name = parts[1];
    var description = parts[2];
    var points = int.Parse(parts[3]);
    var timesToComplete = int.Parse(parts[4]);
    var bonusAmount = int.Parse(parts[5]);
    var timesCompleted = int.Parse(parts[6]);
    
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