

public  class PromptGenerator
{

    //Variable member
    List<string> _prompt = new() {
        {"Who was the most interesting person I interacted with today?"},
        {"What was the best part of my day?"},
        {"How did I see the hand of the Lord in my life today?"},
        {"What was the strongest emotion I felt today?"},
        {"If I had one thing I could do over today, what would it be?"},
        {"What scripture did you like today?"},
        {"Were you able to complete your goals today?"}

    };


    public PromptGenerator()
    {

    }
    
    public string GeneratePrompt()
    {
        Random rand = new();
        string prompts = _prompt[rand.Next(_prompt.Count)];
        return prompts;
        
    }


}