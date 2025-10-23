using System.Text;

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

    public string PackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (Product product in _products)
        {
            packingLabel.Append(product.GetProduct());
        }

        return packingLabel.ToString();
    }

    public double CalcTotalCost()
    {
        double totalCost = 0;
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

        return Math.Round(totalCost, 2);
    }

    public void AddProduct(string name, int id, double price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _products.Add(product);
    }
}
