namespace Develop05;

public class EternalGoal : Goal
{


    public EternalGoal(string goalName, string description, int point) :
        base(goalName, description, point)
    { }

    public override void IsComplete()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}