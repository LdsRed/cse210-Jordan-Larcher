using System.Transactions;

public class Entry
{


    string _prompt;
    string _entry;

    string _date;



    //Constructor
    public Entry()
    {

    }


    //MethodsA
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt} \n{_entry}");
        Console.WriteLine();
    }

    public string TransformToString(){
        string dataDisplayed = $"Date: {_date} - Prompt: {_prompt} \n{_entry}";
        return dataDisplayed;
    }
    public void SetEntry(string entry)
    {
        _entry = entry;
    }

    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }

    public void SetDate()
    {
        DateTime dateToday = DateTime.Now;
        _date = dateToday.ToShortDateString();
    }
    
}