public abstract class Activity
{
    protected DateOnly _date = new DateOnly();
    protected double _length;

    public Activity(double length)
    {
        _length = length;
    }

    public abstract double CalcDistance();
    public abstract double CalcSpeed();
    public abstract double CalcPace();
    public abstract string Display();
}
