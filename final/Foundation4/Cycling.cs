namespace Foundation4
{
    public class Cycling : Activity
    {
        private double _speed;

        public Cycling(string date, int length, double speed) : base(date, length)
        {
            this._speed = speed;
        }

        public override string GetSummary()
        {
            return $"{GetDate()} Cycling ({GetLength()} min) - Speed {GetSpeed():F1} mph";
        }

        public override double GetSpeed()
        {
            return _speed;
        }

    }
}