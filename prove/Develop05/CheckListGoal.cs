namespace Develop05;

public class CheckListGoal : Goal
{

    private int _timesToComplete;
    private int _bonusAmount;
    private int _timesCompleted;

    public CheckListGoal(){}

    public CheckListGoal(string goalName, string description, int points, int timesToComplete, int bonusAmount) :
     base(goalName, description, points)
    {
        this._timesToComplete = 0;
        this._bonusAmount = 0;
    }




    public override string IsComplete()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public void SetTimesToComplete(int times)
    {
        this._timesToComplete = times;
    }

    public void SetBonusAmount(int bonus)
    {
        this._bonusAmount = bonus;
    }


    public int GetTimesToComplete()
    {
        return this._timesToComplete;
    }

     public int GetBonusAmount()
    {
        return this._bonusAmount;
    }

     public void SetTimesCompleted(int timesCompleted)
     {
         this._timesCompleted = timesCompleted;
     }

     public int GetTimesCompleted()
     {
         return this._timesCompleted;
     }
     public override void StartSettingGoal()
     {
         Console.WriteLine("What is the name of your goal? ");
         SetGoalName(Console.ReadLine());
         Console.WriteLine("What is a short description of it? ");
         SetGoalDescription(Console.ReadLine());
         Console.WriteLine("What is the amount of points associated with this goal? ");
         SetPoints(int.Parse(Console.ReadLine() ?? string.Empty));
         Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
         SetTimesToComplete(int.Parse(Console.ReadLine() ?? string.Empty));
         Console.WriteLine("What is the bonus for accomplishing it that many times? ");
         SetBonusAmount(int.Parse(Console.ReadLine() ?? string.Empty));
     }
     
     public override string ToString()
     {
         return $"[{IsComplete()}] {GetGoalName()} ({GetGoalDescription()} -- Currently completed: {GetTimesCompleted()}/{GetTimesToComplete()})";
     }

}