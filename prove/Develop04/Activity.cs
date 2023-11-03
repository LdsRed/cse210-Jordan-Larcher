namespace Develop04;

public abstract class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private string _endingMessage;


    protected Activity(){}

    protected Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    protected Activity(string activityName, string description, int duration)
    {
        this._activityName = activityName;
        this._description = description;
        this._duration = duration;
        this._endingMessage = "Well Done!" ;
    }



    public abstract string DisplayStartingMessage();
    

    public abstract string DisplayEndingMessage();


    protected static void ShowSpinner()
    {
        List<string> spinnerAnimation = new List<string>();
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\");
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\");

        foreach (var s in spinnerAnimation)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        
    }


    protected static void ShowCountDownTimer()
    {
        for (var i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }

    }

    //Getters & Setters 
    protected string GetActivityName => _activityName;

    public void SetActivityName(string activityName)
    {
        this._activityName = activityName;
    }

    protected string GetDescription => _description;

    public void SetDescription(string description)
    {
        this._description = description;
    }
    public int GetDuration => _duration;

    public void SetDuration(int duration)
    {
        this._duration = duration;
    }
    public string GetEndingMessage => _endingMessage;

    public void SetEndingMessage(string endingMessage)
    {
        this._endingMessage = endingMessage;
    }

   
}