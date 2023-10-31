public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private string _endingMessage;


    public Activity(){}
    public Activity(string activityName, string description, int duration, string endingMessage)
    {
        this._activityName = activityName;
        this._description = description;
        this._duration = duration;
        this._endingMessage = endingMessage;
    }


    public string DisplayStartingMessage()
    {
        return this._description;
    }

    public string DisplayEndingMessage()
    {
        return _endingMessage;
    }


    public string ShowSpinner()
    {
        return null;
    }


    public int ShowCountDownTimer()
    {
        return 0;
    }

}