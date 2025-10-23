public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public string ShippingLabel()
    {
        return $"\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }

    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProduct());
        }
    }

    public float CalcTotalCost()
    {
        float totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost = totalCost + product.CalcCost();
        }

        if (_customer.InUSA())
        {
            totalCost = totalCost + 5;
        }

        else
        {
            totalCost = totalCost + 35;
        }

        return totalCost;
    }
}
