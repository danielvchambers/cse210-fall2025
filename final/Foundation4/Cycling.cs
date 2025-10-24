public class Cycling : Activity
{
    private double _speed;

    public Cycling(double length, string date, double speed) : base(length, date)
    {
        _speed = speed;
    }

    public override double CalcDistance()
    {
        return Math.Round(_speed * (_length / 60), 2);
    }

    public override double CalcPace()
    {
        return Math.Round(_length / this.CalcDistance(), 2);
    }

    public override double CalcSpeed()
    {
        return Math.Round(_speed, 2);
    }

    public override string Display()
    {
        return $"{_date} Cycling ({_length} min): " +
        $"Distance {this.CalcDistance()} km, " +
        $"Speed: {this.CalcSpeed()} kph, " +
        $"Pace: {this.CalcPace()} min per km";
    }
}
