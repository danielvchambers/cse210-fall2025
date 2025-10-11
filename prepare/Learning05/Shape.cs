public abstract class Shape
{
    protected string _color;
    protected float _area;

    public Shape(string color)
    {
        _color = color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract float CalculateArea();
}
