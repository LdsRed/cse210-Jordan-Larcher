namespace Develop05;

public class EternalGoal : Goal
{

    public EternalGoal(){}

    public EternalGoal(string goalName, string description, int point) :
        base(goalName, description, point)
    { }
    
    // public override string IsComplete()
    // {
    //     if (this._isCompleted)
    //     {
    //         return "X";
    //     }
    //     else
    //     {
    //         return "";
    //     }
    // }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override string IsComplete()
    {
        throw new NotImplementedException();
    }

    public override void StartSettingGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("What is a short description of it? ");
        SetGoalDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()));
        
    }


    public override string ToString()
    {
        return $"[{IsComplete()}] {GetGoalName()} ({GetGoalDescription()})";
    }
}