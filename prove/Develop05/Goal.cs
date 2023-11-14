namespace Develop05;

public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _pointsAssociated;

    private string _eventRecorded;


    public Goal(){}
    
    public Goal(String name, string description, int pointsAssociated)
        {
            this._goalName = name;
            this._goalDescription = description;
            this._pointsAssociated = pointsAssociated;
        }


    public abstract void RecordEvent();

    public abstract void IsComplete();
    
    public void SetGoalName(string name)
    {
        this._goalName = name;
    }

    public void SetPoints(int point)
    {
        this._pointsAssociated = point;
    }
    
    public void SetGoalDescription(string description)
    {
        this._goalDescription = description;
    }


     public string GetGoalName(string name)
    {
        return this._goalName;
    }

    public int GetPoints(int point)
    {
        return this._pointsAssociated;
    }
    
    public string GetGoalDescription(string description)
    {   
        return this._goalDescription;
    }



}