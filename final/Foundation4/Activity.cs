public abstract class Activity
{
    protected string _date;
    protected double _length;

    public Activity(double length, string date)
    {
        _length = length;
        _date = date;
    }

    public abstract double CalcDistance();
    public abstract double CalcSpeed();
    public abstract double CalcPace();
    public abstract string Display();
}
