using System.Runtime.InteropServices.JavaScript;

namespace Develop05;

public class SimpleGoal : Goal
{

    private bool _isCompleted = false;
    

    public SimpleGoal(){}
    public SimpleGoal(string goalName, string description, int points, bool isCompleted) : 
        base(goalName, description, points)
    {
        this._isCompleted = isCompleted;
    }

    public override string IsComplete()
    {
        return this._isCompleted ? "X" : "";
    }

    public override void RecordEvent()
    {
        const bool completed = true;
        SetIsCompleted(completed);
    }

    public override void StartSettingGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("What is a short description of it? ");
        SetGoalDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal? ");
        SetPointsAssociated(int.Parse(Console.ReadLine() ?? string.Empty));
        
    }


    public override string ToString()
    {
        return $"[{IsComplete()}] {GetGoalName()} ({GetGoalDescription()})";
    }

    public override string TextToBeDisplayedAtFileLvl()
    {
        return $"SimpleGoal: {GetGoalName()}, {GetGoalDescription()}, {GetPointsAssociated()}, {GetIsCompleted()}";
    }

    private bool GetIsCompleted()
    {
        return _isCompleted;
    }

    private void SetIsCompleted(bool isCompleted)
    {
        this._isCompleted = isCompleted;
    }
}