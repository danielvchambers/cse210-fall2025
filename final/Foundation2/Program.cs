using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("905 King Street West Unit 310", "Toronto", "ON M5V 3E9", "Canada");
        Customer customer1 = new Customer("Alex Chen", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct("Ergonomic Office Chair", 450012, 249.99, 1);
        order1.AddProduct("Portable SSD (1TB)", 770239, 89.99, 2);
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalcTotalCost()}");

        Address address2 = new Address("845 N. Cypress St.", "Austin", "Texas", "USA");
        Customer customer2 = new Customer("Maria Garcia", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct("The Midnight Forest (Hardcover Novel)", 103456, 27.50, 1);
        order2.AddProduct("Premium Sketchbook (A4 Size)", 210988, 14.95, 3);
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalcTotalCost()}");
    }
}
