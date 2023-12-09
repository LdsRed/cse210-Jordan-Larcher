namespace Foundation4;

public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    protected Activity(string date, int length)
    {
        SetDate(date);
        SetLength(length);
    }

    public abstract string GetSummary();
    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    private void SetDate(string date)
    {
        this._date = date;
    }

    protected string GetDate()
    {
        return this._date;
    }

    private void SetLength(int length)
    {
        this._lengthMinutes = length;
    }

    protected int GetLength()
    {
        return this._lengthMinutes;
    }


}