namespace Develop05;

public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _pointsAssociated;


    public Goal(){}

    public Goal(string name, string description, int pointsAssociated)
        {
            this._goalName = name;
            this._goalDescription = description;
            this._pointsAssociated = pointsAssociated;
        }


    public abstract void RecordEvent();

    public abstract string IsComplete();
    public abstract void StartSettingGoal();
    public abstract string TextToBeDisplayedAtFileLvl();

    public void SetGoalName(string name)
    {
        this._goalName = name;
    }

    public void SetPointsAssociated(int point)
    {
        this._pointsAssociated = point;
    }

    public void SetGoalDescription(string description)
    {
        this._goalDescription = description;
    }


     public string GetGoalName()
    {
        return this._goalName;
    }

     public virtual int GetPointsAssociated()
    {
        return this._pointsAssociated;
    }

     public string GetGoalDescription()
    {   
        return this._goalDescription;
    }



}