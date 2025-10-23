public class Product
{
    private string _name;
    private int _productID;
    private float _pricePerUnit;
    private int _quantity;

    public Product(string name, int productID, float pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public float CalcCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProduct()
    {
        return $"\nProduct ID: {_productID}\n" +
        $"Product: {_name}\n" +
        $"Price: ${_pricePerUnit}\n" +
        $"Quantity: {_quantity}";
    }
}
