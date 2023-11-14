namespace Develop05;

public class CheckListGoal : Goal
{

    private int _timesAccomplished;
    private int _bonusAmount;

    public CheckListGoal(){}

    public CheckListGoal(string goalName, string description, int points, int _timesAccomplished, int bonusAmount) :
     base(goalName, description, points)
    {
        this._timesAccomplished = 0;
        this._bonusAmount = 0;
    }




    public override void IsComplete()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public void SetTimesAccomplished(int times)
    {
        this._timesAccomplished = times;
    }

    public void SetBonusAmount(int bonus)
    {
        this._bonusAmount = bonus;
    }


    public int GetTimesAccomplished()
    {
        return this._timesAccomplished;
    }

     public int GetBonusAmount()
    {
        return this._bonusAmount;
    }

}