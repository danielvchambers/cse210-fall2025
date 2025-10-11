using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s = new Square("Orange", 5);
        shapes.Add(s);

        Rectangle r = new Rectangle("Red", 10, 5);
        shapes.Add(r);

        Circle c = new Circle("Blue", 3);
        shapes.Add(c);

        foreach (Shape t in shapes)
        {
            Console.WriteLine($"{t.GetColor()}, Area {t.CalculateArea()}");
        }

    }
}
