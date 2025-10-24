public class Running : Activity
{
    private Double _distance;

    Running(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    public override string Display()
    {
        return $"";
    }

    public override double CalcDistance()
    {
        return _distance;
    }

    public override double CalcPace()
    {
        return _length / _distance;
    }

    public override double CalcSpeed()
    {
        return (_distance / _length) * 60;
    }
}
