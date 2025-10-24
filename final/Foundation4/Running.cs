public class Running : Activity
{
    private Double _distance;

    public Running(double length, string date, double distance) : base(length, date)
    {
        _distance = distance;
    }

    public override string Display()
    {
        return $"{_date} Running ({_length} min): " +
        $"Distance {this.CalcDistance()} km, " +
        $"Speed: {this.CalcSpeed()} kph, " +
        $"Pace: {this.CalcPace()} min per km";
    }

    public override double CalcDistance()
    {
        return Math.Round(_distance, 2);
    }

    public override double CalcPace()
    {
        return Math.Round(_length / _distance, 2);
    }

    public override double CalcSpeed()
    {
        return Math.Round((_distance / _length) * 60, 2);
    }
}
