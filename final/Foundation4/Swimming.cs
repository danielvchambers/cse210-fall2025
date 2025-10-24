public class Swimming : Activity
{
    private double _laps;

    public Swimming(double length, string date, double laps) : base(length, date)
    {
        _laps = laps;
    }

    public override double CalcDistance()
    {
        return Math.Round((_laps * 50) / 1000, 2);
    }

    public override double CalcPace()
    {
        return Math.Round(_length / this.CalcDistance(), 2);
    }

    public override double CalcSpeed()
    {
        return Math.Round((this.CalcDistance() / _length) * 60, 2);
    }

    public override string Display()
    {
        return $"{_date} Swimming ({_length} min): " +
        $"Distance {this.CalcDistance()} km, " +
        $"Speed: {this.CalcSpeed()} kph, " +
        $"Pace: {this.CalcPace()} min per km";
    }
}
