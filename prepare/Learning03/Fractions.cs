public class Fraction
{
    private int _denominator;
    private int _numerator;

    public Fraction()
    {
        _denominator = 1;
        _numerator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public void SetFractNumerator()
    {
        string numerator;
        Console.Write("What is the numerator? ");
        numerator = Console.ReadLine();
        _numerator = int.Parse(numerator);
    }

    public void SetFractDenominator()
    {
        string Denominator;
        Console.Write("What is the Denominator? ");
        Denominator = Console.ReadLine();
        _denominator = int.Parse(Denominator);
    }

    public int GetFractNumerator()
    {
        return _numerator;
    }

    public int GetFractDenominator()
    {
        return _denominator;
    }

    public string GetFractString()
    {
        string _fraction = $"{_numerator}/{_denominator}";
        return _fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}
