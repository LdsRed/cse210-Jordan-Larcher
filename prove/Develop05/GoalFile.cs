    namespace Develop05;
    using Newtonsoft.Json;
    public class GoalFile
    {
    private string _fileName;

    public GoalFile() { }

    public void SaveGoalsToFile(List<Goal> goals, int points)
    {
        string fileName = GetFileName();
        try
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {   
                outputFile.WriteLine($"Total points saved: {points}");
                foreach (var line in goals)
                {
                    outputFile.WriteLine(line.ToString());
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving goals: " + ex.Message);
        }
    }


    public void LoadGoalsFromFile()
    {
        try
        {
            string fileName = GetFileName();
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                string[] parts = line.Split(",");

                string name = parts[0];
                string description = parts[1];

                Console.WriteLine($"{name} - {description}");
            }
            
        }
        catch (Exception e) 
        {
            Console.WriteLine("Error loading the goals: " + e.Message);
        }
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