using System;

class Program
{
    static void Main(string[] args)
    {
        float avg = 0;
        int great = 0;
        float total = 0;
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string usrInput = Console.ReadLine();
            number = int.Parse(usrInput);
            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        foreach (int numb in numbers)
        {
            total = total + numb;
            avg = total / numbers.Count;
            if (numb > great)
            {
                great = numb;
            }
        }
        Console.WriteLine($"Your total: {total}");
        Console.WriteLine($"The Largest number: {great}");
        Console.WriteLine($"Your Average is: {avg}");
    }
}
