namespace Develop05;

public class GoalFile
{
    
    private string _fileName;

    public GoalFile(){}


    public void SaveFile()
    {
        Console.WriteLine();
        Console.WriteLine("What is the name of the file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {

            foreach (Entry entries in _entries)
            {
                outputFile.WriteLine(entries.TransformToString());
            }


        }

        listOfFilenames.Add(_fileName);

    }

    


    //Option 1
    public void WriteEntry()
    {

        Entry entry = new();
        PromptGenerator generator = new();
        string prompt = generator.GeneratePrompt();
        entry.SetPrompt(prompt);
        Console.WriteLine(prompt);
        entry.SetEntry(Console.ReadLine());
        entry.SetDate();
        _entries.Add(entry);

    }




    public void LoadJournalFile()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        string data;
        string input;
        Console.WriteLine();

        StreamReader reader = null;

        try
        {
            reader = new StreamReader(filename);
            data = reader.ReadLine();
            Boolean response = true;
            while (response)
            {
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to load another file? (Yes/No)");
                input = Console.ReadLine();

                if (input.ToLower() == "yes")
                {
                    Console.WriteLine("What is the filename? ");
                    filename = Console.ReadLine();
                    reader = new StreamReader(filename);
                    data = reader.ReadLine();
                    while (data != null)
                    {
                        Console.WriteLine(data);
                        data = reader.ReadLine();
                        Console.WriteLine();
                    }
                }
                else
                {
                    response = false;
                }
            }
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }

    }
}