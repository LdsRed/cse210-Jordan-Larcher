namespace Develop05;

public class EternalGoal : Goal
{

    public EternalGoal(){}

    public EternalGoal(string goalName, string description, int point) :
        base(goalName, description, point)
    { }
    

    public override void RecordEvent()
    {
        
    }

    public override string IsComplete()
    {
        return "";
    }

    public override void StartSettingGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("What is a short description of it? ");
        SetGoalDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal? ");
        SetPointsAssociated(int.Parse(Console.ReadLine()));

    }

    public override string TextToBeDisplayedAtFileLvl()
    {
        return $"EternalGoal: {GetGoalName()}, {GetGoalDescription()}, {GetPointsAssociated()}";
        
    }


    public override string ToString()
    {
        return $"[{IsComplete()}] {GetGoalName()} ({GetGoalDescription()})";
    }
}