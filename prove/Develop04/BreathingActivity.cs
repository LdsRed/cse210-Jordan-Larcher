namespace Develop04;

class BreathingActivity : Activity
{

    private int _userInput;
    public BreathingActivity()
        : base("Breathing Activity",
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and" +
            " focus on your breathing.")
    {
    }


    public override string DisplayStartingMessage()
    {
        return $"Welcome to the {GetActivityName} \n\n{GetDescription}" ;
    }

    public override string DisplayEndingMessage()
    {
        return $"Well done!! \nYou have completed another {_userInput} seconds of the {GetActivityName}"; 
    }


    private void AlternatingBreath(int userInput)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(userInput);

        while(DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDownTimer(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDownTimer(6);
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public void StartBreathingActivity()
    {
        Console.WriteLine(DisplayStartingMessage());
        Console.Write("How long, in seconds, would you like for your session? ");
        _userInput = int.Parse(Console.ReadLine());
        
        Console.Clear();
        
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine();
        
        AlternatingBreath(_userInput);
        
        Console.WriteLine();
        Console.WriteLine(DisplayEndingMessage());
        ShowSpinner();
        
        

    }

    
    
    
}