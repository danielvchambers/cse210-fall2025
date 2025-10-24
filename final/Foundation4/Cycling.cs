public class Cycling : Activity
{
    private double _speed;

    public Cycling(double length, double speed) : base(length)
    {
        _speed = speed;
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
