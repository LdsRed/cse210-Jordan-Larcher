namespace Develop04;
using System;
using System.Timers;
public class ReflectingActivity : Activity
{

    private int _userInput;
    private List<string> _prompts;
    private List<string> _reflexion;

    private static bool _userInputReceived = false;


    public ReflectingActivity() :
        base("Reflecting Activity", "This activity will help you reflect on times in your " +
                                    "life when you have shown strength and resilience. " +
                                    "This will help you recognize the power you have and how you can " +
                                    "use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _reflexion = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
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


    private string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int randomIndex = randomPrompt.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
    

    private void DisplayPrompt()
    {
        string userInput;
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"----{GetRandomPrompt()}----");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue. Otherwise in next 10 seconds" +
                          "we will continue with the activity");
        
        userInput = Console.ReadLine();
    }

    private void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()}");
        ShowSpinner();
        Console.WriteLine();
        
    }
    
    private string GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        int randomIndex = randomQuestion.Next(_reflexion.Count); 
        return _reflexion[randomIndex];
    }
    
    
    public void StartReflectingActivity()
    {
        DateTime startTime = DateTime.Now;
        
        Console.WriteLine(DisplayStartingMessage());
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _userInput = int.Parse(Console.ReadLine());
        DateTime endTime = startTime.AddSeconds(_userInput);
        
        
        Console.Clear();
        
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine();
        
        DisplayPrompt();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDownTimer(5);
        Console.WriteLine();
        
        while(DateTime.Now < endTime)
        {
            DisplayQuestion();    
        }
        
        
        Console.WriteLine();
        Console.WriteLine(DisplayEndingMessage());
        ShowSpinner();
        
    }
    
    
}

