namespace Foundation4;

public class Running : Activity
{
    private double _distance;
    public Running(string date, int length, double distance) : base(date, length)
    {
        SetDistance(distance);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per mile";
    }

    public override double GetSpeed()
    {
        return (GetDistance()/ GetLength() * 60);
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override double GetDistance()
    {
        return _distance;
    }

    private void SetDistance(double distance)
    {
        this._distance = distance;
    }
}