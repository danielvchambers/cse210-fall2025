public class Square : Shape
{
    private float _side;

    public Square(string color, float side) : base(color)
    {
        _side = side;
    }

    public override float CalculateArea()
    {
        _area = MathF.Pow(_side, 2);
        return _area;
    }
}
