public class Customer
{
    private string _name;
    private Address _address = new Address();

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUSA(string country)
    {
        switch (country)
        {
            case "USA":
                return true;

            default:
                return false;
        }
    }
}
