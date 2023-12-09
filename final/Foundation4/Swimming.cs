namespace Foundation4;

public class Swimming : Activity
{
    private int _lapsNumber;

    public Swimming(string date, int length, int lapsNumber) : base(date, length)
    {
       SetLapsNumber(lapsNumber);
    }

    private void SetLapsNumber(int laps)
    {
        _lapsNumber = laps;
    }

    private int GetLaps()
    {
        return this._lapsNumber;
    }
    
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min) - Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override double GetDistance()
    {
        return _lapsNumber * 50 / 1000.0;
    }
}