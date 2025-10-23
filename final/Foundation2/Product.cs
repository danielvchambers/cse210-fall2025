public class Product
{
    private string _name;
    private int _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, int productID, double pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double CalcCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProduct()
    {
        return $"\n{_name}: {_productID}\n";
    }
}
