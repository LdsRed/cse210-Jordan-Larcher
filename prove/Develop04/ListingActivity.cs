namespace Develop04;
    
public class ListingActivity : Activity
{

    private int _userInput;
    private List<string> _prompts;
    private List<string> _userAnswers = new List<string>();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good " +
                                                        "things in your life by having you list as many things as you " +
                                                        "can in a certain area.")
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public override string DisplayStartingMessage()
    {
        return $"Welcome to the {GetActivityName} \n\n{GetDescription}" ;
    }

    public override string DisplayEndingMessage()
    {
        return $"Well done!! \nYou have completed another {_userInput} seconds of the {GetActivityName}"; 
    }


    public void StartListingActivity()
    {
        Console.WriteLine(DisplayStartingMessage());
        Console.WriteLine();
        GetUserInput();
         
        Console.Clear();
        Listing();
        GetAnswersFromUser(_userInput);
       
        Console.WriteLine();
        Console.WriteLine($"You listed {_userAnswers.Count} items!");
        Console.WriteLine(DisplayEndingMessage());
    }

    private void GetUserInput()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _userInput = int.Parse(Console.ReadLine());
    }

    private void Listing()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("---" + GetRandomPrompt() + "---");
        Console.Write("You may begin in: ");
        ShowCountDownTimer(5);
        Console.WriteLine();
        
    }
    
    private string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int randomIndex = randomPrompt.Next(_prompts.Count);
        return _prompts[randomIndex];
    }


    private void GetAnswersFromUser(int userInput)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(userInput);

        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            _userAnswers.Add(Console.ReadLine());
        }
        
        
    }
    
}