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
        throw new NotImplementedException();
    }

    public override void StartSettingGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("What is a short description of it? ");
        SetGoalDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine() ?? string.Empty));
        
    }


    public override string ToString()
    {
        return $"Goal name:{GetGoalName()}."
        + $"\nGoal description: {GetGoalDescription()}"
        + $"\npoints given if completed:{GetPoints()}"
        + $"\nIs the goal completed? {GetIsCompleted()}";
    }

    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
}