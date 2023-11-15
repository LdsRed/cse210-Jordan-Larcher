namespace Develop05;

public class GoalFile
{
    
    private string _fileName;

    public GoalFile(){}


   public void SaveFile(List<string> dataToSave)
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();


    
        try
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
    
                foreach (var lines in dataToSave)
                {
                    outputFile.WriteLine(lines);
                }
    
    
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
            
    
    }

    



    public List<string> LoadGoalFile()
    {
        Console.WriteLine("What is the filename/path? ");
        string filename = Console.ReadLine();
        Console.WriteLine();

        StreamReader reader = new StreamReader(filename);

        List<string> lines = new List<string>();
        string line = reader.ReadLine();

        while (line != null)
        {
            lines.Add(line);
            line = reader.ReadLine();
        }
        
        reader.Close();

        return lines;

    }
}