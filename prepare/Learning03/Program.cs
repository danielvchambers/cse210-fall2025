using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction();
        Fraction fract2 = new Fraction(5);
        Fraction fract3 = new Fraction(3, 4);

        string fraction1 = fract1.GetFractString();
        double decimal1 = fract1.GetDecimalValue();
        Console.WriteLine($"{fraction1}\n{decimal1}");
        string fraction2 = fract2.GetFractString();
        double decimal2 = fract2.GetDecimalValue();
        Console.WriteLine($"{fraction2}\n{decimal2}");
        string fraction3 = fract3.GetFractString();
        double decimal3 = fract3.GetDecimalValue();
        Console.WriteLine($"{fraction3}\n{decimal3}");

        fract3.SetFractDenominator();
        fract3.SetFractNumerator();

        fraction3 = fract3.GetFractString();
        decimal3 = fract3.GetDecimalValue();
        Console.WriteLine($"{fraction3}\n{decimal3}");

    }
}
