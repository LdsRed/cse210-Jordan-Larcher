using System.Runtime.InteropServices.JavaScript;

namespace Develop05;

public class SimpleGoal : Goal
{

    private Boolean _isCompleted;
    
    
    public SimpleGoal(string goalName, string description, int points, Boolean isCompleted) : 
        base(goalName, description, points)
    {
        this._isCompleted = isCompleted;
    }

    public override void IsComplete()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}