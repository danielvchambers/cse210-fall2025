public class Swimming : Activity
{
    private int _laps;

    public Swimming(double length, int laps) : base(length)
    {
        _laps = laps;
    }

    public override double CalcDistance()
    {
        throw new NotImplementedException();
    }

    public override double CalcPace()
    {
        throw new NotImplementedException();
    }

    public override double CalcSpeed()
    {
        throw new NotImplementedException();
    }

    public override string Display()
    {
        throw new NotImplementedException();
    }
}
